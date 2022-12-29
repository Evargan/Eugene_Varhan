using System.Globalization;

namespace Csharp_tests
{
    public class Test_2
    {

        [Test]
        public void Test1()
        {
            string str1 = "Avddfgavfg";
            string str2 = "None";
            Assert.AreEqual(first_non_repeating_letter(str1), str2);
        }

        [Test]
        public void Test2()
        {
            string str1 = "Avddfgav";
            string str2 = "f";
            Assert.AreEqual(first_non_repeating_letter(str1),str2);
        }

        public string first_non_repeating_letter(string str)
        {
            string str2 = str.ToLower();
            for (int index = 0; index < str.Length; index++)
            {
                if (str2.LastIndexOf(str2[index]) == str2.IndexOf(str2[index]))
                {
                    return str[str2.IndexOf(str2[index])].ToString();
                }
            }
            return new string("None");
        }
    }
}