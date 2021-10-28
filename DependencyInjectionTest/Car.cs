using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTest
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ProductionDate { get; set; }
        public byte SeriesNumber { get; set; }
        public Make Make { get; set; }
    }
}
