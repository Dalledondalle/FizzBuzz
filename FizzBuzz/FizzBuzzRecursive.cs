using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzzRecursive
    {
        const string fizz = "Fizz";
        const string buzz = "Buzz";
        public void Play(int countTo)
        {
            _Play(countTo + 1);
        }

        public void Play()
        {
            Play(100);
        }

        private void _Play(int n)
        {
            if (n > 0) _Play(--n);

            if (n == 0) return;

            if (n % (3 * 5) == 0)
            {
                Console.WriteLine(fizz + buzz);
                return;
            }
            if (n % 3 == 0)
            {
                Console.WriteLine(fizz);
                return;
            }
            if (n % 5 == 0)
            {
                Console.WriteLine(buzz);
                return;
            }
            Console.WriteLine(n);
        }
    }
}
