using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soluations
{
    public static class Kata
    {

        public static int[] Capitals(string word)
        {
            //Write your code here
            List<int> result = new List<int>();
            for (int i = 0; i < word.Length; i++)
            {
                if (isUpper(word[i]))
                    result.Add(i);
            }
            return result.ToArray();
        }
        public static bool isUpper(char value)
        {
            return value == Convert.ToChar(value.ToString().ToUpper());
        }
        public static int[] UniqueNumbers(int[] numbers)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if(isUnique(numbers, numbers[i]))
                    result.Add(numbers[i]);
            }
            
            return result.ToArray();
        }
        public static bool isUnique(int[] arr, int value)
        {
            //1 1 1 2 1 1 
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == value)
                    counter++;
            }

            return counter == 1;

        }
        public static double[] array_root(double[] arr)
        {
            // write your code here
            double[] sqrt = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                sqrt[i] = Math.Sqrt(arr[i]);
            }

            return sqrt;
        }
        public static string Add_Hashtag(string[] my_array)
        {
            //StringBuilder stringBuilder = new StringBuilder();

            //for (int i = 0; i < my_array.Length; i++)
            //{
            //    if (i == my_array.Length - 1)
            //    {
            //        stringBuilder.Append("#" + my_array[i].ToString());
            //        break;
            //    }

            //    stringBuilder.Append("#" + my_array[i].ToString() + " ");

            //}

            //return stringBuilder.ToString();
            return "#"+string.Join(" #", my_array);
        }
        public static char? First_Recuuring_Char(string characters)
        {

            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            
            for (int i = 0; i < characters.Length; i++)
            {
                keyValuePairs.Add(characters[i], i);
            }

            for (int i = 0; i < characters.Length; i++)
            {
                if (keyValuePairs[characters[i]] >= 2)
                    return Convert.ToChar( keyValuePairs[characters[i]]);
            }

            return null;
        }
        public static int[] Dublcate_values(int[] numbers)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (numbers[i] == numbers[j])
                    {
                        if(!result.Contains(numbers[i]))
                        result.Add(numbers[i]);
                    }
                }
            }
            return result.ToArray();
        }
        public static int[] Remove_repeated_numbers(int[] numbers)
        {
            List<int> result = new List<int>();
                                           
            foreach (var item in numbers)
            {
                result.Add(item);
            }

            for (int i = 0; i < result.Count; i++)
            {
                
                for (int j = 0; j < result.Count; j++)
                {
                    if (i == j)
                        continue;
                    if(numbers[i] == numbers[j])
                    {
                        result.RemoveAt(j);
                    }
                }
            }
            return result.ToArray();
        }
        public static int Octal_To_Decimal(int n)
        {
            int result = 0;

            char[] numbers = n.ToString().ToCharArray();
            try
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    //result += Convert.ToInt32(Math.Pow(8, i)) * (Convert.ToInt32(numbers[(numbers.Length-1) - i]) - 48);
                    result += Convert.ToInt32(Math.Pow(8, i)) * Convert.ToInt32(char.GetNumericValue(numbers[numbers.Length - 1 - i]));
                }

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }

        }
        public static string[] match(string[] words, string text)
        {
            List<string> result = new List<string>();
            string newText = text[0].ToString().ToUpper() + text[1].ToString();
            foreach (string word in words)
            {
                if (word.StartsWith(newText) || word.StartsWith(text))
                {
                    result.Add(word);
                }
            }
            return result.Count == 0 ? new string[] { "No matches found" } : result.ToArray();
        }
        public static bool matchArray(string[] array1, string[] array2)
        {
            bool isEqual = false;


            //case one
            if (array1.Length != array2.Length)
                return isEqual;

            //case Two
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    isEqual = false;
                    break;
                }
            }

            array2 = array2.Reverse().ToArray();

            //Case Three
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    isEqual = false;
                    break;
                }
            }

            return isEqual ? false : true;
        }
    }
}
