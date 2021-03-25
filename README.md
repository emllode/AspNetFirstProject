
Asp .NET är ett ramverk för att underlätta att skapa webbapplikationer, detta görs genom två sätt, Razor pages samt MVC.

* Startup.cs går genom trappan av steg som krävs för att en sida skall kunna skicka tillbaka 200 OK, detta är ett visst antal steg som man själv har kontroll att styra över, så som ifall användaren har tillåtelse att få tillgång till sidan, krävs det någon slags inlogg, hur data skall hanteras m.m.
  
* Wwwroot hanterar alla dina statiska filer så som CSS, JS, bilder som används genom ditt projekt i asp net.

* Razor-språket erbjuder en möjlighet att slå ihop en HTML sida med C#-kod, där man kan genom @-tag få in möjlighet att använda ”server kod” som t.ex: if/else m.m. 

-- 

RazorPages erbjuder möjligheten att implantera c# kod i en HTML-sida där varje Content page (HTML) får en motsvarande Page Model (C#). Detta möjliggör väldigt enkelt att skriva in den kod man vill ha på sin sida i Page Model, t.ex underlättar detta GET/POST calls, skapa kommunikation med en databas. Man kan se det som att Page Model håller koll på att som skall ske i bakgrunden (server-sidan) och Content Page sköter allt det visuella.

--

MVC står för Model View Controller.
* Model = som sköter all datahantering som den kan få från en databas.
* View = Det visuella som användaren kan se och även ha möjlighet att förändra. (HTML, CSS, JS)
* Controller = Hanterar användares request, De går till så att användaren är i View som skickar en request som controllern då hanterar och ger tillbaka en respons.
 
