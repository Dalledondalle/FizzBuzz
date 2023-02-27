using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzzMultiThread
    {
        string[] array;
        const string fizz = "Fizz";
        const string buzz = "Buzz";
        public void Play(int countTo)
        {
            Thread[] threads = new Thread[5];
            threads[0] = new Thread(() => DoTheThing(1, countTo / 5));
            threads[1] = new Thread(() => DoTheThing((countTo / 5) + 1, (countTo / 5) * 2));
            threads[2] = new Thread(() => DoTheThing(((countTo / 5) * 2) + 1, ((countTo / 5) * 3)));
            threads[3] = new Thread(() => DoTheThing(((countTo / 5) * 3) + 1, ((countTo / 5) * 4)));
            threads[4] = new Thread(() => DoTheThing(((countTo / 5) * 4) + 1, countTo));

            foreach (var item in threads)
            {
                item.IsBackground = true;
                item.Start();
            }
        }

        private void PlayArray(int countTo)
        {
            Thread[] threads = new Thread[5];
            threads[0] = new Thread(() => DoTheArrayThing(1, countTo / 5));
            threads[1] = new Thread(() => DoTheArrayThing((countTo / 5) + 1, (countTo / 5) * 2));
            threads[2] = new Thread(() => DoTheArrayThing(((countTo / 5) * 2) + 1, ((countTo / 5) * 3)));
            threads[3] = new Thread(() => DoTheArrayThing(((countTo / 5) * 3) + 1, ((countTo / 5) * 4)));
            threads[4] = new Thread(() => DoTheArrayThing(((countTo / 5) * 4) + 1, countTo));

            foreach (var item in threads)
            {
                item.Start();
            }            
        }

        private void DoTheThing(int from, int to)
        {
            for (int i = from; i < to + 1; i++)
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

        private void DoTheArrayThing(int from, int to)
        {
            for (int i = from; i < to + 1; i++)
            {
                if (i % (3 * 5) == 0)
                {
                    array[i - 1] = fizz + buzz;
                    continue;
                }
                if (i % 3 == 0)
                {
                    array[i - 1] = fizz;
                    continue;
                }
                if (i % 5 == 0)
                {
                    array[i - 1] = buzz;
                    continue;
                }
                array[i - 1] = i.ToString();
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
