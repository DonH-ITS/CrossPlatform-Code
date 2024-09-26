using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarSystem
{
    internal class RentalCar : Vehicle
    {
        private static int categoryE, categoryM, categoryL = 0;
        public char Category {  get; set; }
        
        public RentalCar(string model, string brand, char category, int year, double dailyRate) : base(model, brand, year, dailyRate) {
            Category = category;
            switch (category) {
                case 'E':
                    categoryE++;
                    break;
                case 'M':
                    ++categoryM;
                    break;
                case 'L':
                    categoryL++;
                    break;
            }
        }

        public override string GetVehicleType() {
            return "Car";
        }

        public override string ToString() {
            string result = base.ToString();
            result += '\n';
            switch (Category) {
                case 'E':
                    result += "Economy";
                    break;
                case 'M':
                    result += "Midsize";
                    break;
                case 'L':
                    result += "Luxury";
                    break;
                default:
                    result += "Unknown Category";
                    break;
            }
            result += "\nVehicle Type: Car";
            return result;
        }

        public static string GenerateCarReport() {
            string result = "Car Rental Report:\n--------------\n";
            result += "Total Economy Cars: " + categoryE;
            result += "\nTotal Midsize Cars: " + categoryM;
            result += "\nTotal Luxury Cars: " + categoryL;
            result += "\n";
            return result;
        }
    }
}
