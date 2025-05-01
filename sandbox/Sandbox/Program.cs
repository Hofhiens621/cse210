using System;

class Program
{
    static void Main(string[] args)
    {
        // hello world program
        // Console.WriteLine("Hello Sandbox World!");
        // Console.Write("What is your favorite color? ");
        // string color = Console.ReadLine();
        // Console.WriteLine(color);

        // practice
        string value = "42";
        int num = int.Parse(value);

        int x = 5;
        string str_x = x.ToString();

        string response = "yes";
        while (response.ToLower() == "yes")
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();

        }

        do
        {
            Console.Write("Are you sure? ");
            response = Console.ReadLine();

        }
        while (response.ToLower() != "yes");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        // james bond program

        // lists
        List<string> animals = new List<string>();
        List<int> debits = new List<int>();
        animals.Add("Cow");
        animals.Add("Horse");
        foreach (string animal in animals)
        {
            Console.WriteLine(animal);
        }
        Console.WriteLine(animals.Count);
    }
}