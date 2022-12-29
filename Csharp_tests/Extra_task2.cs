using System.Net;

namespace Csharp_tests
{
    public class Extra_test_2
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(Number_to_IP(32), "0.0.0.32");
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(Number_to_IP(2149583361),"128.32.10.1");
        }

        public string Number_to_IP(uint n)
        {
            return $"{IPAddress.Parse($"{n}")}";
        }
    }
}