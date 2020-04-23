using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetThirdlab
{
    class Vectors : Point
    {
        private Point a;
        private Point b;
        private Point c;

        public Vectors(Point v1, Point v2)
        {
            a = new Point();
            b = new Point();

            a = v1;
            b = v2;
        }
        public string ReturnVectors()
        {
            string result = "";
            result = "a" + a.ToString() + "\nb" + b.ToString();
            return result;
        }

        public string Calculate()
        {
            string result = "c";
            c = new Point();
            c = (a.Addition(a)).ProductV(b);

            return result + c.ToString();
        }

        public string IsCollinearity()
        {
            string result = "нет.";
            if (a.IsCollinearity(b))
                result = "да.";
            return result;
        }
    }
}
