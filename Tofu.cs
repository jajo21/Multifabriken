using System;

namespace multifabriken_jajo21
{
    /*-----------------------------Klass-----------------------------
    Tofu innehåller de delar som behövs för att bygga en tofuorder.
    ----------------------------------------------------------------- */
    class Tofu 
    {
        private string flavour;
        private int volume;
        /*--------------------------Konstruktor--------------------------
        Konstruktor som tar in en string parameter och en int parameter.
        ----------------------------------------------------------------- */
        public Tofu(string flavour, int volume){
            this.flavour = flavour;
            this.volume = volume;
        }
        /*---------------------------Metod---------------------------
        Metod som returnerar en string med information om ordern.
        ------------------------------------------------------------- */
        public string GetTofuString(){
            return ($"Smak: {flavour}, Liter: {volume}"); 
        }
    }
}