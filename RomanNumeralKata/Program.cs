using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralKata
{
    class Program
    {
        static readonly RomanNumeral _roman = new RomanNumeral();

        static void Main(string[] args)
        {
            Console.WriteLine("Converting Arabic numerals to Roman numerals:");
            ConvertToRoman(-1);
            ConvertToRoman(4321);
            ConvertToRoman(1);
            ConvertToRoman(3);
            ConvertToRoman(9);
            ConvertToRoman(1066);
            ConvertToRoman(1989);
            ConvertToRoman(2016);
            ConvertToRoman(3888);

            Console.WriteLine();
            Console.WriteLine("Press Return/Enter to continue");

            Console.ReadLine();
        }

        static void ConvertToRoman(int numberToConvert)
        {
            try
            {
                Console.WriteLine("{0} => {1}", numberToConvert, _roman.ToRoman(numberToConvert));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("{0} => conversion failed, number is outside the range of numbers that can be converted", numberToConvert);
            }
        }
    }
}
