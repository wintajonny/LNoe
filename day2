#day2

#Azure Pipelines
-> automatishe Builds
-> Test automation
-> Deployment automation

Agents:
Microsoft Hosted Agents:
Self hosted Agents:


Jobs:
Agent pool jobs: laufen auf einem Agent im Agent Pool
Container job: läuft auf einem Container in einem agent im agent pool
Deployment group jobs: Macht ein Deployment auf einer gruppe von systemen
Agentless jobs (Server jobs): brauchen keinen agent, laufen in der pipeline

Pool A kann eine oder mehtere Agents von einer oder mehreren Maschinen umfassen


Pipelines und concurrency:

yaml pipeline: (einrückungen)

name: 
trigger: (wenn trigger leer ist wird sie immer ausgeführt wenn sich im repo was ändert, mei master nur beim master)
 - master
variables:
pool: 
job:
  steps:
checkout: 



#Security
Microsoft Threat Modeling Tool

Configuration nicht in dateien speichern
Azure Key Vault zum stoen von secrets und keys / monitoring / administration


#Application Configuration

Azure App configuration service zur zentralen configuration
mit Key-Value Pairs


#Continous Integration mit Github Actions

Github Actions sind equaivalent zu Pipelines in DevOps

Events triggern -> Worklows contains -> Jobs benutzen -> Actions 

Events:
on: 
  schedule: 
    -cron
    
on: push



Environment Variables:

env: 
  Project-Server:...
  
Artifacts weitergeben: 

uses: actions/upload-artifacts




































