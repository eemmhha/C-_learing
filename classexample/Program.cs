using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classexample
{
    class Program
    {
        static void Main(string[] args)
        {
            car myobject = new car();
            myobject.MyProperty = "hi";
            //myobject.MyProperty2 = 55;
            Console.WriteLine("{0} - {1}", myobject.MyProperty, myobject.MyProperty2);
            car myob2 = new classexample.car(2);
            Console.WriteLine(myob2.MyProperty2);
            Console.ReadLine();
        }
    }

    class car
    {
        public string MyProperty { get; set; }//prop then tap tap its a mocron 
        public int MyProperty2 { get; set; }
        public car()
        {
            this.MyProperty2 = 66;
        }
        public car(int x)
        {
            this.MyProperty2 = x;
        }
    }
}
