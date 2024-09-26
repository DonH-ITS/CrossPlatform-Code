namespace AnimalClass
{
    internal class Program
    {
        static void Main(string[] args) {
            Dog dog1 = new Dog("Buddy", 3, "Golden Retriever");
            Dog dog2 = new Dog("Max", 5, "German Shepherd");

            // Create Cat objects
            Cat cat1 = new Cat("Whiskers", 2, "Black");
            Cat cat2 = new Cat("Luna", 4, "White");

            // Test Dog objects
            Console.WriteLine($"{dog1.Name} is a {dog1.Breed}, Age: {dog1.Age}");
            dog1.Sound();
            Console.WriteLine($"{dog2.Name} is a {dog2.Breed}, Age: {dog2.Age}");
            dog2.Sound();

            // Test Cat objects
            Console.WriteLine($"{cat1.Name} is a {cat1.Colour} cat, Age: {cat1.Age}");
            cat1.Sound();
            Console.WriteLine($"{cat2.Name} is a {cat2.Colour} cat, Age: {cat2.Age}");
            cat2.Sound();

            Animal horse = new Animal("Epona", 2);
            Console.WriteLine($"{horse.Name} is an animal, Age: {horse.Age}");
            horse.Sound();

        }
    }
}
