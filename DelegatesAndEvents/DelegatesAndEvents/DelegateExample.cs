using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    /// <summary>
    /// class describing methods which will be refferes through delegate
    /// </summary>
   public  class DelegateClass
    {
        /// <summary>
        /// num is a static int value is 100
        /// </summary>
        static int num = 100;
        /// <summary>
        /// method to add a given value to num
        /// </summary>
        /// <param name="n">n is int type parameter.</param>
        /// <returns>return type is int</returns>
        public int add(int n)
        {
            num = num + n;
            return num;
        }
        /// <summary>
        /// method to multiply a given value to num
        /// </summary>
        /// <param name="n">n is int type parameter.</param>
        /// <returns>return type is int</returns>
        public int multiply(int n)
        {
            num = num * n;
            return num;
        }
        /// <summary>
        /// method to find the result of add and multiply method
        /// </summary>
        /// <returns>return type is int</returns>
        public int getNum()
        {
            return num;
        }
    }
    /// <summary>
    /// delegate to refer add and multiply functions.
    /// </summary>
    /// <param name="n">parameter n is int type.</param>
    /// <returns>return type is int</returns>
    public delegate int calculator(int n);
    /// <summary>
    /// class for instantiating the delegate and refering the functions through delegate
    /// </summary>
    public class DelegateExample
    {
        /// <summary>
        /// statement for using functions of log4net
        /// </summary>
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(DelegateClass));
        /// <summary>
        /// main method for rference of methods through delegates
        /// </summary>
        /// <param name="args">string array type parameter.</param>
        /// <returns>return type is void.</returns>
        static void Main(string[] args)
        {
            DelegateClass dc = new DelegateClass();
            calculator c1 = new calculator(dc.add);
            calculator c2 = new calculator(dc.multiply);
            c1(20);
            log.Info("After c1 delegate, Number is: " + dc.getNum());
            c2(3);
            log.Info("After c2 delegate, Number is: " + dc.getNum());
            Console.ReadKey();
        }
    }
}
