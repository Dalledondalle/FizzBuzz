using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzzLINQ
    {
        const string fizz = "Fizz";
        const string buzz = "Buzz";
        public void Play(int countTo)
        {
            var enumerable = Enumerable.Range(1, countTo).Select(n =>
            {
                if (n % 3 == 0)
                {
                    return n % 5 == 0 ? fizz + buzz : fizz;
                }
                return n % 5 == 0 ? buzz : n.ToString();
            });
            foreach (var item in enumerable)
            {
                Console.WriteLine(item);
            }
        }

        public void Play()
        {
            Play(100);
        }
    }
}
