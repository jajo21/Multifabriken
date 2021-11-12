using System;

namespace multifabriken_jajo21
{
    class Candy {
        protected string flavour;
        protected int quantity;

        public Candy() { 
            Console.WriteLine("Välkommen till Multifabrikens godisbeställning!");
            Console.WriteLine("Vänligen svara på kommande frågor för att beställa ditt godis.");
            Console.Write("\nVänligen ange vilken smak du vill ha på ditt godis: ");
            this.flavour = Console.ReadLine();
            Console.Write("Vänligen ange antalet godisar du vill ha: ");
            this.quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nDu har beställt följande godis: {flavour} \nAntal: {quantity}");
            Console.WriteLine("\n---Tryck på valfri tangent för att gå tillbaka till menyn---");
            Console.ReadKey();
            Console.Clear();
        }
        public string GetCandyString() {
            return ($"Smak: {flavour}, Antal: {quantity}"); 
        }
    }
}