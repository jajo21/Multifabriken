using System;

namespace multifabriken_jajo21
{
    class Tofu 
    {
        private string flavour;
        private int volume;

        public Tofu(string flavour, int volume){
            this.flavour = flavour;
            this.volume = volume;
        }

        public string GetTofuString(){
            return ($"Smak: {flavour}, Liter: {volume}"); 
        }
    }
}