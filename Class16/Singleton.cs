using System;
using System.Collections.Generic;
using System.Text;

namespace Class16
{
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton()
        {

        }

        public static Singleton Instance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}
