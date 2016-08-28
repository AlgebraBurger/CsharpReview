using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpReview
{
    

    class Circle
    {
        static float _PI;
        int _Radius;

        static Circle()
        {
            Console.WriteLine("Static Constructor Called");
            Circle._PI = 3.141F;
        }


        public Circle(int Radius)
        {
            Console.WriteLine("Instance Constructor Called");
            this._Radius = Radius;
        }

        

        public float CalculateArea()
        {
            return Circle._PI * this._Radius * this._Radius;
        }

    }
    public delegate string HelloFunctionDelegate(string Message);
    class Program
    {
        static void Main(string[] args)
        {
            Circle C1 = new Circle(5);
            float Area1 = C1.CalculateArea();            
            Console.WriteLine("Are = {0}", Area1);

            Circle C2 = new Circle(6);
            float Area2 = C2.CalculateArea();
            Console.WriteLine("Are = {0}", Area2);

            HelloFunctionDelegate d = new HelloFunctionDelegate(Hello);
            d("Hello World");

            Console.ReadLine();

        }

        public static string Hello(string strMessage)
        {
            return strMessage;
        }
    }
}
