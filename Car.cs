using System;
using System.Collections.Generic;

namespace multifabriken_jajo21
{
    class Car
    {
        protected string licensePlateLetters, color, carBrand;
        protected int licensePlateNumber;

        public Car() {
            Console.WriteLine("Välkommen till Multifabrikens bilbeställning!");
            Console.WriteLine("Vänligen svara på kommande frågor för att beställa din bil.");
            Console.WriteLine("Svenska bilar har registreringsnummer med tre bokstäver och tre siffror, A-Z.");
            Console.Write("\nSkriv in tre bokstäver till bilens registreringsnummer: ");
            this.licensePlateLetters = Console.ReadLine();
            Console.Write("Skriv in tre siffror till bilens registreringsnummer: ");
            this.licensePlateNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Bilens registreringsnummer kommer att bli: {licensePlateLetters} {licensePlateNumber}\n");
            Console.Write("Skriv in vilken färg du önskar ha på bilen: ");
            this.color = Console.ReadLine();
            Console.Write("Skriv in vilket bilmärke du önskar: ");
            this.carBrand = Console.ReadLine();

            Console.WriteLine($"\nDu har beställt följande bil: \nRegistreringsnummer: {licensePlateLetters} {licensePlateNumber} \nBilmärke: {carBrand} \nFärg: {color}");
            Console.WriteLine("\n---Tryck på valfri tangent för att gå tillbaka till menyn---");
            Console.ReadKey();
            Console.Clear();
        }
        public string GetCarString() {
            return ($"Registreringsnummer: {licensePlateLetters} {licensePlateNumber}, Bilmärke: {carBrand}, Färg: {color}");
        }
    }
}