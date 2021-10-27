using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTest
{
    public class Worker
    {
        private readonly IMessageWriter messageWriter;

        public Worker(IMessageWriter writer)
        {
            messageWriter = writer;
        }
        public void DoSomething(string message)
        {
            messageWriter.Write(message);
        }
        
    }
}
