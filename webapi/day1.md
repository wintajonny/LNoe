# day1 
//previous notes --> check notes

# REST Results and Status Codes
GET -> Resource im Body
Post -> Resource die hinzugefügt wird im Request Body und die Resource im Response Body
PUT ->


2xx => erfolgreich            //nicht nur auf 200 testen sondern ob es erfolgreich ist
4xx => Client Fehler          //Fehler im Client (falscher Request, not authenticated, not found
5xx => Serverseitiger Fehler  //Fehler am Server


[ApiController] definiert sinnvolle default für den Controller


## JSON
In Runner class
response.EnsureSuccessStatusCode        //generiert exception, wenn es kein successStatusCode ist
response.content.ReadAsStringAsync()

JsonSerializerOptions options = new(){
  PropertyNameCaseInsensitive = true;
};
System.Text.Json.JsonSerializer.Deserialize/\IEnumerable/\Book/\/\(jsonString, options);

## XML
services.AddController( options => options.RespectBrowserAcceptHeader = true).AddXmlSerializer...

## MetaData

Dokumentation:
/// <summary>
/// ...
/// </summary>          


# Entity Framework Core

BooksContext.cs : DbContext

NuGet SqlServer installieren

Constructor mit (DBContextOptions options) : base (options)
DBSet/\Books/\ Book => Set/\Book/\();

Bei ConfigureServices hinzufügen: AddDbContext/\BooksContext/\(options => options.useSqlServer(stringToDb))};

Add Api Controller with actions, using Entity Framework


















