using System;

namespace _004_面向对象
{
    class Vector3
    {
        private double x;
        private double y;
        private double z;

        public void SetX(double temp)
        {
            if (temp < 0)
            {
                return;
            }
            x = temp;
        }
        public void SetY(double temp)
        {
            if (temp < 0)
            {
                return;
            }
            y = temp;
        }
        public void SetZ(double temp)
        {
            if (temp < 0)
            {
                return;
            }
            z = temp;
        }
        public double GetX(double temp)
        {
            return x;
        }
        public double GetY(double temp)
        {
            return y;
        }
        public double GetZ(double temp)
        {
            return z;
        }

        public double Distance()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
    }
}
