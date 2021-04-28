using System;
public class Cat
{
    public Cat()               //Constructor
    {
        instances++;
    }
    public static void HowManyCats()             
    {
        //Console.WriteLine("{0} cats adopted", instances);
        Console.WriteLine($"{Cat.instances} cats adopted");
    }
    private static int instances = 0;
}
public class Cats
{
    static void Main()
    {
        Cat.HowManyCats();
        Cat frisky = new Cat();
        Cat.HowManyCats();
        Cat whiskers = new Cat();
        Cat.HowManyCats();
    }
}