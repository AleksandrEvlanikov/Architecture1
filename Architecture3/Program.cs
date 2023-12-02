using System.Drawing;

namespace Architecture3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RefuelingStation refuelingStation = new RefuelingStation();
            RefuelingStationV2 refuelingStationV2 = new RefuelingStationV2();
            ServiceStation serviceStation = new ServiceStation();
            CarWash carWash = new CarWash();
            SportCar sportCar1 = new SportCar("Audi", "V6", Color.Black, 4);
            SportCar sportCar2 = new SportCar("BMW", "X5", Color.Black, 4);
            Harvester harvester = new Harvester("Боготырь", "10", Color.Yellow, Color.Black);
            CommonCar commonCar1 = new CommonCar("Hyundai", "i20", Color.White);

            Console.WriteLine($"Марка машины {commonCar1.Make} Модель машины {commonCar1.Model}");
            Console.WriteLine();
            commonCar1.Movement(refuelingStation.LocationRefuelingStation());
            commonCar1.SetRefuelingStation(refuelingStation, FuelType.Gasoline);
            commonCar1.Fuel();
            commonCar1.Movement(serviceStation.LocationRefuelingStation());
            commonCar1.Maintenance();
            CalculateMaintenance(commonCar1);
            commonCar1.Movement(carWash.LocationRefuelingStation());
            carWash.AutoWashCar(commonCar1);
            Console.WriteLine();

            Console.WriteLine($"Марка машины {sportCar2.Make} Модель машины {sportCar2.Model}");
            Console.WriteLine();
            sportCar2.Movement(refuelingStationV2.LocationRefuelingStation());
            sportCar2.SetRefuelingStation(refuelingStationV2, FuelType.Gas);
            sportCar2.Fuel();
            sportCar2.Movement(carWash.LocationRefuelingStation());
            carWash.AutoWashCar(sportCar2);
            carWash.WipWindshield();
            carWash.WipHeadlights();

            Console.WriteLine();
            Console.WriteLine($"Марка машины {harvester.Make} Модель машины {harvester.Model}");
            harvester.Movement(serviceStation.LocationRefuelingStation());
            harvester.Maintenance();
            CalculateMaintenance(harvester);
            harvester.Movement(carWash.LocationRefuelingStation());
            carWash.AutoWashCar(harvester);
            carWash.WipWindshield();
            carWash.WipHeadlights();
            carWash.WipMirrors();
            harvester.Movement(refuelingStationV2.LocationRefuelingStation());
            harvester.SetRefuelingStation(refuelingStationV2, FuelType.Diesel);
            harvester.Fuel();
            harvester.Sweeping();







        }

        public static double CalculateMaintenance(Car car)
        {
            double cost;
            if(car.GetWheelsCount() == 6) 
            {
                cost = 1500 * 6;
            }
            else
            {
                cost = 1000 * 4;
            }
            Console.WriteLine($"Цена за смену колес = {cost}р");
            return cost;

        }
    }
}
