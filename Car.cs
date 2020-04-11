using System;

namespace ConsoleApp1
{
    class Car : Vehicle
    {
        private string model;
        private bool hasSpoiler;

        public Car(
            double _carTank, 
            double _consumptionEach100Km, 
            string _model, 
            bool _hasSpoiler
            ) : base(_carTank, _consumptionEach100Km)
        {
            model = _model;
            hasSpoiler = _hasSpoiler;
        }

        public override void Describe()
        {
            base.Describe();
            Console.WriteLine($"Model name: {model}");
            Console.WriteLine($"Has spoiler?: {(hasSpoiler ? "Yes" : "No")}");
        }

        public bool DriveBackwards(double _distance)
        {
            double consumedFuel = _distance * (consumptionEach100Km / 100.0);

            if (base.ConsumeFuel(consumedFuel))
            {
                Console.WriteLine($"You drove {_distance} backwards and used {consumedFuel}l of fuel.");
                return true;
            }
            else
            {
                Console.WriteLine($"Not enough fuel available in order to drive {_distance}km backwards.");
                return false;
            }
        }
    }
}


