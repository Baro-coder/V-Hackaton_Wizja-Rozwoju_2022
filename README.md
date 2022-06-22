# V-Hackaton_Wizja-Rozwoju_2022

# Wydarzenie[^event]
## Forum Wizja Rozwoju 2022

**Temat:** *Bezpieczeństwo w sieci*

**Termin:** 20-21.06.2022 r.

**Miejsce:** Akademia Marynarki Wojennej, Gdynia


# Zespół[^team]
### *The Flowers*
- [Piotr TARGOWSKI](https://github.com/targos123)
- [Bartłomiej SZYKUŁA](https://github.com/Baro-coder)
- [Filip SZPRĘGIEL](https://github.com/PhilipMichvong)
- [Jakub WALCZAK](https://github.com/Walu064)

___

# Projekt
<img align="left" width="250" height="250" src="https://user-images.githubusercontent.com/74451381/175019180-fdbfa3a7-7920-4b6b-bc98-ff0f93ed411e.png">

## Założenia:[^goals]
Opracowany przez nas projekt powstał w celu przeciwdziałania atakom phishinigowym oraz próbom oszustwa w internecie.
Możliwa wdrożona wersja dedykowana jest dla osób zapracowanych, starszych, tych, którzy nie mają dostatecznej wiedzy
o bezpieczeństwie w internecie, ale zdecydowanie jest to projekt dedykowany osobom, którzy cenią sobie swoją prywatność
i bezpieczeństwo. Chcieliśmy zadbać o to, by nasz projekt większość profilatyki, takiej jak rozpoznawanie stron
potencjalnie niebezpiecznych czy weryfikacja autentyczności danego adresu wykonał za użytkownika, aby ten nie musiał
posiadać specjalistycznej wiedzy informatycznej, by czuć się bezpiecznym w internecie.

___

## Główne funkcjonalności:[^features]
1. Identyfikacja stron potencjalnie niebezpiecznych.
2. Sprawdzanie podejrzanych adresów w oparciu o bazę danych znanych adresów.
3. System weryfikacji nieznanych adresów oparty na punktowaniu użytkowników sprawdzających zgłoszone linki.

## Komponenty:
### Wtyczka[^plugin]
Działa w tle podczas korzystania z przeglądarki skanując wszystkie odwiedzane strony. W przypadku podejrzenia
próby oszustwa, tj. jeśli strona oczekuje lub wymaga od użytkownika podania danych wrażliwych, takich jak hasło,
numer telefonu, numer karty..., wyświetla stosowny komunikat o wykrytej możliwej próbie wyłudzenia danych. Wówczas
użytkownik może zdecydować, czy zechce przy pomocy aplikacji internetowej sprawdzić dany adres, czy to zignorować.
Jeśli użytkownik zdecyduje się sprawdzić dany link, zostanie przekierowany na stronę aplikacji.

<p align="center">
  <img width="260" height="300" src="https://user-images.githubusercontent.com/74451381/175020076-2ca3497b-c064-43b7-8120-449551ec9d22.jpg">
  <img width="470" height="300" src="https://user-images.githubusercontent.com/74451381/175020459-1e4a623c-d66a-4a93-ae9f-3ff707d8d28d.jpg">
</p>

### Aplikacja[^app]
Napisana w technologii **.NET** umożliwia sprawdzenie zadanego przez użytkownika adresu pod względem autentyczności. 
Proces sprawdzania wykorzystuje możliwości wyrażeń regularnych w połączeniu z bazą danych zgłoszonych adresów.
Początkowo adres jest porównywany ze znanymi adresami autentycznymi, jeśli nie może znaleźć dopasowania, 
sprawdza tabelę z adresami fałszywymi i wyświetlastosowny komunikat określający, czy dana strona jest 
bezpieczna czy nie. Jeśli jednak w żadnej z tych tabel nie znajdzie dopasowania, wówczas użytkownik 
może zgłosić daną stronę do weryfikacji, po czym adres wpisywany jest do tabeli adresów niezidentyfikowanych.

Jako użytkownik naszej aplikacji możesz założyć konto osobiste i wspomóc społeczność w weryfikacji zgłoszonych adresów.
Każdy użytkownik ma dostęp do tabeli adresów zgłoszonych i może decydować czy dana strona jest bezpieczna według niego, czy
też nie. Jeżeli większość użytkowników stwierdzi, że dany adres jest autentyczny, wówczas przekazywany jest on do tabeli
adresów autentycznych, a wszyscy użytkownicy, którzy w procesie głosowania wybrali tę opcję otrzymują punkty. Jeśli jednak
wybrali inaczej, wówczas punkty są im zabierane.

<p align="center">
  <img width="400" height="440" src="https://user-images.githubusercontent.com/74451381/175021240-6bdc4915-d64b-41b7-9fbb-24eab4e84cf5.png">
</p>

### Baza danych[^db]
Jest ściśle zintegrowana z aplikacją internetową.

Zawiera 3 tabele adresów: 
- zidentyfikowane autentyczne
- zidentyfikowane fałszywe
- niezidentyfikowane zgłoszone

Wykorzystywana jest również w procedurach obsługi kont użytkowników aplikacji.


## Wizja rozwoju:[^development]
1. **Szersze spektrum** - rozszerzenie działania na filtrowanie podejrzanych wiadomości (e-mail, komunikatory sieciowe...).
2. **Wersja mobilna** - działająca na urządzeniach mobilnych, weryfikująca również połączenia oraz wiadomości typu SMS.
3. **Społeczność** - forum aplikacji, możliwość wymiany zdobywanych punktów na nagrody.

___

# Wyniki[^results]

<p align="center">
  Za przedstawiony przez nas pomysł nasz zespół otrzymał <b>wyróżnienie</b> za uczestnictwo w konkursie.</br></br>
  <img width="300" height="400" src="https://user-images.githubusercontent.com/74451381/175023131-d9e3073e-97c7-489d-8707-207f73dc9bbc.jpg">
</p>

[^event]: Wydarzenie
[^team]: Zespół
[^results]: Wyniki
[^goals]: Założenia
[^features]: Funkcjonalności
[^plugin]: Wtyczka
[^app]: Aplikacja internetowa
[^db]: Baza danych
[^development]: Wizja Rozwoju
