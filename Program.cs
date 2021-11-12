using System;
using System.Collections.Generic;

namespace multifabriken_jajo21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int menuChoice;
            int orderNumber = 1;
            List<Order> orderList = new List<Order>();
            while (true)
            {
                Console.WriteLine("Hej och Välkommen till Multifabriken!\n" +
                    "Här kan du beställa de bästa produkterna i stan.\n" +
                    "Välj och vraka mellan bilar, godis, snören och tofu!\n" +
                    "Välj produkt genom att skriva en siffra och klicka därefter på enterknappen.\n" +
                    "När beställning är lagd går den ej att ångra. Så tänk dig noga för innan du gör ditt val!\n");

                Console.WriteLine("1: Beställ Bil");
                Console.WriteLine("2: Beställ Godis");
                Console.WriteLine("3: Beställ Snöre");
                Console.WriteLine("4: Beställ Tofu");
                Console.WriteLine("5: Skriv ut alla beställda produkter");
                Console.WriteLine("0: Avsluta programmet\n");
                Console.Write("Skriv här: ");

                while (true)
                    try
                    {
                        menuChoice = Convert.ToInt32(Console.ReadLine());
                        if (menuChoice <= 5 && menuChoice >= 0)
                            break;
                    }
                    catch
                    {
                        Console.WriteLine("\nFelaktigt val. Testa igen!\nDu kan bara mata in siffrorna 0-5 för att välja i menyn!");
                        Console.Write("\nSkriv här: ");
                    }
                switch (menuChoice)
                {
                    case 1: // Bilar
                        Console.Clear();
                        Car newCar = new Car();
                        orderList.Add(newCar);
                        break;
                    case 2:// Godis
                        Console.Clear();
                        Candy newCandy = new Candy();
                        orderList.Add(newCandy);
                        break;
                    case 3:// Snöre
                        Console.Clear();
                        Lace newTie = new Lace();
                        orderList.Add(newTie);
                        break;
                    case 4:// Tofu
                        Console.Clear();
                        Tofu newTofu = new Tofu();
                        orderList.Add(newTofu);
                        break;
                    case 5:// Order
                        Console.Clear();
                        Console.WriteLine("Din beställningslista:\n");
                        
                        foreach(var order in orderList) {
                            Console.WriteLine($"Order {orderNumber}:");
                            order.GetOrderString();
                            orderNumber++;
                        }
                        Console.WriteLine("\n---Tryck på valfri tangent för att gå tillbaka till menyn---");
                        Console.ReadKey();
                        Console.Clear();
                        orderNumber = 1;
                        break;
                    case 0:
                        return;
                    default:
                        break;
                }
            }
        }
    }
}