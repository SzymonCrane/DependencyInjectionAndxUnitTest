using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTest
{
    public class Worker : IWorker
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
        public string GetText(string message)
        {
            return messageWriter.GetText(message) + message;
        }
    }
}
