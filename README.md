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

# Wyniki[^results]
Za przedstawiony przez nas pomysł nasz zespół otrzymał **wyróżnienie** za uczestnictwo w konkursie.


# Projekt
## Założenia:[^goals]
Opracowany przez nas projekt powstał w celu przeciwdziałania atakom phishinigowym oraz próbom oszustwa w internecie.
Możliwa wdrożona wersja dedykowana jest dla osób zapracowanych, starszych, tych, którzy nie mają dostatecznej wiedzy
o bezpieczeństwie w internecie, ale zdecydowanie jest to projekt dedykowany osobom, którzy cenią sobie swoją prywatność
i bezpieczeństwo. Chcieliśmy zadbać o to, by nasz projekt większość profilatyki, takiej jak rozpoznawanie stron
potencjalnie niebezpiecznych czy weryfikacja autentyczności danego adresu wykonał za użytkownika, aby ten nie musiał
posiadać specjalistycznej wiedzy informatycznej, by czuć się bezpiecznym w internecie.

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

[^event]: Wydarzenie
[^team]: Zespół
[^results]: Wyniki
[^goals]: Założenia
[^features]: Funkcjonalności
[^plugin]: Wtyczka
[^app]: Aplikacja internetowa
[^db]: Baza danych
[^development]: Wizja Rozwoju