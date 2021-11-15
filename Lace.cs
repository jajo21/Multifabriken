using System;

namespace multifabriken_jajo21
{
    class Lace
    {
        private string color;
        private int length;

        public Lace(string color, int length) {
            this.color = color;
            this.length = length;
        }

        public string GetLaceString()
        {
            return ($"Färg: {color}, Längd: {length}"); 
        }
    }
}