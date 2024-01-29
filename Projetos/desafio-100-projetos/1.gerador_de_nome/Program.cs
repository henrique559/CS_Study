namespace Main
{
    class Program
    {

        static void Main(string[] args)
        {
            NameGenerator Generator = new NameGenerator();
        
            Console.WriteLine("Insert here your name:");
            Generator.GetName = Console.ReadLine();
  
            Console.WriteLine("Insert here your city:");
            Generator.GetCity = Console.ReadLine();

            Console.WriteLine("Choose your main RPG class: ");
            Generator.GetRPGClass = Console.ReadLine();


            Console.WriteLine($"You are a {Generator.GetRPGClass} from {Generator.GetCity} called {Generator.GetName}");
        }

    }
}


class NameGenerator
{
    private string name; 
    private string city;
    private string adj;


    public string GetName
    {
        get => name;
        set => name = value;
    }
    
    public string GetCity
    {
        get => city;
        set => city = value;
    }

    public string GetRPGClass
    {
        get => adj;
        set => adj = value;
    }

    
}
