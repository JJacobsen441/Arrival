# Arrival  
  
Det blev en lang dag, men synes løsningen er færdig.  
Jeg ville lige tilføje en database, det kom til at trække ud.  
Der er en del boilerplate kode, som skal fjernes, men jeg vil ikke rode mere ved det nu hvor det virker.  
ArrivalDatabase klassen har noget kode jeg fandt på nettet og var oprindeligt skrevet som async, men  
jeg har omskrevet det så det ligger mere til mit niveau.  
Jeg har dog nogenlunde fod på async, Delegates, Func og Action det er bare sjældent jeg selv benytter mig af disse.  

Mangler:  
(Fixed)Der burde selvfølgelig også håndteres at der ikke kan skrives '-' i første eller anden del af cpr.  
Der burde nok have være try/catch i alle events, såsom OnAppearing.  
Normalt har jeg en ToDTO function, der bare tager en model og returnerer en DTO, i mine BIZ klasser.  
Jeg tror jeg fik blandet models og DTOer sammen i denne opgave.  
Der skulle være lavet ViewModel til til alle Views og binding på ViewProperties.  
Jeg skulle selvfølgelig have kaldet Dispose på SQLiteConnection Database, jeg er vant til bare at bruge using, men har glemt det da det er et nyt setup.  
Jeg skulle have håndteret oprettelsen af SQLiteConnection Database anderledes, jeg er lidt usikker på om den skulle  have være static eller ej, måske Singleton.  


Ellers en sjov opgave, håber det kan bruges.  
 
