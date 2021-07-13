
# EF Core

Create a Model
Create a DbContext
Specify a Provider

1. Provider Variante
Default constructor und onConfiguring
 
2. Provider Variante


## Annotations
String default: nvarchar(max)
[property: StringLength(50)]  -> nvarchar(50)

## Fluent Api
//mehr möglicherkeiten als mit Annotations

override OnModelCreating(){
  modelBuilder.Entity/\Book/\().Property(b => b.publisher).HasMaxLength(30)
}


## Model Binding




# HttpClient
nur asynchrone Methoden mit dem async pattern
GET, POST, PUT, DELETE

>immer disposen!!!

HTTPClient ist designed für reused (nicht in mehtode instanzieren sondern injecten!!!

Problem bei langen json strings, weil sie in den large object heap kommen (GC verschiebt sie nicht)

> Besser Streams verwenden

___
Umbauen von der Applikation
var stream = await response.Content.ReadAsStreamAsync
var books = JsonSerializer.desearilizeAsync/\IEnumerable/\Book/\/\(stream, options)


Problem bei Socket TimeOut
## HttpClientFactory

NuGet Package: Microsoft.Extensions.Http

.ConfigureServices
  services.addHttpClient("my client", client => (
    client.BaseAdress = new Uri("https://localhost:5001"
  ));

beim Client dann nur noch "/api/books"

statt AddTransient Runner
addHttpClient Runner (client injected)

Im Runner 
ctor HttpClient injecten

Managen vom HTTPClient ist aufwendig und wird erspart durch die HttpClientFactory

## Retries
Using Polly and HttpClientFactory

NuGet Microsoft.Extensions.Http.Polly

Nach addHttoClient

.AddTransientHttpErrorPolicy(config => {
  config.OnTransientHttpErrorPolicy(...)
})


# Encryption

## Symmetric encryption
Same Key for encryption and decryption

## Asymmetric encryption
Public und Private Key

### SSL - Symmetric
1. Client requested secure session
2. server schickt certificate
3. client verifiziert certificate
4. client send a symmetric encryption key

Identity ist ein User, eine Gruppe, Organisation

Credentials: username, password, email

### Authentication: 
wer ist der User
- get the users identiy

### Authorization: 
was darf er tun
- welche rolle hat der user

### Claim
Ein Token hat einen oder mehrere Claims

OAuth 2.0 oder OpenId Connect 1.0

OpenId Account kann verwendet werden zum einloggen (Facebook, Github, Microsoft, ...)


# Microsoft Graph
graph explorer - google


# Azure Funtions
werden getriggered (z.B. httpRequest, timer, cronjob)
laufen serverless
werden nach 5 minuten gekillt (kann auf 10 minuten verlängert werden

NuGet Pkg: Microsoft.Azure.Functions.Extensions

[assembly: Microsoft.Azure.Functions.Extensions.DependencyInjection.FunctionsStartUp(typeof(StartUp)]

StartUp Klasse leitet von FuntionsStartUp ab und implementiert Configure

---
Vorteil von Azure Functions: man zahlt nur wenn was läuft (consumption-based)





























