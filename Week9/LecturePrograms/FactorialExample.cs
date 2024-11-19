namespace FactorialExample
{
    internal class Program
    {
        static void Main(string[] args) {
            try {
                int number = Convert.ToInt32(Console.ReadLine());

                int factorial = Factorial(number);

                Console.WriteLine("Factorial: " + factorial);
            }
            catch (OverflowException) {
                Console.WriteLine("Error: Factorial exceeds the maximum value of Int32.");
            }
            catch (FormatException) {
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            }
            catch (Exception ex) {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public static int Factorial(int n) {
            if (n < 0) {
                throw new ArgumentException("Number must be non-negative.");
            }
            if (n == 0)
                return 1;
            else checked { return n * Factorial(n - 1); }


        }
    }
}