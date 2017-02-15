using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExamples
{
    class Beregn
    {
        public static int tal1Static { get; set; }
        public const int tal1Const = 1000;
        public int tal1 { get; set; }
        public static int gangeStatic (int a, int b) // Klassemetode
        {
            return a * b;
        }

        public int gange (int a, int b) // Instansmetode
        {
            return a * b;
        }
    }
}
