using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact] 
        public void Test1()
        {
            
        }

        [Theory] 
        [InlineData("Tekst")]
        public void Test2(string name)
        {

        }
    }
}
