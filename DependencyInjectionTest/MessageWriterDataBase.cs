using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTest
{
    public class MessageWriterDataBase : IMessageWriter
    {
        public string GetText(string message)
        {
            throw new NotImplementedException();
        }

        public void Write(string message)
        {
            Console.WriteLine(message + " This is message writer database");
        }
    }
}
