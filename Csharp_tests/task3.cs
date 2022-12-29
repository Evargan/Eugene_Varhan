namespace Csharp_tests
{
    public class Test_3
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(digital_root(493193), 2);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(digital_root(942), 6);
        }

        public int digital_root(int n)
        {
            string number = n.ToString();
            int res = 0;
            while (number.Length > 1)
            {
                res = 0;
                for (int i = 0; i < number.Length; i ++)
                {
                    res += int.Parse(number[i].ToString());
                }
                number = res.ToString();
            }
            return res;
        }
    }
}