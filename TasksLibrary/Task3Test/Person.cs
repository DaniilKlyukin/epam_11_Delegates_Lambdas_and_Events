namespace Task3Test
{
    using System;
    using TasksLibrary;

    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void PrintMessage(object sender, CounterEventArgs e)
        {
            Console.WriteLine($"{Name}: {e.Message}");
        }
    }
}
