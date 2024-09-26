namespace AnimalClass
{
    internal class Cat : Animal
    {
        public string Colour { get; set; }
        public Cat(string name, int age, string colour) : base(name, age) {
            Colour = colour;
        }

        public override void Sound() {
            Console.WriteLine("Meow");
        }
    }
}
