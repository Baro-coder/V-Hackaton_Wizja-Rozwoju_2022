# Wtyczka

## Opis działania
    Wtyczka działając w tle analizuje wszystkie strony internetowe 
    ('http*//*/*') i skanuje ich kod w celu zidentyfikacji podejrzanych
    stron (stron logowania, płatności ...).
    
    Po pozytywnym zidentyfikowaniu strony wyświetla monit ostrzegawczy
    o podejrzeniu wystąpienia ataku phishingowego. Wówczas użytkownik
    może sprawdzić autentyczność linku w ramach stworzonej aplikacji webowej lub zignorować ostrzeżenie.

    Strona zidentyfikowana przez wtyczkę po raz pierwszy zapisywana jest
    do pamięci przeglądarki i nie będzie już powodować wyświetlenia monitu.

    Do aplikacji webowej można uzyskać dostęp również poprzez panel
    informacyjny wtyczki oraz skorzystać z dostępnych w ramach aplikacji
    funkcjonalności.

## Funkcjonalności
    - Identyfikacja stron logowania, płatności
    - Monity ostrzegawcze
    - Przekazywanie danych do aplikacji webowej
