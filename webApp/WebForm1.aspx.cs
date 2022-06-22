using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading;

namespace projekt
{    
    public partial class WebForm1 : System.Web.UI.Page
    {
        public const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True";
        public SqlConnection Connection = new SqlConnection(ConnectionString);
        
        public void PasswordGenerator(object sender, EventArgs e)
        {
            if (generatePasswordTextBox.Text != "") {
                int passwordLenght = Int32.Parse(generatePasswordTextBox.Text);
                string password = "";
                while (passwordLenght > 0)
                {
                    Random rand = new Random();
                    Thread.Sleep(50);
                    int number = rand.Next(0, 4);
                    if (number == 0)
                    {
                        rand = new Random();
                        int number2 = rand.Next(0, 9);
                        password += number2.ToString();
                    }
                    else if (number == 1)
                    {
                        rand = new Random();
                        char randomChar = (char)rand.Next('a', 'z');
                        password += randomChar;
                    }
                    else if (number == 2)
                    {
                        rand = new Random();
                        char randomChar = (char)rand.Next('A', 'Z');
                        password += randomChar;
                    }
                    else
                    {
                        rand = new Random();
                        char[] passwd = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')' };
                        number = rand.Next(0, 9);
                        password += passwd[number];
                    }
                    passwordLenght--;
                }
                result.InnerText = password;
                
            }
            result.Visible = true;
            checkAdressButton.Visible = false;
            checkAdressTextBox.Visible = false;
            generatePasswordTextBox.Visible = true;
            generatePasswordButton.Visible = true;
            weryfikacja.Visible = false;
        }

        public void Notification(object sender, EventArgs e)
        {
            Connection.Open();
            new SqlCommand(string.Format("set dateformat dmy;insert into ToCheck values ('{0}','{1}',0)", notifyAdressTextBox.Text,DateTime.Now),Connection).ExecuteNonQuery();
            Connection.Close();
        }

        public void Page_Init(object sender, EventArgs e)
        {
            checkAdressTextBox.Text = Request.Params.Get("address");
        }

        public void Page_PreLoad(object sender, EventArgs e)
        {
            checkAdressTextBox.Visible = true;
            notifyAdressTextBox.Visible = false;
            checkAdressButton.Visible = true;
            notifyAdressButton.Visible = false;
            result.Visible = true;
            generatePasswordTextBox.Visible = false;
            generatePasswordButton.Visible = false;
            generatePasswordPageButton.Visible = false;
            plansForFutureButton.Visible = false;
            notifyAdressPageButton.Visible = false;
            checkPageAdressButton.Visible = false;
            
            
            
        }


        public bool CreateRegularExpression(string pat, string text)
        {
            int o = 0;
            string truePat = "";
            while (o < pat.Length)
            {
                if (pat.Substring(o,1) is " ") {
                    break;
                }
                o++;
            }
            truePat = truePat + pat.Substring(0,o);
             

            Regex r = new Regex(truePat);

            Match m = r.Match(text);

            if (m.Success)
            {
                return true;

            }
            else 
            {
                return false;
            }
        }

        public void ReturnToMainPage(object sender, EventArgs e)
        {
            generatePasswordDiv.Visible = true;
            generatePasswordPageButton.Visible = true;
            checkPageAdressDiv.Visible = true;
            checkPageAdressButton.Visible=true;
            plansForFutureDiv.Visible = true;
            plansForFutureButton.Visible = true;
            notifyAdressDiv.Visible = true;
            notifyAdressPageButton.Visible = true;
            result.Visible = false; 
            checkAdressTextBox.Visible = false;
            checkAdressButton.Visible = false;
            returnToMainPageButton.Visible = false;
            result.InnerText = " ";
            pomocniczy.Visible = true;
            zaloguj_sie.Visible = false;
            container_top.Visible = true;
            zaloguj_sie.Visible = false;
            zaloguj_button.Visible = true;
            MenuTop.Visible = true;
            weryfikacja.Visible = false;



        }
       
        public void SetCheckAdressPageVisible(object sender, EventArgs e)
        {
            checkAdressTextBox.Visible = true;
            checkAdressButton.Visible = true;
            notifyAdressTextBox.Visible = false;
            notifyAdressButton.Visible = false;
            generatePasswordDiv.Visible = false;
            checkPageAdressDiv.Visible = false;
            plansForFutureDiv.Visible = false;
            notifyAdressDiv.Visible = false;
            result.Visible = false;
        }

        public void SetPasswordGeneratorVisible(object sender, EventArgs e)
        {
            generatePasswordTextBox.Visible = true;
            generatePasswordButton.Visible = true;
            result.Visible = true;
            checkAdressButton.Visible = false;
            checkAdressTextBox.Visible = false;
            checkAdressTextBox.Visible = false;
            checkAdressButton.Visible = false;
            generatePasswordDiv.Visible = false;
            checkPageAdressDiv.Visible = false;
            plansForFutureDiv.Visible = false;
            notifyAdressDiv.Visible = false;
        }

        public void SetPlansForFutureVisible(object sender, EventArgs e)
        {
            generatePasswordDiv.Visible = false;
            checkPageAdressDiv.Visible = false;
            plansForFutureDiv.Visible = false;
            notifyAdressDiv.Visible = false;
            generatePasswordButton.Visible = false;
            checkAdressButton.Visible = false;
            checkAdressTextBox.Visible = false;
            result.Visible = false;
        }

        public void SetNotificationPageVisible(object sender, EventArgs e)
        {
            notifyAdressTextBox.Visible = true;
            notifyAdressButton.Visible = true;
            returnToMainPageButton.Visible = true;
            result.Visible = true;
            checkAdressButton.Visible = false;
            checkAdressTextBox.Visible = false;
            generatePasswordDiv.Visible = false;
            checkPageAdressDiv.Visible = false;
            plansForFutureDiv.Visible = false;
            notifyAdressDiv.Visible = false;
        }

        public void CheckAdress(object sender, EventArgs e) 
        {
            bool Safe = true;
            string Linked = checkAdressTextBox.Text;
            Connection.Open();
            var Reader= new SqlCommand(string.Format("select Link from Safe "), Connection).ExecuteReader();
            while (Reader.Read()) 
            {
                string i = Reader.GetString(0);
                Safe = CreateRegularExpression(i, Linked);
                if (Safe==true) {
                    break;
                }
            }
            Connection.Close();
            if (Safe is false)
            {
                Connection.Open();
                var Reader2 = new SqlCommand(string.Format("select Link from Unsafe "), Connection).ExecuteReader();
                while (Reader2.Read())
                {
                    string i = Reader2.GetString(0);
                    Safe = CreateRegularExpression(i,Linked);
                    if (Safe == true)
                    {
                        break;
                    }
                }
                Connection.Close();
                if (Safe is true)
                {
                    result.InnerText = "Strona jest niebezpieczna.";
                }
                else 
                {
                    result.InnerText = "Strona nie została jeszcze sprawdzona. Zgłoś ją!";
                }
            }
            else 
            {
                result.InnerText = "Strona jest bezpieczna.";
            }
        }
        public void LoginButton(object sender, EventArgs e) {
            MenuTop.Visible = false;
            zaloguj_sie.Visible = true;
            zaloguj_button.Visible = false;
        }

        public void LoginButton2(object sender, EventArgs e)
        {
            int log = 0;
            Connection.Open();
            var Reader = new SqlCommand(string.Format("select count(*) from Users where Username='{0}' and Password='{1}'",username.Text,password.Text), Connection).ExecuteReader();
            if (Reader.Read()) {
                log = Reader.GetInt32(0);
            }
            Connection.Close();
            if (log == 1) {
                generatePasswordDiv.Visible = true;
                generatePasswordPageButton.Visible = true;
                checkPageAdressDiv.Visible = true;
                checkPageAdressButton.Visible = true;
                plansForFutureDiv.Visible = true;
                plansForFutureButton.Visible = true;
                notifyAdressDiv.Visible = true;
                notifyAdressPageButton.Visible = true;
                result.Visible = false;
                checkAdressTextBox.Visible = false;
                checkAdressButton.Visible = false;
                returnToMainPageButton.Visible = false;
                result.InnerText = " ";
                pomocniczy.Visible = true;
                zaloguj_sie.Visible = false;
                container_top.Visible = true;
                zaloguj_sie.Visible = false;
                zaloguj_button.Visible = true;
                MenuTop.Visible = true;
                Connection.Open();
                var Reader2 = new SqlCommand(string.Format("select Points from Users where Username='{0}' and Password='{1}'", username.Text, password.Text), Connection).ExecuteReader();
                if (Reader2.Read())
                {
                    log = Reader2.GetInt32(0);
                }
                Connection.Close();
                login_user.Text = username.Text;
                points_user.Text = log.ToString();

                uzytkownik.Visible = true;
                zaloguj_button.Enabled = false;
                pokaz_liste.Visible = true;
            }
            else{ 
                MenuTop.Visible = false;
                zaloguj_sie.Visible = true;
                zaloguj_button.Visible = false;
            }
        }
        public void downloadLink(object sender, EventArgs e)
        {
            Connection.Open();
            var Reader = new SqlCommand(string.Format("select Top 1 Link from ToCheck where Checked=0 "), Connection).ExecuteReader();
            if (Reader.Read())
            {
                LinkToCheck.InnerText = Reader.GetString(0);
            }

            Connection.Close();
        }
        public void isSafe(object sender, EventArgs e)
        {
            Connection.Open();
            new SqlCommand(string.Format("Update ToCheck set Checked=1 where Link='{0}' ", LinkToCheck.InnerText ), Connection).ExecuteNonQuery();
            Connection.Close();
            Connection.Open();
            new SqlCommand(string.Format("Insert into Safe values('{0}') ", LinkToCheck.InnerText), Connection).ExecuteNonQuery();
            Connection.Close();
            LinkToCheck.InnerText = "Społeczeństwo dziękuje za wsparcie słusznej sprawy";
            Connection.Open();
            new SqlCommand(string.Format("Update Users set Points=Points+1 where Username='{0}' ", login_user.Text), Connection).ExecuteNonQuery();
            Connection.Close();
        }
        public void isntSafe(object sender, EventArgs e)
        {
            Connection.Open();
            new SqlCommand(string.Format("Update ToCheck set Checked=1 where Link='{0}' ", LinkToCheck.InnerText), Connection).ExecuteNonQuery();
            Connection.Close();
            Connection.Open();
            new SqlCommand(string.Format("Insert into Unsafe values('{0}') ", LinkToCheck.InnerText), Connection).ExecuteNonQuery();
            Connection.Close();
            LinkToCheck.InnerText = "Społeczeństwo dziękuje za wsparcie słusznej sprawy";
            Connection.Open();
            new SqlCommand(string.Format("Update Users set Points=Points+1 where Username='{0}' ", login_user.Text), Connection).ExecuteNonQuery();
            Connection.Close();
        }
        protected void pokaz_liste_Click(object sender, EventArgs e)
        {
            weryfikacja.Visible = true;
            UserLogin.Visible = false;
            pomocniczy.Visible = false;
            MenuTop.Visible = false;
        }
    }
}