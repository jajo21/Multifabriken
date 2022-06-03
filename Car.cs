using System;

namespace multifabriken_jajo21
{
    /*-----------------------------Klass-----------------------------
    Car innehåller de delar som behövs för att bygga en bilorder.
    ----------------------------------------------------------------- */
    class Car
    {
        private string licensePlateLetters, color, carBrand;
        private int licensePlateNumber;
        /*--------------------------Konstruktor--------------------------
        Konstruktor som tar in tre string parametrar och en int parameter.
        ----------------------------------------------------------------- */
        public Car(string licensePlateLetters, string color, string carBrand, int licensePlateNumber)
        {
            this.licensePlateLetters = licensePlateLetters;
            this.licensePlateNumber = licensePlateNumber;
            this.color = color;
            this.carBrand = carBrand;
        }
        /*---------------------------Metod---------------------------
        Metod som returnerar en string med information om ordern.
        ------------------------------------------------------------- */
        public string GetCarString()
        {
            return ($"Registreringsnummer: {licensePlateLetters} {licensePlateNumber}, Bilmärke: {carBrand}, Färg: {color}");
        }
    }
}