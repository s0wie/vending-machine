var vendingMachine = new VendingMachine();
vendingMachine.Items = new List<Item>()
{
new Item("COCA-COLA", 33),
new Item("FANTA", 33),
new Item("SPRITE", 33),
new Item("PRINGLES", 25),
new Item("LOLLIPOP", 10),
new Item("CHEWING-GUM", 10),
new Item("SNICKERS", 20),
new Item("MARABOU", 20),
new Item("REFRESHERS", 33),
new Item("POPCORN", 25),
new Item("M&M", 18),
new Item("DORRITOS", 25),
};

var options = "";
var total = 50;

Console.WriteLine("Welcome to Fantastic Vending Machine!!");

while (options == "")
{
    Console.WriteLine();
    Console.WriteLine("What would you like to do?");
    Console.Write("Type SEE, BUY NOW, VIEW CREDIT or LEAVE: ");

    options = Console.ReadLine();

    if (options == "SEE")
    {

        foreach (Item item in vendingMachine.Items)
        {
            Console.WriteLine(item.Name + " - " + item.Price + ":-");
        }

        Console.WriteLine();
        Console.Write("Type BUY NOW or LEAVE: ");
        options = Console.ReadLine(); ;

        if (options == "LEAVE")
        {
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - -");
            Console.WriteLine(" 🙂 WELCOME BACK 🙂 ");
            Console.WriteLine("- - - - - - - - - - -");
            System.Threading.Thread.Sleep(2000);
            options = "";
        }

        if (options == "BUY NOW")
        {
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine(" :) TYPE THE NAME OF THE ITEM YOU WOULD LIKE :) ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");

            options = Console.ReadLine();


            foreach (Item item in vendingMachine.Items)
            {

                if (options == item.Name)
                {
                    if (total < item.Price)
                    {
                        Console.WriteLine("You don't have enough money, try again");
                        options = "";
                    }
                    else
                    {
                        total = total - item.Price;
                        Console.WriteLine($"You bought a {item.Name} which costs {item.Price} SEK. You now have {total} SEK left ");
                        System.Threading.Thread.Sleep(2000);
                        options = "";
                    }
                } 
            }


        }
    }
        else if (options == "VIEW CREDIT")
        {
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine($" YOUR CREDIT IS: {total} SEK");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Type LEAVE to exit");
            options = Console.ReadLine();

        }
        else if (options == "BUY NOW")
    {
        Console.WriteLine();
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine(" :) TYPE THE NAME OF THE ITEM YOU WOULD LIKE :) ");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");

        options = Console.ReadLine();


        foreach (Item item in vendingMachine.Items)
        {

            if (options == item.Name)
            {
                if (total < item.Price)
                {
                    Console.WriteLine("You don't have enough money, try again");
                    options = "";
                }
                else
                {
                    total = total - item.Price;
                    Console.WriteLine($"You bought a {item.Name} which costs {item.Price} SEK. You now have {total} SEK left ");
                    System.Threading.Thread.Sleep(2000);
                    options = "";
                }
            }
        }


    }
    else if (options == "LEAVE")
        {
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - -");
            Console.WriteLine(" :) WELCOME BACK :) ");
            Console.WriteLine("- - - - - - - - - - -");
            System.Threading.Thread.Sleep(2000);
            options = "";
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("I'm sorry, that's not a valid option");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
            Console.WriteLine();
            options = "";

        }
        if (options == "LEAVE")
        {
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - -");
            Console.WriteLine(" :) WELCOME BACK :) ");
            Console.WriteLine("- - - - - - - - - - -");
            System.Threading.Thread.Sleep(2000);
            options = "";
        }
}
