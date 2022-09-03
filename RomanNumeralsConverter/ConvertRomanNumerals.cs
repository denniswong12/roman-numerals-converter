namespace RomanNumeralsConverter
{
    class ConvertRomanNumerals
    {
        private static Dictionary<string, int> RomanDict = new Dictionary<string, int>()
        {
            {"I", 1},
            {"IV", 4},
            {"V", 5},
            {"IX", 9},
            {"X", 10},
            {"XL", 40},
            {"L", 50},
            {"XC", 90},
            {"C", 100},
            {"CD", 400},
            {"D", 500},
            {"CM", 900},
            {"M", 1000}
        };

        //Method to map the input string to the RomanDict dictionary and return the mapped value, return 0 if can't map.
        private int MatchRomanToDict(string romanToMatchDict)
        {
            const int notExist = 0;
            foreach (var item in RomanDict)
            {
                if (romanToMatchDict == item.Key)
                    return item.Value;
            }

            return notExist;
        }

        public void ConvertRomanNum()
        {
            Console.WriteLine("Please enter a Roman Numeral");
            var romanNum = Console.ReadLine();

            if (romanNum != null && romanNum != "")
            {
                const int comparisonStringSize = 2;
                int number = 0;
                int shiftIndex = 0;
                bool validRomanNum = true;
                char[] FirstRomanToMatchDict = new char[comparisonStringSize];
                char[] SecRomanToMatchDict = new char[comparisonStringSize];
                char[] romanNumArr = romanNum.ToCharArray();

                //check input is a valid Roman Numerals or not
                for (int i = 0; i < romanNum.Length; i++)
                    if (MatchRomanToDict(Char.ToString(romanNum[i])) == 0)
                        validRomanNum = false;

                if (validRomanNum)
                {
                    for (int i = 0; i < romanNum.Length; i++)
                    {
                        //empty string array to store roman numeral to compare with RomanDict
                        Array.Clear(FirstRomanToMatchDict, 0, FirstRomanToMatchDict.Length);
                        Array.Clear(SecRomanToMatchDict, 0, SecRomanToMatchDict.Length);

                        //store the [i] character to first compare string
                        FirstRomanToMatchDict[0] = romanNumArr[i];

                        //if not the end of the input roman numeral, store the [i+1] character to the comparison strings
                        if (i+1 < romanNum.Length)
                        {
                            FirstRomanToMatchDict[1] = romanNumArr[i+1];
                            SecRomanToMatchDict[0] = romanNumArr[i+1];
                        }

                        //if not the end of the input roman numeral, store the [i+2] character to the 2nd digit of the 2nd comparison string
                        if (i+2 < romanNum.Length)
                            SecRomanToMatchDict[1] = romanNumArr[i+2];

                        //try to get the value of each comparison string
                        int FirstRomanDictValue = MatchRomanToDict(new string(FirstRomanToMatchDict));
                        int SecRomanDictValue = MatchRomanToDict(new string(SecRomanToMatchDict));

                        if (FirstRomanDictValue > 0) //first comparison string representing a value
                        {
                            number += FirstRomanDictValue;
                            shiftIndex = 1; //1 because handled 2 characters
                            i += shiftIndex; 
                        }
                        else if (SecRomanDictValue > 0) //second comparison string representing a value
                        {
                            number += MatchRomanToDict(Char.ToString(FirstRomanToMatchDict[0])) + SecRomanDictValue;
                            shiftIndex = 2; //2 because handled 3 characters
                            i += shiftIndex;
                        }
                        else //all 3 characters doesn't combine to represent a value, add the first 2 values
                        {
                            number += MatchRomanToDict(Char.ToString(FirstRomanToMatchDict[0])) + MatchRomanToDict(Char.ToString(FirstRomanToMatchDict[1]));
                            shiftIndex = 1; //1 because handled 2 characters
                            i += shiftIndex;
                        }
                    }

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

