namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
            Clothes a = new Clothes("blue");
            Shirt b = new Shirt("red", true);
            Console.WriteLine(a.WhatType());
            Console.WriteLine(b.WhatType());
            Console.WriteLine(b);
            Console.WriteLine(a);

        }
    }
}
