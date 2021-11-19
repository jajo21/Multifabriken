using System;
using System.Collections.Generic;

namespace multifabriken_jajo21
{
    class Menu
    {
        private List<Car> carList;
        private List<Candy> candyList;
        private List<Lace> laceList;
        private List<Tofu> tofuList;
        public Menu() // Konstruktor för listorna
        {
            carList = new List<Car>();
            candyList = new List<Candy>();
            laceList = new List<Lace>();
            tofuList = new List<Tofu>();
        }
        /*----------------------------------Metod----------------------------------
        RunMenu visar menyn för användaren och anropar programmets metoder beroende
        på användarens val. -------------------------------------------------------
        --------------------------------------------------------------------------- */
        public void RunMenu()
        {
            {
                Console.Clear();

                while (true)
                {
                    PrintMenu(); // Skriver ut huvudmenyn där användaren kan se de olika valen.

                    int menuChoice = ReadLineCheckInteger(); /* Deklarerar menuChoice till en metod som tar en 
                    input från användaren och kontrollerar om det är ett nummer som skrivs, är det ett nummer 
                    tillsätter den värdet till variabeln, annars får man ett felmeddelande och får försöka igen */

                    // Switchen nedanför kontrollerar vilket knapptryck användaren gör och går in på vald metod.
                    switch (menuChoice)
                    { 
                        case 1:
                            AddNewCar();
                            break;
                        case 2:
                            AddNewCandy();
                            break;
                        case 3:
                            AddNewLace();
                            break;
                        case 4:
                            AddNewTofu();
                            break;
                        case 5:
                            GetOrderLists();
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("\nFelaktig inmatning! Du kan bara mata in siffror mellan 0-5. Gå gärna tillbaka till menyn och försök igen!");
                            Console.WriteLine("\n---Tryck på valfri tangent för att gå tillbaka till menyn---");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
            }
        }
        /*-------------------------------Metod-------------------------------
        PrintMenu skriver ut den synliga huvudmenyn för användaren. ---------
        --------------------------------------------------------------------- */
        private void PrintMenu()
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
        }
        /*---------------------------------Metod---------------------------------
        AddNewCar lägger till en ny bil i billistan beroende på användarens val.
        ------------------------------------------------------------------------- */
        private void AddNewCar()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till Multifabrikens bilbeställning!");
            Console.WriteLine("Vänligen svara på kommande frågor för att beställa din bil.");
            Console.WriteLine("Svenska bilar har registreringsnummer med tre bokstäver och tre siffror, A-Z.");

            Console.Write("\nSkriv in tre bokstäver till bilens registreringsnummer: ");
            string licensePlateLetters = ReadLineCheckString();

            Console.Write("Skriv in tre siffror till bilens registreringsnummer: ");
            int licensePlateNumber = ReadLineCheckInteger();

            Console.WriteLine($"Bilens registreringsnummer kommer att bli: {licensePlateLetters} {licensePlateNumber}\n");
            Console.Write("Skriv in vilken färg du önskar ha på bilen: ");
            string color = ReadLineCheckString();
            Console.Write("Skriv in vilket bilmärke du önskar: ");
            string carBrand = ReadLineCheckString();

            Car newCar = new Car(licensePlateLetters, color, carBrand, licensePlateNumber); // Skapar ett nytt objekt av klassen Car
            carList.Add(newCar); // Lägger till det nyskapade objektet i rätt lista

            Console.WriteLine($"\nDu har beställt följande bil: \nRegistreringsnummer: {licensePlateLetters} {licensePlateNumber} \nBilmärke: {carBrand} \nFärg: {color}");
            Console.WriteLine("\n---Tryck på valfri tangent för att gå tillbaka till menyn---");
            Console.ReadKey();
            Console.Clear();
        }
        /*------------------------------------Metod------------------------------------
        AddNewCandy lägger till en ny godis i godislistan beroende på användarens val.
        ------------------------------------------------------------------------------- */
        private void AddNewCandy()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till Multifabrikens godisbeställning!");
            Console.WriteLine("Vänligen svara på kommande frågor för att beställa ditt godis.");

            Console.Write("\nVänligen ange vilken smak du vill ha på ditt godis: ");
            string flavour = ReadLineCheckString();
            Console.Write("Vänligen ange antalet godisar du vill ha: ");
            int quantity = ReadLineCheckInteger();

            Candy newCandy = new Candy(flavour, quantity); // Skapar ett nytt objekt av klassen Candy
            candyList.Add(newCandy); // Lägger till det nyskapade objektet i rätt lista

            Console.WriteLine($"\nDu har beställt följande godis: {flavour} \nAntal: {quantity}");
            Console.WriteLine("\n---Tryck på valfri tangent för att gå tillbaka till menyn---");
            Console.ReadKey();
            Console.Clear();
        }
        /*-------------------------------------Metod-------------------------------------
        AddNewLace lägger till ett nytt snöre i snöreslistan beroende på användarens val.
        --------------------------------------------------------------------------------- */
        private void AddNewLace()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till Multifabrikens snöresbeställning!");
            Console.WriteLine("Vänligen svara på kommande frågor för att beställa ditt snöre.");

            Console.Write("\nSkriv in vilken färg du vill ha på ditt snöre: ");
            string color = ReadLineCheckString();
            Console.Write("Skriv in vilken längd i centimeter du vill ha på ditt snöre: ");
            int length = ReadLineCheckInteger();

            Lace newLace = new Lace(color, length); // Skapar ett nytt objekt av klassen Lace
            laceList.Add(newLace); // Lägger till det nyskapade objektet i rätt lista

            Console.WriteLine($"\nDu har beställt följande snöre: \nFärg: {color} \nLängd: {length} cm");
            Console.WriteLine("\n---Tryck på valfri tangent för att gå tillbaka till menyn---");
            Console.ReadKey();
            Console.Clear();
        }
        /*---------------------------------Metod---------------------------------
        AddNewTofu lägger till ny tofu i tofulistan beroende på användarens val.
        ------------------------------------------------------------------------- */
        private void AddNewTofu()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till Multifabrikens tofubeställning!");
            Console.WriteLine("Vänligen svara på kommande frågor för att beställa din tofu.");

            Console.Write("\nVänligen ange vilken kryddning du vill ha på din Tofu: ");
            string flavour = ReadLineCheckString();
            Console.Write("Vänligen ange hur många liter Tofu du vill ha: ");

            int volume = ReadLineCheckInteger();

            Tofu newTofu = new Tofu(flavour, volume); // Skapar ett nytt objekt av klassen Tofu
            tofuList.Add(newTofu); // Lägger till det nyskapade objektet i rätt lista

            Console.WriteLine($"\nDu har beställt följande Tofu!\nKryddning: {flavour} \nMängd: {volume} Liter");
            Console.WriteLine("\n---Tryck på valfri tangent för att gå tillbaka till menyn---");
            Console.ReadKey();
            Console.Clear();
        }
        /*--------------------------------------Metod--------------------------------------
        GetOrderList hämtar användarens sparade input från respektive lista och skriver ut.
        ----------------------------------------------------------------------------------- */
        private void GetOrderLists()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till Multifabrikens ordersida!");
            Console.WriteLine("Här kan du se vilka produkter du har beställt:");

            // Utskrift för alla bilar
            Console.WriteLine("\nBilar: ");
            if (carList.Count == 0)
            {
                Console.WriteLine("Inga bilar beställda");
            }
            else
            {
                for (int i = 0; i < carList.Count; i++)
                {
                    Car car = carList[i];
                    Console.WriteLine((i + 1) + ". " + car.GetCarString());
                }
            }

            // Utskrift för alla godisar
            Console.WriteLine("\nGodis: ");
            if (candyList.Count == 0)
            {
                Console.WriteLine("Inget godis beställt");
            }
            else
            {
                for (int i = 0; i < candyList.Count; i++)
                {
                    Candy candy = candyList[i];
                    Console.WriteLine((i + 1) + ". " + candy.GetCandyString());
                }
            }

            // Utskrift för alla snören
            Console.WriteLine("\nSnöre: ");
            if (laceList.Count == 0)
            {
                Console.WriteLine("Inget snöre beställt");
            }
            else
            {
                for (int i = 0; i < laceList.Count; i++)
                {
                    Lace lace = laceList[i];
                    Console.WriteLine((i + 1) + ". " + lace.GetLaceString());
                }
            }

            // Utskrift för all Tofu
            Console.WriteLine("\nTofu: ");
            if (tofuList.Count == 0)
            {
                Console.WriteLine("Ingen tofu beställd");
            }
            else
            {
                for (int i = 0; i < tofuList.Count; i++)
                {
                    Tofu tofu = tofuList[i];
                    Console.WriteLine((i + 1) + ". " + tofu.GetTofuString());
                }
            }
            Console.WriteLine("\n---Tryck på valfri tangent för att gå tillbaka till menyn---");
            Console.ReadKey();
            Console.Clear();
        }
        /*---------------------------------Metod---------------------------------
        ReadLineCheckString läser in input från användaren och returnerar inputen 
        om den inte är tom, är den tom får man försöka igen. --------------------
        ------------------------------------------------------------------------- */
        private string ReadLineCheckString()
        {
            string inputString;
            while (true)
            {
                inputString = Console.ReadLine();
                if (!string.IsNullOrEmpty(inputString))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Du kan inte lämna ett tomt fält! Försök igen.");
                    Console.Write("\nSkriv här: ");
                }
            }
            return inputString;
        }
        /*-----------------------------------Metod-----------------------------------
        ReadLineCheckInteger läser in input från användaren och kollar att den är en 
        siffra och att den inte är tom, returnerar ett värde kraven uppfylls, annars 
        skickas ett felmeddelande och man får försöka igen.--------------------------
        ----------------------------------------------------------------------------- */
        private int ReadLineCheckInteger()
        {
            int number;
            while (true)
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number.ToString() != null)
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("\nFelaktigt inmatning. Du kan bara mata in siffror. Testa igen!");
                    Console.Write("\nSkriv här: ");
                }
            }
            return number;
        }
    }
}