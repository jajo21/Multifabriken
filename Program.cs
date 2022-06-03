using System;

namespace multifabriken_jajo21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*---------------------------Objekt---------------------------
            Skapar ett nytt objekt av klassen Menu och anropar funktionen 
            RunMenu för att köra programmet.------------------------------
            -------------------------------------------------------------- */
            Menu multifabriken = new Menu();
            multifabriken.RunMenu();
        }
    }
}