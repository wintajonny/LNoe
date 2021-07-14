# Azure Events

## Event Hub
besser zu verwenden als ein **Event Grid**
ist komplexer als ein Event Grid
Event wird 1 Stunde gespeichert -> für kürzer lebige dinge

# SignalR
uses websockets if possible
real time communication

SignalR Hub verbindet sich mit Clients

____
New Project: ASP.NET Core empty


Hubs Folder Hubs: ChatHub.cs : Hub
override OnConnectedAsync und OnDisconnectedAsync
public async Task SendMessageToAll(string name, string message){
  base.Clients.All.SendAsync("Broadcast", name, message);
}

endpoints.MapHub<>ChatHub<>("/chat");

## Streaming mit SignalR
```
public IAsyncEnumerable<>SomeData<> RequestStream(int iterations);
{
  for(i < iterations){
    yield return new SomeData()
    await Task.Delay(100)
  }
}
```

```
var hubConnection = new HubConnectionBuilder()
await hubConnection.StartAsync();
hubConnection.StreamAsync<>SomeData<>();
```

IAsyncEnumerable mit Streams sind gut für große Datenbankzugriffe


new CancellationTokenSource(1200)

foreach (var item in stream.WithCancellation(cts.Token)){}


#GRPC

## Workers
dotnet new worker -o WorkerSample

NuGet Pkg: Microsoft.Extensions.Hosting.WindowsServices
.UseWindowsService(); bei createHostBuilder

im cmd: sc create etcsampleservice binPath=c:/myservices/MyWindowsService.exe

## gRPC - g remote procedure calls
(Windows Bond)

Binäre Kommunikation zwischen Services

Protobuf

create -> Asp.net core grpc service
.csproy: Protobuf 
___
Console Application -> GRPCClient

Manage Connected Service: 
- Proto file: browse zum server  
- Client Code

var channel = GrpcChannel.ForAddress("https://localhost:5001");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(new HelloRequest(){Name = "Kathi"});
cw(reply.message);















































