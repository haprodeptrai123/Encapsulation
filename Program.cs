using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Rectangle
    {
        double _length;
        double _width;
        // A method should have a boundary condition (a limit on the range 
        // of arguments for which a method operate properly).
        public void Set(double length, double width)
        {
            _length = length;
            _width = width;
        }
        double Get()
        {
            return _length * _width;
        }
        // All attributes, behaviors should only be accessed via the method.
        public void Display()
        {
            Console.WriteLine("The length is : {0}", _length);
            Console.WriteLine("The width is : {0}", _width);
            Console.WriteLine("The area is : {0}", Get());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encapsulation in C#");
            Console.WriteLine("----------------------");
            // Create a rectangle object
            Rectangle r = new Rectangle();
            // Set data fields
            r.Set(4.5, 3.5);
            // Call the method and display the result
            r.Display();
            Console.ReadKey();
        }
    }
}
