using System;

namespace HexToDec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Worker worker = new Worker();
            worker.start();
            Console.ReadLine();
        }
    }
}
