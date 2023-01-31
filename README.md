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
Normalt har jeg, i mine BIZ klasser, en ToDTO function, der bare tager en model og returnerer en DTO.  
Jeg tror jeg fik blandet models og DTOer sammen i denne opgave.  
Der skulle være lavet ViewModel til til alle Views og binding på ViewProperties.  
Normalt bruger jeg using omkring DBContext og DB kald, det burde jeg også have gjort her. Using havde sørget for kalde Dispose.  
(se ovenfor)ArrivalDatabase skulle være anderledes designet, men det var et nyt setup og jeg var træt.  


Ellers en sjov opgave, håber det kan bruges.  
 
