using System;

namespace multifabriken_jajo21
{
    class Tofu 
    {
        protected string flavour;
        protected int volume;

        public Tofu(){
            Console.WriteLine("Välkommen till Multifabrikens tofubeställning!");
            Console.WriteLine("Vänligen svara på kommande frågor för att beställa din tofu.");
            Console.Write("\nVänligen ange vilken kryddning du vill ha på din Tofu: ");
            this.flavour = Console.ReadLine();
            Console.Write("Vänligen ange hur många liter Tofu du vill ha: ");
            this.volume = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nVad kul, du har nu beställt Tofu!\nKryddning: {flavour} \nMängd: {volume} Liter");
            Console.WriteLine("\n---Tryck på valfri tangent för att gå tillbaka till menyn---");
            Console.ReadKey();
            Console.Clear(); 
        }

        public string GetTofuString(){
            return ($"Smak: {flavour}, Liter: {volume}"); 
        }
    }
}