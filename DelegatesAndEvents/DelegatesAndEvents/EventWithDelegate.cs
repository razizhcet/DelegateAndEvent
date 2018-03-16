using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    /// <summary>
    /// delegate to refer add and multiply functions.
    /// </summary>
    /// <param name="x">parameter x is int type.</param>
    /// <returns>return type is int</returns>
    public delegate void Transformer(int x);

    /// <summary>
    /// class describing methods which will be refferes through delegate and event
    /// </summary>
    public class EventWithDelegate
    {
        /// <summary>
        /// statement for using functions of log4net
        /// </summary>
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(EventWithDelegate));

        /// <summary>
        /// method to square a given int type value
        /// </summary>
        /// <param name="x">x is int type parameter.</param>
        /// <returns>return type is void</returns>
        public void Square(int x)
        {
            Console.WriteLine("square is : " + (x * x));
            log.Info("square is : " + (x * x));
        }

        /// <summary>
        /// method to cube a given int type value
        /// </summary>
        /// <param name="x">x is int type parameter.</param>
        /// <returns>return type is void</returns>
        public void Cuber(int x)
        {
            Console.WriteLine("cube is : " + (x * x * x));
            log.Info("cube is : " + (x * x * x));
        }

        /// <summary>
        /// main method for rference of methods through delegate and using event
        /// </summary>
        /// <param name="args">string array type parameter.</param>
        /// <returns>return type is void.</returns>
        static void Main(string[] args)
        {
            EventWithDelegate ewd = new EventWithDelegate();
            Console.WriteLine("Please enter a number:");
            int i = Convert.ToInt32(Console.ReadLine());
            Transformer t;
            t = ewd.Square;
            t += ewd.Cuber;
            t.Invoke(i);

            NotificationMethods obj = new NotificationMethods();

            obj.transformerEvent += User1.Xhandler; //subscribe of event
            obj.transformerEvent += User2.Yhandler; //un-subscribe of event

            obj.NotifyOnCell(i);

            Console.ReadKey();
        }
    }

    /// <summary>
    /// class describing methods to notify users
    /// </summary>
    public class NotificationMethods
    {
        /// <summary>
        /// statement for using functions of log4net
        /// </summary>
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(NotificationMethods));

        /// <summary>
        /// event to to notify diffrent users at same time.
        /// </summary>
        /// <returns>return type is delegate type</returns>
        public event Transformer transformerEvent;

        /// <summary>
        /// method to notify users
        /// </summary>
        /// <param name="x">x is int type parameter.</param>
        /// <returns>return type is void</returns>
        public void NotifyOnCell(int x)
        {
            if(transformerEvent != null)
            {
                transformerEvent(x);
            }
        }
    }

    /// <summary>
    /// class to send a notification to user1
    /// </summary>
    public class User1
    {
        /// <summary>
        /// statement for using functions of log4net
        /// </summary>
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(User1));

        /// <summary>
        /// method to send notification to user
        /// </summary>
        /// <param name="x">x is int type parameter.</param>
        /// <returns>return type is void</returns>
        public static void Xhandler(int x)
        {
            Console.WriteLine("User1 notification received");
            log.Info("User1 notification received");
        }
    }

    /// <summary>
    /// class to send a notification to user2
    /// </summary>
    public class User2
    {
        /// <summary>
        /// statement for using functions of log4net
        /// </summary>
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(User2));

        /// <summary>
        /// method to send notification to user
        /// </summary>
        /// <param name="x">x is int type parameter.</param>
        /// <returns>return type is void</returns>
        public static void Yhandler(int x)
        {
            Console.WriteLine("User2 notification received");
            log.Info("User2 notification received");
        }
    }
}
