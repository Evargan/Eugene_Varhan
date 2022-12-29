namespace Csharp_tests
{
    public class Test_4
    {
        [Test]
        public void Test1()
        {
            int[] arr = { 1, 3, 6, 2, 2, 0, 4, 5 };
            Assert.AreEqual(Number_of_pairs(arr, 5), 4);
        }

        [Test]
        public void Test2()
        {
            int[] arr = { 1, 3, 6, 2, 2, 0, 4, 5 };
            Assert.AreEqual(Number_of_pairs(arr, 8), 3);
        }

        public int Number_of_pairs(int[] arr, int sum)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if ((arr[i] + arr[j]) == sum)
                        count++;
            return count;
        }
    }
}