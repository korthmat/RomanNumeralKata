using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralKata
{
    class ArabicToRomanConversion
    {
        public ArabicToRomanConversion(int arabic, string roman)
        {
            Arabic = arabic;
            Roman = roman;
        }

        public int Arabic { get; private set; }
        public string Roman { get; private set; }
    }
}
