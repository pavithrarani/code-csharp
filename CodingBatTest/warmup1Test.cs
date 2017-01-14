using codingBat;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingBatTest
{
    [TestClass]
    public class warmup1Test
    {
        //sleepIn
        [TestMethod]
        public void sleepInShouldReturnTrueIfNotWeekdayNotVacation()
        {
            warmup1 sp = new warmup1();
            bool res = sp.sleep(false, false); // → true
            Assert.AreEqual(res, true);
        }
        [TestMethod]
        public void sleepInShouldReturnTrueIfWeekdayNotVacation()
        {
            warmup1 sp = new warmup1();
            bool res = sp.sleep(true, false); // → false
            Assert.AreEqual(res, false);
        }

        [TestMethod]
        public void sleepInShouldReturnTrueIfNotWeekdayIfVacation()
        {
            warmup1 sp = new warmup1();
            bool res = sp.sleep(false, true); // → true
            Assert.AreEqual(res, true);
        }
        //----monkeyTrouble
        [TestMethod]
        public void inTroubleIfBothMonkeysSmiling()
        {
            //monkeyTrouble(true, true) → true
            warmup1 mt = new warmup1();
            bool res = mt.smile(true, true);
            Assert.AreEqual(res, true);
        }
        [TestMethod]
        public void inTroubleIfBothMonkeysAreNotSmiling()
        {
            //monkeyTrouble(false, false) → true
            warmup1 mt = new warmup1();
            bool res = mt.smile(false, false);
            Assert.AreEqual(res, true);
        }
        [TestMethod]
        public void noTroubleIfEitherOfMonkeysSmiling()
        {
            //monkeyTrouble(true, false) → false
            warmup1 mt = new warmup1();
            bool res = mt.smile(true, false);
            Assert.AreEqual(res, false);
        }
        //--- sumTest
        [TestMethod]
        public void sumWhenNumberNotEqual()
        {
            int n1 = 10, n2 = 11;
            warmup1 obj = new warmup1();
            int res = obj.compute(n1, n2);
            Assert.AreEqual(21, res);

        }
        [TestMethod]
        public void sumWhenNumberEqual()
        {
            int n1 = 10, n2 = 10;
            warmup1 obj = new warmup1();
            int res = obj.compute(n1, n2);
            Assert.AreEqual(40, res);

        }
    }
}
