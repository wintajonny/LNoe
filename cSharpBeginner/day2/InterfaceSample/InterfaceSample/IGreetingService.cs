namespace InterfaceSample
{
    public interface IGreetingService
    {
        string Greet(string name);

        string Greet(string title, string name)
        {
            return Greet($"{title} {name}");
        }
    }
}