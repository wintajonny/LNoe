#Reflection

##Annotations
sind Attribute, die der Compiler kennt

[Obsolete] bei veralteten methoden
[Caller information]
[Type Forward]


attribute  tab tab (in neuer Class)
leiten von :Attribute ab
[AttributeUsage] wo kann ich dieses Attribut verwenden

[field: MySample("field attribute")]
um das Attribute dem Field und nicht dem Property mitzugeben

##Information at Runtime
[Serialization]
[JsonIgnore] dieses Property soll nicht serialisiert werden
[XmlIgnore]
[XmlAttribute("Vorname")]
[StringLength(20)]


##Assenbly abfragen
Assembly thisAssembly = Assembly.getExecutingAssembly();


## dynamic reflection
mef = manage extensibility framework



# Managed & Unmanaged Memory

- Stack: wird freigegeben wenn methode zu ende ist
- managed heap: Managed by the Garbage Collector
- native heap: your responsibility

(tool dotnet-counters)

GC.GetGeneration(s1); //cw
GC.Collect();
GC.GetGeneration(s1); //cw


TryStartNoGCRegion / EndNoGCRegion --> stoppt den GC termorär
Sample? s1 = new();
WeakReference wsr1 = new(s1)

wrs1.isAlive()
Sample? s2 = (Sample?) wrs1.Target;

if(s2 != null){
  //is a strong reference again
  //kann verwendet werden
}


deconstructor Syntax

public MyClass(){
  
}

-MyClass(){     //Finalize methode von object wird überschrieben

}

GuideLine: wenn man einen Finalizer erstellt unbedingt IDisposable implementieren

r1.Dispose(); //mit try finally combinieren!

GC.addMemoryPressure(1000000); //damit GC denkt, dass so viel Memory allociert wurde

protected virutal void Dispose(bool isDisposing){
  
}

IDisposable: implement interface with dispose pattern

//using statement
using(MyResource r2 = new()){
  r2.Foo();
}

//using declaration
isong MyResource r3 = new();
r3.Foo();     //wenn variable out of scrope geht (z.B. wenn Methode zu ende ist) wird das Dispose ausgeführt







