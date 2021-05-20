#Async Programming

##
AsyncCallback ist ein Delegate
Async Pattern not supported with delegates: Bei .net Framework:
'op1. BeginInvoke(11,12,new AsyncCallback(ar => {
  op1.EndInvoke(ar);
}),null);'


# Event-based Async Pattern
DownloadStringAsync ---> DownloadStringCompleted Event

vorher Methode hinzufügen und danach Async starten


## Task-based Async Pattern
static Task<string> GreetAsync(){
	returnTask<string>.run(() =>
		string result = Greet(name,ms);
		return result;
	}
	}
	


	Main{
		Runner();
	}
	
	private static async void RUnner(){
		//Task<string>t = GreetAsync("",3000);
		string result = await GreetAsync("",3000);
	
Ohne ReadLine ended programm

Async Methoden sollten unbedingt einen Task zurückliefern!!!
Warten bis alle tasks fertig sind:
		await Task.WhenAll(t1,t2);

	Bei mehreren Fehlern:
		Task resultTask = Task.WhenAll(t1,t2); //Task.WaitAll blockiert!!!
		await resultTask;
	
resulttask.exceptions ==> liefert alle exception von den Tasks
	
	
	## Guidelines
	
	- Wenn möglich async postfix verwenden
	- Wenn möglich nicht void zurückgeben (wenn notwendig catch)
	- Deadlocks vermeiden --> whenall und waitall nicht verwenden
	
 await Task.Delay(1000);
	
this.dispatcher schaltet zum Thread vom this
	
	
	AsyncStream mit IAsyncEnumerable
	
	
	
	
	
	
