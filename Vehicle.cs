using System;

namespace ConsoleApp1
{
    class Vehicle
    {
        /* Nehmen wir an, da sind gerade 50l im Tank
         * und es passen nur 50l rein.
         */
        protected double carTank;
        protected double consumptionEach100Km;

        public Vehicle(double _carTank, double _consumptionEach100Km)
        {
            carTank = _carTank;
            consumptionEach100Km = _consumptionEach100Km;
        }

        public virtual void Describe()
        {
            Console.WriteLine("Car details:");
            Console.WriteLine($"Tank: {carTank}l");
            Console.WriteLine($"Fuel consumption: {consumptionEach100Km}l/100km");
        }

        public void Drive(int kilometres)
        {
            double consumedFuel = kilometres * (consumptionEach100Km / 100.0);

            if (ConsumeFuel(consumedFuel))
            {
                Console.WriteLine($"You drove {kilometres} and used {consumedFuel}l of fuel.");
            }
            else
            {
                Console.WriteLine($"Not enough fuel available in order to drive {kilometres}km.");
            }
        }

        protected bool ConsumeFuel(double fuelToConsume)
        {
            bool canConsume = (fuelToConsume <= carTank);

            if (canConsume)
            {
                carTank -= fuelToConsume;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
