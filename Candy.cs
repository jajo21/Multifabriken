using System;

namespace multifabriken_jajo21
{
    /*------------------------------Klass------------------------------
    Candy innehåller de delar som behövs för att bygga en godisorder.
    ------------------------------------------------------------------- */
    class Candy {
        private string flavour;
        private int quantity;
        /*--------------------------Konstruktor--------------------------
        Konstruktor som tar in en string parameter och en int parameter.
        ----------------------------------------------------------------- */
        public Candy(string flavour, int quantity) { 
            this.flavour = flavour;
            this.quantity = quantity;
        }
        /*---------------------------Metod---------------------------
        Metod som returnerar en string med information om ordern.
        ------------------------------------------------------------- */
        public string GetCandyString() {
            return ($"Smak: {flavour}, Antal: {quantity}"); 
        }
    }
}