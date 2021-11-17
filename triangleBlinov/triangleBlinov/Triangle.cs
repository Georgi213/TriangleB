using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleBlinov
{
    class Triangle
    {
        private double a,b,c,h;
        private string type;
        private bool right;
        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public Triangle(double A, double H, string Type, bool Right)
        {
            a = A;
            h = H;
            type = Type;
            right = Right;
        }
        public Triangle() { }
        public double Perimeter()
        {
            if (a != 0.0 && b != 0.0 && c != 0.0) return a + b + c;
            else if (a != 0.0 && h != 0.0 && right) return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(h, 2)) + a + h;
            else if (a != 0.0 && type == "ravno") return Math.Pow(a, 3);
            else return 0.0;
        }
        public double Area()
        {
            if (h != 0.0)
            {
                return (a * h) / 2;
            }
            else if (a != 0 && b != 0 && c != 0)
            {
                double p = Perimeter() / 2;
                return Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            }
            
            else return 0.0;
        }
        public string getA()
        {
            return Convert.ToString(a);
        }
        public string getB()
        {
            return Convert.ToString(b);
        }
        public string getC()
        {
            return Convert.ToString(c);
        }
        public string getH()
        {
            return Convert.ToString(h);
        }
        public bool RealityCheck()
        {
            return (a < b + c) && (b < c + a) && (c < b + a);
        }
        public double Height()
        {
            return (Area() * 2) / a;
        }
        public string typeDef()
        {
            if (a == b && b == c && c == a) return "Равносторонний";
            else if (a == b || a == c || c == b) return "Равнобедренный";
            else return "Разносторонний";
        }
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double H { get; set; }
       /* public double Alpha { get; set; }
        public double Beta { get; set; }
        public double Gamma { get; set; }*/
        public bool Right { get; set; }
        public bool Ravnostoronnij { get; set; }
        public bool Raznostoronnij { get; set; }
        public bool Ravnobedrenniy{ get; set; }

    }
}
