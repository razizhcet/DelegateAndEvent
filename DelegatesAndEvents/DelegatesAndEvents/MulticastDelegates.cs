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
    public class Delegates
    {
        /// <summary>
        /// method to add a given value to num
        /// </summary>
        /// <param name="a">a is int type parameter.</param>
        /// <param name="b">b is int type parameter.</param>
        public void add(int a, int b)
        {
            Console.WriteLine("sum is : " + (a + b));
        }
        public void sub(int a, int b)
        {
            Console.WriteLine("sub is : " + (a - b));
        }
        public void mul(int a, int b)
        {
            Console.WriteLine("prod is : " + (a * b));
        }
        public void div(int a, int b)
        {
            Console.WriteLine("quot is : " + (a / b));
        }
    }
    public delegate void mcDelegate(int i, int j);
    class MulticastDelegates
    {
        static void Main(string[] args)
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
            Console.ReadKey();
        }
    }
}
