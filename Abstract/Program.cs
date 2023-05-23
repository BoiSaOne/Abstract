using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var objAbstract = typeof(RuntimeTypeHandle).GetMethod("Allocate", BindingFlags.Static | BindingFlags.NonPublic)
                .Invoke(null, new object[] { typeof(Abstract) });
            Console.WriteLine(objAbstract.GetType());
            Console.ReadLine();
        }
    }

    public abstract class Abstract
    {
    }

}
