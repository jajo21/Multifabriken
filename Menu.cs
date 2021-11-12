using System;
using System.Collections.Generic;

namespace multifabriken_jajo21 {
    class Menu {
        protected List<Car> carList = new List<Car> ();
        protected List<Candy> candyList = new List<Candy> ();
        protected List<Lace> laceList = new List<Lace> ();
        protected List<Tofu> tofuList = new List<Tofu> ();
        public void RunMenu () {
            {
                Console.Clear();
                int menuChoice;

                while (true) {

                    GetMenuString (); // Skriver ut menyn med olika val till användaren.

                    while (true) {//Kolla att ett nummer mellan 0-5 skrivs in annars försök igen
                        try {
                            menuChoice = Convert.ToInt32 (Console.ReadLine ());
                            if (menuChoice <= 5 && menuChoice >= 0)
                                break;
                        } catch {
                            Console.WriteLine ("\nFelaktigt val. Testa igen!\nDu kan bara mata in siffrorna 0-5 för att välja i menyn!");
                            Console.Write ("\nSkriv här: ");
                        }
                    }

                    switch (menuChoice) {
                        case 1: // Bilar
                            Console.Clear ();
                            var newCar = new Car ();
                            carList.Add (newCar);
                            break;
                        case 2: // Godis
                            Console.Clear();
                            var newCandy = new Candy();
                            candyList.Add(newCandy);
                            break;
                        case 3: // Snöre
                            Console.Clear();
                            var newLace = new Lace();
                            laceList.Add(newLace);
                            break;
                        case 4: // Tofu
                            Console.Clear();
                            var newTofu = new Tofu();
                            tofuList.Add(newTofu);
                            break;
                        case 5:
                            GetOrderList ();
                            break;
                        case 0:
                            return;
                    }
                }
            }
        }
        private void GetMenuString () {
            Console.WriteLine ("Hej och Välkommen till Multifabriken!\n" +
                "Här kan du beställa de bästa produkterna i stan.\n" +
                "Välj och vraka mellan bilar, godis, snören och tofu!\n" +
                "Välj produkt genom att skriva en siffra och klicka därefter på enterknappen.\n" +
                "När beställning är lagd går den ej att ångra. Så tänk dig noga för innan du gör ditt val!\n");

            Console.WriteLine ("1: Beställ Bil");
            Console.WriteLine ("2: Beställ Godis");
            Console.WriteLine ("3: Beställ Snöre");
            Console.WriteLine ("4: Beställ Tofu");
            Console.WriteLine ("5: Skriv ut alla beställda produkter");
            Console.WriteLine ("0: Avsluta programmet\n");
            Console.Write ("Skriv här: ");
        }

        private void GetOrderList () {
            Console.Clear ();
            Console.WriteLine ("Välkommen till Multifabrikens ordersida!");
            Console.WriteLine ("Här kan du se vilka produkter du har beställt:");

            //Utskrift för alla bilar
            Console.WriteLine ("\nBilar: ");
            if (carList.Count == 0) {
                Console.WriteLine ("Inga bilar beställda");
            } else {
                for(int i = 0; i < carList.Count; i++) {
                    Car car = carList[i];                  
                    Console.WriteLine ((i+1) + ": " + car.GetCarString ());
                }
            }

            // Utskrift för alla godisar
            Console.WriteLine ("\nGodis: ");
            if (candyList.Count == 0) {
                Console.WriteLine ("Inget godis beställt");
            } else {
                for(int i = 0; i < candyList.Count; i++) {
                    Candy candy = candyList[i];                  
                    Console.WriteLine ((i+1) + ": " + candy.GetCandyString ());
                }
            }

            //Utskrift för alla snören
            Console.WriteLine ("\nSnöre: ");
            if (laceList.Count == 0) {
                Console.WriteLine ("Inget snöre beställt");
            } else {
                 for(int i = 0; i < laceList.Count; i++) {
                    Lace lace = laceList[i];                  
                    Console.WriteLine ((i+1) + ": " + lace.GetLaceString ());
                }
            }

            //Utskrift för all Tofu
            Console.WriteLine ("\nTofu: ");
            if (tofuList.Count == 0) {
                Console.WriteLine ("Ingen tofu beställd");
            } else {
                for(int i = 0; i < tofuList.Count; i++) {
                    Tofu tofu = tofuList[i];                  
                    Console.WriteLine ((i+1) + ": " + tofu.GetTofuString ());
                }
            }
            Console.WriteLine ("\n---Tryck på valfri tangent för att gå tillbaka till menyn---");
            Console.ReadKey ();
            Console.Clear();
        }
    }
}