using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDistanceCalculator
{
    public class MyMath
    {

        public int Sum(int[] data)
        {
            int result = 0;
            foreach (int item in data)
            {
                result = result + item;
            }
            return result;
        }

        public double SumDouble(double[] data)
        {
            double result = 0;
            foreach (double item in data)
            {
                result = result + item;
            }
            return result;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public double SubtractionDouble(double a, double b)
        {
            return a - b;
        }

        public int Multiply(int[] numbers)
        {
            int result = 1;

            foreach (int item in numbers)
            {
                result = result * item;
            }

            return result;
        }

        public double MultiplyDouble(double[] numbers)
        {
            double result = 1;

            foreach (double item in numbers)
            {
                result = result * item;
            }

            return result;
        }


        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new ArgumentException("Not divide for 0");
            return a / b;
        }

        public double DivideDouble(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("Not divide for 0");
            return a / b;
        }



        public int CalcChange(int a, int b)
        {
            return a % b;
        }

        public int ElevA(int a, int b)
        {
            return Convert.ToInt32(Math.Pow(a, b));
        }

        public double ElevDouble(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double CalcSqrt(double number)
        {
            return Math.Round(Math.Sqrt(number), 2);
        }

    }
}
