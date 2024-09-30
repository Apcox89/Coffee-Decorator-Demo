public class Program
{
    public static void Main(string[] args)
    {
        // Start with a simple coffee
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine($"{coffee.GetDescription()} costs {coffee.GetCost()}");

        // Add milk to the coffee
        coffee = new MilkDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} costs {coffee.GetCost()}");

        // Add sugar to the coffee
        coffee = new SugarDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} costs {coffee.GetCost()}");

        // Add chocolate to the coffee
        coffee = new ChocolateDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} costs {coffee.GetCost()}");

        // Final coffee with all the toppings
        Console.WriteLine($"\nFinal order: {coffee.GetDescription()}");
        Console.WriteLine($"Total cost: {coffee.GetCost()}");
    }
}
