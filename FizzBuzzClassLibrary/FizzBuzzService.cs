using FizzBuzzClassLibrary.Interfaces;

namespace FizzBuzzClassLibrary
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private Int32 _x;

        private Int32 _y;

        private Int32 _n;

        public Int32 X => _x;

        public Int32 Y => _y;

        public Int32 N => _n;

        public void GetInput(Int32 maxValue)
        {
            if (!(maxValue > 1) || !(maxValue <= 100))
            {
                throw new ArgumentException($"The maximum value ({maxValue}) must be greater than 1 and less than or equal to 100.");
            }

            string input = Console.ReadLine()!;

            string[] inputs = input.Split(' ');

            if (Int32.TryParse(inputs[0], out _x) == false)
            {
                throw new ArgumentException("Invalid input for X.");
            }

            if (Int32.TryParse(inputs[1], out _y) == false)
            {
                throw new ArgumentException("Invalid input for Y.");
            }

            if (Int32.TryParse(inputs[2], out _n) == false)
            {
                throw new ArgumentException("Invalid input for N.");
            }

            if (!(_x >= 1))
            {
                throw new ArgumentException($"X ({_x}) must be greater than or equal to 1.");
            }
            
            if (!(_y > _x) || !(_y <= _n))
            {
                throw new ArgumentException($"Y ({_y}) must be greater than X ({_x}) and less than or equal to N ({_n}).");
            }

            if (!(_n <= maxValue))
            {
                throw new ArgumentException($"N ({_n}) must be less than or equal to the maximum value ({maxValue}).");
            }
        }
    }
}
