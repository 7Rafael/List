using System;
namespace Times
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime t = new DateTime(2022, 2, 3, 5, 7, 11,DateTimeKind.Local);
            Console.WriteLine(t);
        }
    }
}