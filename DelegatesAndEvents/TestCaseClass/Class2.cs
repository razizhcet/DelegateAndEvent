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
    public class Class2
    {
        [Test]
        public void Test1()
        {
            Delegates del = new Delegates();
            mcDelegate md = new mcDelegate(del.add);

            md += del.sub;
            md += del.mul;
            md += del.div;
            md(20, 10);

            md -= del.mul;
            md -= del.div;
            md(30, 40);
        }
    }
}

