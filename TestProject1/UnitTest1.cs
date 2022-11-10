using StudentServiceLib;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void score8_returnA()
        {
            Student a = new Student();
            a.Score = 8;
            char letter = a.getLetterScore();
            Assert.AreEqual('A', letter);

        }

        [TestMethod]
        public void score78_returnB()
        {
            Student a = new Student();
            a.Score = 7.5;
            char letter = a.getLetterScore();
            Assert.AreEqual('B', letter);

        }
        [TestMethod]
        public void ScoreIs57_ReturnLetter_B()
        {
            Student s = new Student();
            s.Score = 6.9;

            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);

        }
        [TestMethod]
        public void ScoreIs35_ReturnLetter_B()
        {
            Student s = new Student();
            s.Score = 4;

            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);

        }
        [TestMethod]
        public void ScoreIsUnder35_ReturnLetter_B()
        {
            Student s = new Student();
            s.Score = 3;

            char letter = s.getLetterScore();
            Assert.AreEqual('E', letter);

        }
    
}

}