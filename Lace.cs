using System;

namespace multifabriken_jajo21
{
    /*-----------------------------Klass-----------------------------
    Lace innehåller de delar som behövs för att bygga en snöresorder.
    ----------------------------------------------------------------- */
    class Lace
    {
        private string color;
        private int length;
        /*--------------------------Konstruktor--------------------------
        Konstruktor som tar in en string parameter och en int parameter.
        ----------------------------------------------------------------- */
        public Lace(string color, int length)
        {
            this.color = color;
            this.length = length;
        }
        /*---------------------------Metod---------------------------
        Metod som returnerar en string med information om ordern.
        ------------------------------------------------------------- */
        public string GetLaceString()
        {
            return ($"Färg: {color}, Längd: {length}");
        }
    }
}