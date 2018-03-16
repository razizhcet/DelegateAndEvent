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
    public class Class3
    {
        [Test]
        public void Test1()
        {
            EventWithDelegate ewd = new EventWithDelegate();
            int i = 5;
            Transformer t;
            t = ewd.Square;
            t += ewd.Cuber;
            t.Invoke(i);

            NotificationMethods obj = new NotificationMethods();

            obj.transformerEvent += User1.Xhandler; //subscribe of event
            obj.transformerEvent += User2.Yhandler; //un-subscribe of event

            obj.NotifyOnCell(i);
        }
        [Test]
        public void Test2()
        {
            EventWithDelegate ewd = new EventWithDelegate();
            int i = 10;
            Transformer t;
            t = ewd.Square;
            t += ewd.Cuber;
            t.Invoke(i);

            NotificationMethods obj = new NotificationMethods();

            obj.transformerEvent += User1.Xhandler; //subscribe of event
            obj.transformerEvent += User2.Yhandler; //un-subscribe of event

            obj.NotifyOnCell(i);
        }
    }
}
