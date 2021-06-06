using System;
namespace unit.Controllers
{
    public class MathController
    {
        public int sum (int num1, int num2)
        {
            return (num1 + num2);
        }

        public int sub(int num1, int num2)
        {
            return (num1 - num2);
        }

        public int mult(int num1, int num2)
        {
            num1 += 1;
            
            return (num1 * num2);

        }
    }
}
