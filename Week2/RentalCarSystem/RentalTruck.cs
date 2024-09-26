namespace RentalCarSystem
{
    internal class RentalTruck : Vehicle
    {
        public double CargoCapacity {  get; set; }
        private static int countTrucks = 0;
        public RentalTruck(string model, string brand, int year, double dailyRate, double cargoCapacity) : base(model, brand, year, dailyRate) {

            CargoCapacity = cargoCapacity;
            countTrucks++;
        }

        public override string GetVehicleType() {
            return "Truck";
        }

        public override string ToString() {
            string result = base.ToString();
            result += '\n' + "Cargo Capacity: " + CargoCapacity + " cubic meters\n";
            result += "Vehicle Type: Truck";
            return result;
        }

        public static string GenerateTruckReport() {
            return "Truck Rental Report:\n----------------\nTotal Trucks: " + countTrucks;
        }
    }
}
