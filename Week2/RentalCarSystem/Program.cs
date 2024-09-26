namespace RentalCarSystem
{
    internal class Program
    {
        static void Main(string[] args) {
            RentalCar[] cars = new RentalCar[10];
            cars[0] = new RentalCar("Corolla", "Toyota", 'E', 2022, 45.00);
            cars[1] = new RentalCar("Civic", "Honda", 'E', 2023, 48.00);
            cars[2] = new RentalCar("Camry", "Toyota", 'M', 2022, 55.00);
            cars[3] = new RentalCar("Accord", "Honda", 'M', 2023, 58.00);
            cars[4] = new RentalCar("3 Series", "BMW", 'L', 2023, 75.00);
            cars[5] = new RentalCar("Versa", "Nissan", 'E', 2022, 42.00);
            cars[6] = new RentalCar("E-Class", "Mercedes", 'L', 2023, 85.00);
            cars[7] = new RentalCar("Altima", "Nissan", 'M', 2022, 52.00);
            cars[8] = new RentalCar("5 Series", "BMW", 'L', 2022, 80.00);
            cars[9] = new RentalCar("Elantra", "Hyundai", 'E', 2023, 46.00);
            RentalTruck[] trucks =
            [
                new RentalTruck("F-150", "Ford", 2022, 89.00, 2.0),
                new RentalTruck("Silverado", "Chevrolet", 2023, 92.00, 2.5),
            ];
            Console.WriteLine("Vehicle Details:\n-----------------");
            foreach(var car in cars) {
                Console.WriteLine(car);
                Console.WriteLine();
            }
            for(int i=0; i < trucks.Length; i++) {
                Console.WriteLine(trucks[i]);
                Console.WriteLine();
            }
            Console.WriteLine(RentalCar.GenerateCarReport());
            Console.WriteLine(RentalTruck.GenerateTruckReport());
            DailyRentalRates(cars, trucks);

            //Another Way, since both cars and trucks inherit from Vehicle we can have a method that covers both
            //As long as that method only uses properties/methods that are in the Vehicle class
            double amount = DailyRentalRates(cars);
            amount += DailyRentalRates(trucks, 11);
            Console.WriteLine("\nTotal Daily Rental Value: $" + amount.ToString("N2"));
        }

        static void DailyRentalRates(RentalCar[] cars, RentalTruck[] trucks ) {
            int i = 1;
            double total = 0;
            foreach(var car in cars) {
                Console.WriteLine(i + ". $" + car.DailyRate.ToString("N2") + " (" + car.GetVehicleType() + ")");
                total += car.DailyRate;
            }
            foreach (var truck in trucks) {
                Console.WriteLine(i + ". $" + truck.DailyRate.ToString("N2") + " (" + truck.GetVehicleType() + ")");
                total += truck.DailyRate;
            }
            Console.WriteLine("\nTotal Daily Rental Value: $" + total.ToString("N2"));


        }

        static double DailyRentalRates(Vehicle[] vehicles, int i=1) {
            double total = 0;
            foreach (var vehicle in vehicles) {
                Console.WriteLine(i + ". $" + vehicle.DailyRate.ToString("N2") + " (" + vehicle.GetVehicleType() + ")");
                total += vehicle.DailyRate;
                i++;
            }
            return total;
        }
    }
}
