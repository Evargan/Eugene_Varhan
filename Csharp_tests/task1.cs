namespace Csharp_tests
{
    public class Test_1
    {
        [Test]
        public void Test1()
        {
            List<object> list1 = new List<object>() { 1, 2, 'a', "bca" };
            List<object> list2 = new List<object>() { 1, 2};
            CollectionAssert.AreEqual(GetIntegersFromList(list1), list2);
        }

        [Test]
        public void Test2()
        {
            List<object> list1 = new List<object>() { 1, 2, 3, "sdfsd", "sdfsdfsd" };
            List<object> list2 = new List<object>() { 1, 2, 3 };
            CollectionAssert.AreEqual(GetIntegersFromList(list1), list2);
        }

        public List<object> GetIntegersFromList(List<object> list)
        {
            list.RemoveAll(i => i is string or char);
            return list;
        }
    }
}