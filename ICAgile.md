#Nagarro - Advanced Programming Techniques for Agile Teams in CSharp

##Continous Integration

Integration - Delivery - Deployment

###Centralized / Distributed Systems

Distributed (Git, mercurical) 
-> alles ist lokal 
-> Commits sind lokal (History wird verändert aber im Server ist nichts)

Centralized (SVN, Tfs)
-> alles läuft auf einem server
-> commits sind direkt auf dem server


### Github Actions
.gituhub/workflows/main.yml:

    name: CI Pipeline

    on: [push]

    defaults: 
      run:
        working-directory: ./CSharpCore


    jobs:
      build:

        runs-on: ubuntu-latest

        steps:
          -name: Ckeckout source code
           uses: actions/checkout@v2
          -name: Setup dot net build environment
           uses: actions/setup-dotnet@v1
           with:
            dotnet-version: 3.1.x

          -name: Install dependencies
           run: dotnet restore

          -name: Build solution
           run: dotnet build

          -name: Run unit tests
           run:dotnet test --logger "trx;logfilename=${GITHUB_WORKSPACE}/result.trx"

          -name: Publish test results
           uses: dorny/test-reporter@v1.4.3
           with:
            name:publish results

            path: "result.trx"
            reporter:dotnet-trx
            fail-on-error: false

        

##Collective Responsibility




##Testing

Mehr unit tests, moderate integration tests und wenige ui tests

###Unit tests:
kleinste testbare einheit einer application

Arrange -> Act -> Assert          // -> Teardown (nicht wirklich notwendig)

Fluent Assertions() 
-  .Should().StartWith("x");
-  .Should().NotBeNullOrEmpty();


The Guilded Rose -> Application ohne tests

Pair testing mit stefan zapf


https://marketplace.visualstudio.com/items?itemName=FortuneNgwenya.FineCodeCoverage















