namespace Task3Test
{
    using TasksLibrary;

    class Program
    {
        static void Main(string[] args)
        {
            var counter = new Counter();

            var person1 = new Person("Bob");
            var person2 = new Person("Emma");

            counter.onTimeOver += person1.PrintMessage;
            counter.onTimeOver += person2.PrintMessage;

            counter.CountDown(3, "Hello");
        }
    }
}
