<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="projekt.WebForm1" %>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>FLOWERS SECURITY</title>
    <style>     

    .gray_effect {
        text-align: center;
        text-transform: uppercase;
        font-family: sans-serif;
        font-size: 5em;
        color: black;
    }

    .gray_effect span {
        opacity: 0;
        animation: loading 3s linear infinite alternate;
    }

    @keyframes loading {
        to {
            opacity: 1;
        }
    }

    .gray_effect span:nth-child(2) {
        animation-delay: 0.25s;
    }

    .gray_effect span:nth-child(3) {
        animation-delay: 0.5s;
    }

    .gray_effect span:nth-child(4) {
        animation-delay: 0.75s;
    }

    .gray_effect span:nth-child(5) {
        animation-delay: 1s;
    }

    .gray_effect span:nth-child(6) {
        animation-delay: 1.25s;
    }
    #top
    {
        width:100%;
        height:20vh;
    }
    @import url("https://fonts.googleapis.com/css2?family=Noto+Sans+JP:wght@100&display=swap");

    * {
      box-sizing: border-box;
      color: white;
      font-family: "Noto Sans JP", sans-serif;
      letter-spacing: 2px;
    }

    body {
      background-color: black;
      display: flex;
      flex-flow: column wrap;
      justify-content: center;
      align-items: center;
    }

    .win-grid {
      border: 1px solid white;
      letter-spacing: 2px;
      color: white;
      display: grid;
      grid-template-columns: repeat(2, 1fr);
      align-items: stretch;
      text-align: center;
      grid-gap: 1rem;
      padding: 5rem;
    }

    .win-btn {
      padding: 2rem;
      text-align: center;
      border: none;
      border-radius: 0px;
      background: black;
      color: white;
      border: 1px solid transparent;
      z-index: 4;
   
    }

    button:focus {
      outline: none;
    }


    .guzik{
        width:250px;
        height:100px;
        background-color:black;
        color:white;
        font-size:110%;
        transition: background-color 0.4s 
       ease-out 10ms
    }

    .guzik:hover
    {
        background-color:#242526;
    }
    #home_page
    {
        text-align:center;
    }
    .textboxik
    {
        text-align:center;
        color:black;
        font-size:200%;
    }
    #wynik{
        text-align:center;
        font-size:200%;
    }
    #zaloguj_sie {
        padding-left:40%;
    }
    #ppassword {
        padding-left:20%;
    }
    #plogin{
        padding-left:20%;
    }
    #weryfikacja{
        padding-left:27%;
    }
    #zaloguj_sie
    {
        margin-left:40%;
    }
</style>

</head>
<body>
    <form id="projekt" runat="server">
        <div id="container_top" runat="server">
            <div id="top" runat="server">         
                <h1 class="gray_effect">             
                    <span>F</span>                         
                    <span>L</span>             
                    <span>O</span>           
                    <span>W</span>           
                    <span>E</span>           
                    <span>R</span>            
                    <span>S</span>            
                    <br />            
                    <span>S</span>            
                    <span>E</span>            
                    <span>C</span>           
                    <span>U</span>            
                    <span>R</span>            
                    <span>I</span>            
                    <span>T</span>            
                    <span>Y</span>        
                </h1>        
            </div>
            <p id="UserLogin" runat="server"></p>
            <div class="win-grid" id="MenuTop" runat="server">    
                <div class="win-btn" id="generatePasswordDiv" runat="server">
                    <asp:Button ID="generatePasswordPageButton" runat="server" Text="Generuj hasło" OnClick="SetPasswordGeneratorVisible" CssClass="guzik"/>
                </div>    
                <div class="win-btn" id="checkPageAdressDiv" runat="server" >
                    <asp:Button ID="checkPageAdressButton" runat="server" Text="Sprawdź adres strony" OnClick="SetCheckAdressPageVisible" CssClass="guzik"/>
                </div>    
                <div class="win-btn" id="plansForFutureDiv" runat="server" >
                    <asp:Button ID="plansForFutureButton" runat="server" Text="Plany na przyszłość" OnClick="SetPlansForFutureVisible" CssClass="guzik"/>
                </div>    
                <div class="win-btn" id="notifyAdressDiv" runat="server">
                    <asp:Button ID="notifyAdressPageButton" runat="server" Text="Zgłoś podejrzaną stronę" OnClick="SetNotificationPageVisible" CssClass="guzik"/>
                </div>
              
                <asp:TextBox ID="checkAdressTextBox" runat="server" CssClass="textboxik"></asp:TextBox>              
                <asp:Button ID="checkAdressButton" runat="server" Text="Sprawdź stronę" CssClass="guzik" OnClick="CheckAdress"/>

                <asp:TextBox ID="notifyAdressTextBox" runat="server" CssClass="textboxik" Text=" "></asp:TextBox>              
                <asp:Button ID="notifyAdressButton" runat="server" Text="Zgłoś stronę" CssClass="guzik" OnClick="Notification"/>  
                
                <asp:TextBox ID="generatePasswordTextBox" runat="server" CssClass="textboxik"></asp:TextBox>              
                <asp:Button ID="generatePasswordButton" runat="server" Text="Generuj haslo" CssClass="guzik" OnClick="PasswordGenerator"/>
                <p id="result" runat="server"></p>
            </div>
        </div> 
        <div style="clear:both"></div>
        <div id="home_page">
            
            <div id="pomocniczy" runat="server" visible="False">
                <p style="text-align:center">Panel logowania</p>
                    <asp:Label ID="Label1" runat="server" Text="Aktualnie zalogowany:"></asp:Label>
                        <asp:Label ID="login_user" runat="server" Text=""></asp:Label>
                        <br/>
                        <asp:Label ID="Label2" runat="server" Text="Ilosc posiadanych punktow:"></asp:Label>
                        <asp:Label ID="points_user" runat="server" Text=""></asp:Label>
                        <br />
                <div class="win-grid" runat="server">
                    
                    <asp:Button ID="zaloguj_button" runat="server" Text="zaloguj"  CssClass="guzik" EnableViewState="False" OnClick="LoginButton"  />

                    <div id="uzytkownik" runat="server" visible="False">
                        
                        
                        <asp:Button ID="pokaz_liste" runat="server" Text="Weryfikuj zgłoszenia"  CssClass="guzik" EnableViewState="False"  visable="False" OnClick="pokaz_liste_Click" />  
                    </div>

                    <div id="zaloguj_sie" runat="server" visible="False">
                        <div id="plogin" runat="server" style="color:black">
                            <p>Login</p><asp:TextBox ID="username" runat="server" OnTextChange="pobierz" style="color:black"></asp:TextBox><br/>
                        </div>
                        <div id="ppassword" runat="server" style="color:black">
                            <p >Hasło</p><asp:TextBox ID="password" runat="server" OnTextChange="pobierz" style="color:black"></asp:TextBox><br/>
                        </div>
                        <asp:Button ID="LogItIn" runat="server" Text="loguj"  CssClass="guzik" EnableViewState="False" OnClick="LoginButton2"  />  
          
                    </div>

                </div>
            </div>

            <div id="weryfikacja" runat="server" visible="False" class="win-grid">
                
               <asp:Button ID="pobranie" runat="server" Text="Pobierz adres"  CssClass="guzik" EnableViewState="False" OnClick="downloadLink"/>  
                <br />
                <p id="LinkToCheck" runat="server">...</p>
                 <br />
                <asp:Button ID="bezpieczny" runat="server" Text="Jest bezpieczne"  CssClass="guzik" EnableViewState="False" OnClick="isSafe"/>  
                 <br />
                <asp:Button ID="niebezpieczny" runat="server" Text="Nie jest bezpieczne"  CssClass="guzik" EnableViewState="False" OnClick="isntSafe"/>  

            </div>
            <div class="win-btn" id="Div1" runat="server">
                <asp:Button ID="returnToMainPageButton" runat="server" Text="Wróć na stronę główną"  CssClass="guzik" EnableViewState="False" OnClick="ReturnToMainPage" />
            </div>
        </div>
    </form>
</body>
</html>