using System;

namespace TriagleTest
{
    public class MainForm
    {
        public string ShowTypeTriagle(int a, int b, int c)
        {

            if (a == b && b == c)
            {
                return "Треугольник является равносторонним";
            }
            if (a == b || b == c || a == c)
            {
                return "Треугольник является равнобедренным";
            }
            else
            {
                return "Треугольник является разносторонним";
            }

        }
        static void Main(string[] args)
        {
        }
    }
}
 