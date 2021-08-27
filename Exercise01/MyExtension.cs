using System;

namespace Exercise01
{
    public static class MyExtension
    {
        private static string[] ones = {"zero","one","two","three","four","five","six","seven",
                                        "eight","nine","ten","eleven","twelve","thirteen","fourteen","fifteen",
                                        "sixteen","seventeen","eighteen","ninteen"};
        private static string[] tens = {"","", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        public static string ToWords(this long number)
        {
            if (number < 20)
                return ones[number];
            if (number < 100) //99
                return tens[number / 10] + " " + ((number % 10>0) ? ToWords(number % 10) : "");
            if (number < 1000) //999
                return ones[number / 100] + " hundred " + ((number % 100) > 0 ?" and " + ToWords(number % 100) : "");
            if (number < 100_000) //99_999
                return ToWords(number / 1000) + " thousand " + ((number % 1000) > 0 ? " " + ToWords(number % 1000) : "");
            if (number < 1_000_000) //999_999
                return ToWords(number / 1000) + " thousand " + ((number % 1000) > 0 ? " " + ToWords(number % 1000) : "");
            if (number < 1_000_000_000) //999_999_999
                return ToWords(number / 1_000_000) + " million " + ((number % 1_000_000) > 0 ? " " + ToWords(number % 1_000_000) : "");
            if (number < 1_000_000_000_000) //999_999_999_999
                return ToWords(number / 1_000_000_000) + " billion " + ((number % 1_000_000_000) > 0 ? " " + ToWords(number % 1_000_000_000) : "");
            if (number < 1_000_000_000_000_000) //999_999_999_999_999
                return ToWords(number / 1_000_000_000_000) + " trillion " + ((number % 1_000_000_000_000) > 0 ? " " + ToWords(number % 1_000_000_000_000) : "");
            if (number < 1_000_000_000_000_000_000) //999_999_999_999_999_999
                return ToWords(number / 1_000_000_000_000_000) + " quadrillion " + ((number % 1_000_000_000_000_000) > 0 ? " " + ToWords(number % 1_000_000_000_000_000) : "");
       
            return "value is too large";
        }
        
    }
}
