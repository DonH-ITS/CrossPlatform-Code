namespace RentalCarSystem
{
    internal class Vehicle
    {
        public string Model {  get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public double DailyRate { get; set; }  

        public Vehicle(string model, string brand, int year, double dailyRate) {
            Model = model;
            Brand = brand;
            Year = year;
            DailyRate = dailyRate;
        }

        public override string ToString() {
            string result = "Model: " + Model + "\n";
            result += "Brand: " + Brand + "\n";
            result += "Year: " + Year + "\n";
            result += "Daily Rental Rate: " + "$" + DailyRate;
            return result;
        }

        public virtual string GetVehicleType() {
            return "Generic Vehicle";
        }
    }
}
