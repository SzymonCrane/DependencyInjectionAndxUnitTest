using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTest
{
    public interface IMessageWriter
    {
        void Write(string message);
        string GetText(string message);
    }
}
