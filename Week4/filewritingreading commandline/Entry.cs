using System.Text.Json;

namespace FileWritingReading
{
    internal class Entry
    {
        public string name { get; }
        public int Age { get; }
        public string Occupation { get; }

        public Entry(string name, int age, string occupation) {
            this.name = name;
            Age = age;
            Occupation = occupation;
        }

        public void WritetoJson(string filename) {
            string jsonalice = JsonSerializer.Serialize(this);
            using (StreamWriter writer = new StreamWriter(filename)) {
                writer.Write(jsonalice);
            }
        }

        public override String ToString() {
            return name + " " + Age + " " + Occupation;
        }
    }
}
