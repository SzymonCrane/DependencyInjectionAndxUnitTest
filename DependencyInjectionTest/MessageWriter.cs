using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTest
{
    public class MessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.Write(message+" This is message writer");
        }
    }
}
