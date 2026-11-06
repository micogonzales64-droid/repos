using System.ComponentModel.DataAnnotations;

class Products
{
    public string Menu { get; set; }
    public int Price { get; set; }
}

class Program
{
    // static so Main can call it directly
    static void PaymentMethods(List<Products> cart, int total)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. cash\n2. utang");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nthank u for buying the following products:");
                    foreach (Products item in cart)
                    {
                        Console.WriteLine($"- {item.Menu} ({item.Price})");
                    }
                    Console.WriteLine($"ur total is: {total}");
                    running = false;

                    break;
                case 2:
                    Console.WriteLine("TANGINA MOOOOOOOOO");
                    break;
            }
        }
    }

    static void Main(string[] args)
    {
        Products beefpares = new Products { Menu = "Beef Pares", Price = 65 };
        Products lechonpares = new Products { Menu = "Letchon Pares", Price = 75 };
        Products lugawlechon = new Products { Menu = "Lugaw with Letchon", Price = 75 };
        List<Products> cart = new List<Products>();

        int total = 0;
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nWelcome to Tan's Paresan");
            Console.WriteLine("1. Beef Pares\n2. Letchon Pares\n3. Lugaw with Letchon\n4. Checkout");
            Console.Write("Pick a product: ");
            string choice = Console.ReadLine();
            

            switch (choice)
            {
                case "1":
                    total += beefpares.Price;
                    Console.WriteLine($"beef pares was added to ur cart. ur total is now: {total}");
                    cart.Add(beefpares);
                    break;
                case "2":
                    total += lechonpares.Price;
                    Console.WriteLine($"lechon pares was added to ur cart. ur total is now: {total}");
                    cart.Add(lechonpares);
                    break;
                case "3":
                    total += lugawlechon.Price;
                    Console.WriteLine($"lugaw with lechon was added to ur cart. ur total is now: {total}");
                    cart.Add(lugawlechon);
                    break;
                case "4":
                    PaymentMethods(cart, total);
                    running = false;
                    break;
            }
        }
    }
}