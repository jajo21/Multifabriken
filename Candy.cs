using System;

namespace multifabriken_jajo21
{
    class Candy {
        private string flavour;
        private int quantity;

        public Candy(string flavour, int quantity) { 
            this.flavour = flavour;
            this.quantity = quantity;
        }
        public string GetCandyString() {
            return ($"Smak: {flavour}, Antal: {quantity}"); 
        }
    }
}