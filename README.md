[![Open in Visual Studio Code](https://classroom.github.com/assets/open-in-vscode-f059dc9a6f8d3a56e377f745f24479a46679e63a5d9fe6f495e02850cd0d8118.svg)](https://classroom.github.com/online_ide?assignment_repo_id=6312085&assignment_repo_type=AssignmentRepo)
# Multifabriken

>Du ska skapa en konsolapplikation där man kan välja att beställa nya produkter från fabriken.
>
>[Gå till uppgiften](https://ju.instructure.com/courses/5951/assignments/22265)

## Instruktioner

*Vad behöver göras för att ditt program ska starta och gå och använda?*
**Navigera till rätt mapp och skriv dotnet run i terminalen**

## Självskattning
>**OBS:** Byt ut dina egna uppdateringar från *kurisiv text* till **fetmarkerad**.

*Uppdatera den här listan med vilka krav du uppfyllt och ev. inte blivit klar med eller valt att inte göra, lämna gärna egna kommentarer om lösningen eller*


 |Krav|Uppfyllt|Egna Kommentarer|
 |---|---|---|
|**1**  |**Ja**| *Lösningen ska bestå av en konsolapplikation skriven i C# som är körbar med .NET Core* - **Kravet uppfyllt**|
|**2**  |**Ja**| *När man startar programmet ska man mötas av en meny samt en kort introduktion till programmet* - **Funktionaliteten för detta skapas i klassen Menu under metoden PrintMenu**|
|**3**  |**Ja**| *Man ska kunna göra ett val i menyn med vilken typ av produkt man vill beställa, om man vill lista alla  - produkter man beställt, eller om man vill avsluta programmet* - **Funktionaliteten för detta skapas i klassen Menu under metoden RunMenu, den innehåller en switch som tar en in i olika metoder beroende på användarens knappval**|
|**4**  |**Ja**| *Produkterna man kan välja mellan är bilar, godis, snören samt tofu* - **Varje produkt har en egen klass**|
|**5**  |**Ja**| *När man väljer att skapa ett snöre så ombes man att mata in "färg" samt "längd"* - **Snöre har en egen klass - Lace. Funktionaliteten och skapandet av ett nytt objekt/snöre sker i metoden AddNewLace under klassen Menu**|
|**6**  |**Ja**| *När man väljer att skapa en bil ska man ombes att mata in ett "registreringsnummer", en "färg", och sedan ett  - "bilmärke"* - **Bil har en egen klass - Car. Funktionaliteten och skapandet av ett nytt objekt(bil) sker i metoden AddNewCar under klassen Menu**|
|**7**  |**Ja**| *När man väljer att skapa en godis ombes man att mata in "smak" följt av "antal"* - **Godis har en egen klass - Candy. Funktionaliteten och skapandet av ett nytt objekt(godis) sker i metoden AddNewCandy under klassen Menu**|
|**8**  |**Ja**| *När man väljer att skapa tofu ombes man att mata in "volym" i liter samt en "kryddning"*  - **Tofu har en egen klass - Tofu. Funktionaliteten och skapandet av ett nytt objekt(tofu)) sker i metoden AddNewTofu under klassen Menu**|
|**9**  |**Ja**| *Om man väljer att lista alla produkter ska alla produkter man beställt hittills skrivas ut med den  - informationen man angett* - **Funktionaliteten för detta skapas i klassen Menu under metoden GetOrderList. GetOrderList kallas på i funktionen RunMenu genom knapptryck 5**|
|**10** |**Ja**| *Om man väljer att avsluta programmet ska programmet helt enkelt sluta köras* - **Funktionaliteten för detta finns i klassen Menu under metoden RunMenu genom knapptryck 0**|
|**11** |**Ja**| *Lösningen ska bestå av en "Program.cs" fil, en ".csproj" fil samt en fil för varje extra klass du skapar* - **Kravet uppfyllt**|
|**12** |**Ja**| *Lösningen ska förutom kod innehålla en fil med namnet "reflections" i formatet md, txt eller pdf* - **Kravet uppfyllt, Reflections.pdf**|
|**13** |**Ja**| *reflections-filen ska en ska innehålla en kort beskrivning av kodens funktioner och struktur* - **Beskrivningen finns i Reflections.pdf under "kodbeskrivning"**|
|**14** |**Ja**| *Filen reflections ska också innehålla en egen analys och reflektion över hur du strukturerat din kod genom användandet av metoder och klasser.* - **Analysen finns i Reflections.pdf under "Egen analys och reflektion"**|