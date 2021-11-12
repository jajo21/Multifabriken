using System;

namespace multifabriken_jajo21
{
    class Lace
    {
        protected string color;
        protected int length;

        public Lace() {
            Console.WriteLine("Välkommen till Multifabrikens snöresbeställning!");
            Console.WriteLine("Vänligen svara på kommande frågor för att beställa ditt snöre.");
            Console.Write("\nSkriv in vilken färg du vill ha på ditt snöre: ");
            this.color = Console.ReadLine();
            Console.Write("Skriv in vilken längd i centimeter du vill ha på ditt snöre: ");
            this.length = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"\nVad kul, du har beställt ett snöre!\nFärg: {color} \nLängd: {length} cm");
            Console.WriteLine("\n---Tryck på valfri tangent för att gå tillbaka till menyn---");
            Console.ReadKey();
            Console.Clear(); 
        }

        public string GetLaceString()
        {
            return ($"Färg: {color}, Längd: {length}"); 
        }
    }
}