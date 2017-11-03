using System;

namespace GC_Deliverable10_Lab9_CircleMetrics
{
    class Circle
    {
        //data
        private double radius;
        public static int circCount = 0;

        //constructors
        public Circle (double radius)
        {
            this.radius = radius;
            circCount++;
        }

        //getters
        public double GetRadius ()
        {
            return radius;
        }

        //setters
        public void SetRadius (double radius)
        {
            this.radius = radius;
        }

        //methods
        private string FormatNumber (double x)
        {
            x = (long)(x * 100 + 0.5) / 100.0;
            string str = x.ToString();
            return str;
        }

        public double GetArea ()
        {
            return Math.PI * (radius * radius);
        }

        public double GetCircumference ()
        {
            return Math.PI * radius * 2;
        }

        public string GetFormattedArea ()
        {
            return FormatNumber(GetArea());
        }

        public string GetFormattedCircumference ()
        {
            return FormatNumber(GetCircumference());
        }

        //properties (extended exercise)
    }
}
