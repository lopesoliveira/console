using System;

namespace Console
{
    class Number
    {
        public  Random num = new Random();

        public int GetRandomNumber()
        {
            return num.Next(1, 1);
        }
    }
}
