using System;

namespace DependencyInjectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker(new MessageWriterDataBase());
            worker.DoSomething("Wiadomość");


        }
    }
}
