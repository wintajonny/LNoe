Git Menü im Visual Studio:


#Dependency Management

- Standartisierung
- Package formate (wo kommen sie her)
- Versionierung

Man kann schauen ob man Teile von Code getrennt deployen kann.
-> wenn man sie wo anders verwenden kann, kann man Packages machen

SourceCode nach dependencies scannen:
- duplicated code
- high cohesion and low coupling (Enge Kopplung gemeinsam in einer Komponente)
- individual lifecycle
- stable parts (welche sich nicht ändern)
- Unabhängigen Code und Komponenten die es schon gibt

Versionierung von Packages major.minor.patch == 2.1.16


#Continous Delivery

Prozesse müssen wiederholbar sein
Alles muss im Source Control sein
Alles automatisieren


Release Gate



# Continous Deployment

Service Connection Resource

Custom Build/Release tasks

Staging Environments

#Deployment Patterns:
Micro services sollen unabhängig released, deployed und versionisiert werden
Dev -> Test -> Staging -> Production      //standard deployment pattern

Load Balancer:
Teilt zwischen verschiedenen Slots auf

Feature Toggles:


Canary releases:
Feature nur für einen Teil von user

Dark Launching:
User wissen nicht von der neuen Version

A/B Testing:
Eine User Gruppe bekommt version a die andere version b -> vergleich 




Azure Automation 
















































