Für DataTransfer eigene Klasse
Book & BookDTO


# Saving Data

## ChangeTracker (context.SaveChanges();)

ChangeTracker behält Kopie des Objects und wird verglichen ==> somit weiß er wenn sich was ändert
saveChanges() macht ein detectChanges() um Änderungen zu erkennen

SnapShot = wenn ein Object im Kontext zugewiesen wird wird ein snapshot erstellt
zum Konfigurieren ==> ChangeTracker.AutoDetectChangesEnabled

## Relations
getrackte Objecte werden geadded/modified/deleted
==> Beziehungen werden aktuell gehalten

Cascade = werden gelöscht
SetNull = werden null gesetzt
Restrict = bleiben unverändert

Bei objekten ohne abhängigkeit default = SetNull

# Transactions
Ein SaveChanges() ist eine Transaktion

wenn etwas nicht funktioniert werden alle änderungen, die bei der Transaction dabei waren zurückgesetzt
Lösung: mehrere SaveChanges()

## Batching
useSqlServer(ConnectionString, options => options.MaxBatchSize(10)); //Standard: 42 lol

Send Multiple Insert/Update/Delete in one request

### Update Records
Records mit with setzen (weil sie init only sind)
Book bookUpdate = book with {TItle = "Prof. CSharp);
booksContext.Update //wirft fehler, da es bereits ein Buch mit diesem Key gibt

Lösung:
.State = EntitiyState.Detached;
Nach dem lesen altes buch vom context detachen ==> neues einfügen

Records vlt nur nehmen, wenn nur gelesen werden soll



# Concurrency Conflicts

Three sets of Values:
* Current values
* Original values
* Database values

Concurrency Tokens:
[ConcurrencyCheck]
.isConcurrentToken();

Eigene Property um concurrency zu checken (z.B. TimeStamp)
Byte[]
[Timestamp]
.ValueGeneratedOnAddOrUpdate().IsConcurrentToken();


Concurrency wird bei einem Update verglichen und wenn der Token nicht passt wird eine Exception gethrowed


##### Scopes
host.services.createscope();


# Transaction
TransactionScope scope = new TransactionScope(TransactionScropeOption.RequiresNew)
Transaktion.Current

scope.complete();

Wenn alle glücklich sind ==> Status Committed


Soap Services ==> Service Transactions

Am besten nicht über ServiceGrenzen hinweg

Statt distributed transactions: SAGA Pattern
Locale Transaktionen und wenn etwas Schief geht ANDU-Funktionalität

modelBuilder.HasDefaultSchema("egalwas") //default: dbo


# Migrations
Datenbank nicht über EnsureCreated erstellen


dotnet new tool-manifest

dotnet tool install dotnet-ef

dotnet ef 
dotnet ef migrations add InitBooks
Fehler1: ==> Manage NuGet Packages mic.efcore.design
Fehler2: ==> Eigene Klasse für Migration

IDesignTimeDBContextFactory

new Class: BookContextFactory.cs

erbt von IDesignTimeDBContextFactory BooksContext
//von webseite im error rauskopiert

command nochmal ausführen --> funktioniert
