using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Graph;
using Microsoft.Graph.Auth;
using Microsoft.Identity.Client;
using System;
using System.Linq;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration(config =>
    {
        config.AddUserSecrets("4955ae93-ee4c-42b8-9d20-d56b8aa370ae");
    }).ConfigureServices(services =>
    {

    }).Build();
var config = host.Services.GetRequiredService<IConfiguration>();
string clientId = config["client-id"];
string tenantId = config["tenant-id"];

var app = PublicClientApplicationBuilder
    .Create(clientId)
    .WithAuthority(AzureCloudInstance.AzurePublic, tenantId)
    .WithRedirectUri("http://localhost")
    .Build();

string[] scopes = { "user.read" };
AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();

Console.WriteLine($"token: \t{result.AccessToken}");

//var provider = new InteractiveAuthenticationProvider(app, scopes);
//var client = new GraphServiceClient(provider);

//User me = await client.Me.Request().GetAsync();

//Console.WriteLine($"display name:\t{me.DisplayName}");
