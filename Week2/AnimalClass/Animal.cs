namespace AnimalClass
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age {  get; set; }

        public Animal(string name, int age) {
            Name = name;
            Age = age;
        }

        public virtual void Sound() {
            Console.WriteLine("This animal makes a sound.");
        }
    }
}
