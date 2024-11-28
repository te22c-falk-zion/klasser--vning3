public class worker(string n, int a) {
    protected string name = n;
    protected int age = a;
    protected int wage = 0;

    public void SetWage()
    {
        string wageString = "start";
        while (!wageString.All(char.IsDigit))
        {
            Console.WriteLine("How much should the wage be?");
            wageString = Console.ReadLine();
            int.TryParse(wageString, out wage);
        }
        Console.WriteLine($"The wage was set to {wage}");
        Console.ReadLine();
    }
    public string GetName()
    {
        Console.WriteLine(name);
        return name;
    }
    public int GetAge()
    {
        Console.WriteLine(age);
        return age;
    }
    public int GetWage()
    {
        Console.WriteLine(wage);
        return wage;
    }
}