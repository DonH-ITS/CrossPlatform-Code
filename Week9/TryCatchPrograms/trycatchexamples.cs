namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
            int divid = 0;
            try {
                int result = 10 / divid; // This will throw a DivideByZeroException
            }
            catch (DivideByZeroException ex) {
                Console.WriteLine("Division by zero is not allowed.");
            }
            catch (Exception ex) {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            ReadFile();
            loop();

            for (int i = 0; i < 6; i++) {
                M((Control)i);
            }

            Console.WriteLine("Goodbye, World");
        }

        static void loop() {
            int result = 0;
            for (int i = 0; i < 10; i++) {
                result += i;
            }
            Console.Write(result);

        }

        internal enum Control
        {
            Returning, Jumping, Continuing, Breaking,
            Throwing, Normal
        }

        public static void M(Control reason) {
            for (int i = 1; i <= 1; i++)  // a single iteration               
                try {
                    Console.WriteLine("\nEnter try: {0}", reason);
                    if (reason == Control.Returning) return;
                    else if (reason == Control.Jumping) goto finish;
                    else if (reason == Control.Continuing) continue;
                    else if (reason == Control.Breaking) break;
                    else if (reason == Control.Throwing) throw new Exception();
                    Console.WriteLine("Inside try");
                }
                catch (Exception) {
                    Console.WriteLine("Inside catch");
                }
                finally {
                    Console.WriteLine("Inside finally");
                }
            finish: return;
        }

        static void ReadFile() {
            string filePath = "example.txt";
            try {
                // Attempt to read from the file
                string content = File.ReadAllText(filePath);
                Console.WriteLine("File content:");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException) {
                Console.WriteLine($"File not found: {filePath}");
            }
            catch (UnauthorizedAccessException) {
                Console.WriteLine($"Access to the file is unauthorized: {filePath}");
            }
            catch (IOException ex) {
                Console.WriteLine($"An I/O error occurred: {ex.Message}");
            }
            catch (Exception ex) {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }


    }
}