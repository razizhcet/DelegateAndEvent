using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DelegatesAndEvents;
namespace TestCaseClass
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test1()
        {
            DelegateClass dc = new DelegateClass();
            calculator c1 = new calculator(dc.add);
            calculator c2 = new calculator(dc.multiply);
            c1(20);
            Assert.AreEqual(dc.getNum(), 120);
            c2(3);
            Assert.AreEqual(dc.getNum(), 360);
        }
    }
}
