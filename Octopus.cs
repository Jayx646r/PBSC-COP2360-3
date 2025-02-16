using System;

public class Octopus 
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Octopus(string name, int age)
    {
        Name = name;
        Age = age;
    }

        // Method to display information regarding the Octopus
        public void DisplayInfo()
        {
            Console.WriteLine($"Good Evening, my name is {Name} and i am {Age} years old.");
        }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Octopus Class
        Octopus octopus = new Octopus("Jacoby", 24);

        // Display the information regarding the Octopus 
        octopus.DisplayInfo();
    }
}
