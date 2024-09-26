namespace AnimalClass
{
    internal class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog(string name, int age, string breed) : base(name, age) {
            Breed = breed;
        }

        public override void Sound() {
            Console.WriteLine("Woof");
        }

        
    }
}
