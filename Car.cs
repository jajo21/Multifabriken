using System;

namespace multifabriken_jajo21
{
    class Car
    {
        private string licensePlateLetters, color, carBrand;
        private int licensePlateNumber;

        public Car(string licensePlateLetters, string color, string carBrand, int licensePlateNumber) {
            this.licensePlateLetters = licensePlateLetters;
            this.licensePlateNumber = licensePlateNumber;
            this.color = color;
            this.carBrand = carBrand;
        }
        public string GetCarString() {
            return ($"Registreringsnummer: {licensePlateLetters} {licensePlateNumber}, Bilmärke: {carBrand}, Färg: {color}");
        }
    }
}