using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzzSwitchCase
    {
        const string fizz = "Fizz";
        const string buzz = "Buzz";
        public void Play(int countTo)
        {
            for (int i = 0; i < countTo + 1; i++)
            {
                switch (i % 15)
                {
                    case 0:
                        Console.WriteLine(fizz + buzz);
                        break;
                    case 3:
                    case 6:
                    case 9:
                    case 12:
                        Console.WriteLine(fizz);
                        break;
                    case 5:
                    case 10:
                        Console.WriteLine(buzz);
                        break;
                    default:
                        Console.WriteLine(i);
                        break;
                }
            }
        }

        public void Play()
        {
            Play(100);
        }
    }
}
