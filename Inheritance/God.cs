using System;

///CODE WARS EXERCISE 2

namespace Inheritance
{

    public class God
    {
        public static Human[] Create()
        {
            return new Human[] { new Man(), new Woman() };
        }

        public class Human
        {
        }

        public class Man : Human
        {
        }
        public class Woman : Human
        {
        }
    }
    
}

