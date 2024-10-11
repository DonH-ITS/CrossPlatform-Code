using System.Text.Json;

namespace FileWritingReading
{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");

            //StreamReader s = new StreamReader("Names.txt");
           // List<string> names = new List<string>();
            /* string line = "";
             while ((line = s.ReadLine()) != null) {
                 names.Add(line);
             }
             s.Close();

             for (int i = 0; i < names.Count(); ++i)
                 Console.WriteLine(names[i]);*/
            List<Entry> people = new List<Entry>();

            people.Add(new Entry("John Doe", 30, "Engineer"));
            people.Add(new Entry("Jane Smith", 25, "Analyst"));

            /*using (StreamWriter writer = new StreamWriter("output.csv")) {
                // Write header
                writer.WriteLine("Name,Age,Occupation");
                writer.
                // Write data rows
                foreach(var entry in people) {
                    writer.WriteLine(entry.name + "," + entry.Age + "," + entry.Occupation);
                }
            }*/
            /*using (StreamReader reader = new StreamReader("output.csv")) {
                int linecount = 0;
                while (!reader.EndOfStream) {
                    reader.ReadToEndAsync()
                    string line = reader.ReadLine();
                    //Split by the delimiter ,
                    string[] splits = line.Split(',');
                    if(linecount != 0) //Skip the Header
                        people.Add(new Entry(splits[0], Int32.Parse(splits[1]), splits[2]));
                    linecount++;
                }
            }*/
            foreach (var person in people) {
                Console.WriteLine("Name " + person.name);
                Console.WriteLine("Age " + person.Age);
                Console.WriteLine("Occupation " + person.Occupation);
                Console.WriteLine(person);
            }

            people[0].WritetoJson("entry.json");
            using (StreamReader reader = new StreamReader("entry.json")) {
                string jsonstring = reader.ReadToEnd();
                Entry bob = JsonSerializer.Deserialize<Entry>(jsonstring);
            }
            string jsonarray = JsonSerializer.Serialize(people);
            using (StreamWriter writer = new StreamWriter("peoplelist.json")) {
                writer.Write(jsonarray);
            }
            using (StreamReader reader = new StreamReader("peoplelist.json")) {
                string jsonstring = reader.ReadToEnd();
                List<Entry> peoplelist= JsonSerializer.Deserialize<List<Entry>>(jsonstring);
                Console.WriteLine(peoplelist[1].Age);
            }
        }
    }
}