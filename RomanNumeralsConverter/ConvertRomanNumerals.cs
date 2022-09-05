using NUnit.Framework.Interfaces;

namespace RomanNumeralsConverter
{
    class ConvertRomanNumerals
    {
        const int NotExist = 0;

        private static Dictionary<char, int> RomanDict = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        //Compare the input char with RomanDict and return the mapped value, return "NotExist" if can't map.
        private int MatchRomanToDict(char romanToMatchDict)
        {
            foreach (var item in RomanDict)
            {
                if (romanToMatchDict == item.Key)
                    return item.Value;
            }

            return NotExist;
        }

        public void ConvertRomanNum()
        {
            Console.WriteLine("Please enter a Roman Numeral");
            var romanNum = Console.ReadLine();

            if (romanNum != null && romanNum != "")
            {
                var number = 0;
                var validRomanNum = true;
                romanNum = romanNum.ToUpper();
                char[] romanNumArr = romanNum.ToCharArray();

                for (int i = 0; i < romanNum.Length; i++)
                {
                    var romanToNum = MatchRomanToDict(romanNum[i]);
                    if (romanToNum == NotExist) //check input is a valid Roman Numerals or not.
                        validRomanNum = false;
                    else
                        number += romanToNum; //sum up all Roman numerals as a total number.
                }

                if (validRomanNum)
                {
                    //deduct difference from total in existance of the following combinations
                    if (romanNum.Contains("IV") || romanNum.Contains("IX"))
                        number -= 2;

                    if (romanNum.Contains("XL") || romanNum.Contains("XC"))
                        number -= 20;

                    if (romanNum.Contains("CD") || romanNum.Contains("CM"))
                        number -= 200;

                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine("Invalid Roman Numerals.");
                }
            }
            else
            {
                Console.WriteLine("Roman Numeral can not be empty.");
            }
        }
    }
}

