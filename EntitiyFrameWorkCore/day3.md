

# Azure Cosmos DB

CoreSQL API beim Erstellen der Ressource












# More Features

## Context Pools

AddDbContextPool/BooksContext\(c => c.UseSqlServer(connectionString, poolSize:16));

## ContextFactory
Mit der Factory muss man den context selbst disposen
inject IDbContextFactory
Create context instances via CreateDbContext

## Many to many relationships

HasMany/WithMany
.UsingEntity    //zusatzdaten 
            (ba => ba.HasData(data.getBooksAuthors())     //getBooksAuthors gibt ein object [] 

## Split Queries
.AsSplitQuery()

## Event Counters

dotnet counters list
    //shows metric data
    
dotnet counters ps
dotnet counters monitor --process-id 11528


## Unit Testing
.UseInMemoryDatabase();

Better: use an interface for the DbContext

.SaveChanges: im interface implementieren (gibt int zurück)
.Database: DatabaseFacade Database{get;}

Beim testen Datenbank mocken!!


NOSQL einfacher daten replizieren (gleichzeitig schreiben) -> aufpassen welche daten


# N-Tier Applications

dotnet ef dbcontext scaffold
                              -- help
                              

SqlServer NuGet Package

HTTPClient
Dispose sagt nicht wann freigegeben werden soll


services.AddHttpClient/\Runner/\()client => client.BaseAddress = new Uri

response.EnsureSuccessStatusCode(); //weil mehrere statuscodes success liefern können
string json = resp.Content.ReadAsStringAsync();


PropertyNameCaseInsensitive = true bei Json SerializerOptions damit die properties geupdated werden

statt ReadAsString ==> ReadAsStreamAsync() //kommt nicht in den large heap


_httpClient.GetFromJsonAsync
//macht ensuresuccessstatuscode automatisch


Multiple Startups für client und api



            









































