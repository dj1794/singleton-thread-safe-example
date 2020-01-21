using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonExample
{
    sealed class SingleTon
    {
        private static readonly SingleTon _instance = new SingleTon();
        private static int count = 0;
        static SingleTon()
        {
            count++;
            Console.WriteLine("I am static cunstructor");
        }
        public static SingleTon getInstance
        {
            get
            {
                return _instance;
            }
        }
        private SingleTon()
        {
            count++;
            Console.WriteLine("I am normal cunstructor");
        }
        public void testMethod()
        {
            Console.WriteLine("I am normal method in static class.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var _instance = SingleTon.getInstance;
            var _instance1 = SingleTon.getInstance;
            _instance.testMethod();
            _instance1.testMethod();
            Console.ReadKey();
        }
    }
}
