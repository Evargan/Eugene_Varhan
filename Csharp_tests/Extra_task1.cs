namespace Csharp_tests
{
    public class Extra_test_1
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(nextBigger(111), -1);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(nextBigger(513), 531);
        }

        public int nextBigger(int n)
        {
            var num = string.Concat(n.ToString().OrderByDescending(i => i));

            if (num == n.ToString()) return -1;
            do
            {
                n++;
            } while (string.Concat(n.ToString().OrderByDescending(i => i)) != num);

            return n;
        }
    }
}