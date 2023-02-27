using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzzSingle
    {
        string[] array;
        const string fizz = "Fizz";
        const string buzz = "Buzz";
        public void Play(int countTo)
        {
            for (int i = 1; i < countTo + 1; i++)
            {
                if (i % (3 * 5) == 0)
                {
                    Console.WriteLine(fizz + buzz);
                    continue;
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine(fizz);
                    continue;
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine(buzz);
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        private void PlayArray(int countTo)
        {
            for (int i = 1; i < countTo + 1; i++)
            {
                if (i % (3 * 5) == 0)
                {
                    array[i-1] = fizz + buzz;
                    continue;
                }
                if (i % 3 == 0)
                {
                    array[i-1] = fizz;
                    continue;
                }
                if (i % 5 == 0)
                {
                    array[i-1] = buzz;
                    continue;
                }
                array[i-1] = i.ToString();
            }
        }

        public void Play()
        {
            Play(100);
        }

        public void Play(bool ToArray, int countTo = 100)
        {
            if (ToArray)
            {
                array = new string[countTo];
                PlayArray(countTo);
                return;
            }
            Play(countTo);
        }
    }
}
