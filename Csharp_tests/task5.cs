namespace Csharp_tests
{
    public class Test_5
    {
        [Test]
        public void Test1()
        {
            string s = "Eugene:Vargan;Jacob:Vargan;Barney:Holmes;Betty:Holmes;Bjon:Tornbull;Leonardo:Mianman;Mbappe:Kilian";
            Assert.AreEqual(meeting(s), "(HOLMES, BARNEY)(HOLMES, BETTY)(KILIAN, MBAPPE)(MIANMAN, LEONARDO)(TORNBULL, BJON)(VARGAN, EUGENE)(VARGAN, JACOB)");
        }

        [Test]
        public void Test2()
        {
            string s = "Fred:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
            Assert.AreEqual(meeting(s),"(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)");
        }

        public string meeting(string str)
        {
            return string.Concat(str.ToUpper().Split(";").Select(x => $"({string.Join(", ", x.Split(':').Reverse())})").OrderBy(f => f));
        }
    }
}