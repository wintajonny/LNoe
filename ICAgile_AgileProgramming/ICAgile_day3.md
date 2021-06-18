Day3 (mittwoch)


Guard Clause: Alle Abfragen (für Null check oder so) ganz oben in der Methode

#Code Smell
gegenteil von Clean Code (Warnzeichen, dass im Code was nicht passt)

##https://refactoring.guru/refactoring/smells
Zum Nachschauen was alles unter code smells fällt (mit erklärungen und fixes)

kein private methods testen

YAGNI: You aint gonna need it

#Pair Programming
Mob Programming


#Test Doubles
Acten als doubles für dependencies

Dummy: Implementiert das Interface und macht eingentlich nichts
Stub: Implementiert das Interface und returned einen Wert (z.b. true)
Mock: Leitet Interface ab, hat einen excepted und actual wert und vergleicht die im .Verify()
Spy: records events for later verification
Fake: 


#Dependency Injection

##Constructor Injection

##Setter Injection

##Interface Injection
Vorteil: einfacher ein testDouble zu machen, da man nur die Methoden implementieren muss
IServiceCollection (IOC Container)



#Legacy Code
(Alter Code, schwer lesbarer Code, schwer wartbar, schwierig zu testen)

Arten von Vererbung: REST Services, Datenbankverbindungen, andere Klassen, Testdaten, new() in Methoden, statische Methoden, Vererbung [deren dependencies]




























