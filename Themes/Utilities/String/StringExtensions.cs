using System;
using System.Collections.Generic;

namespace REghZyFramework.Utilities.String
{
    /// <summary>
    /// A class i made that provides a bunch of helpful functions for "manipulating" strings
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        ///     Extracts the values (between the text of a and b) within value.
        ///     It returns the first occourance of the values of a and b.
        /// <code>
        ///     Example: "do you have permissions, do you?".Between("you", "ion"); returns " have permiss";
        /// </code>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string Between(this string value, string a, string b)
        {
            try
            {
                int posA = value.IndexOf(a);
                if (posA == -1) return "";

                int posB = value.IndexOf(b, posA);
                if (posB == -1) return "";

                return value.Extract(posA + a.Length, posB);
            }
            catch { return ""; }
        }

        /// <summary>
        /// Gets the text before <see cref="beforeThis"/> within <see cref="value"/>
        /// <code>
        ///     Example: "hi there lol".Before("ere"); returns "hi th";
        /// </code>
        /// </summary>
        public static string Before(this string value, string beforeThis)
        {
            try
            {
                int posBefore = value.IndexOf(beforeThis);

                if (posBefore == -1)
                    return "";

                return value.Substring(0, posBefore);
            }
            catch { return ""; }
        }

        /// <summary>
        /// Gets the first occourance of the text after <see cref="afterThis"/> within <see cref="value"/>
        /// <code>
        ///     Example: "hi there lol hehe".After("he"); returns "re lol hehe";
        /// </code>
        /// </summary>
        public static string After(this string value, string afterThis)
        {
            try
            {
                int posAfter = value.IndexOf(afterThis);

                if (posAfter == -1)
                    return "";

                int afterIndex = posAfter + afterThis.Length;

                if (afterIndex >= value.Length)
                    return "";

                return value.Substring(afterIndex);
            }
            catch { return ""; }
        }

        /// <summary>
        /// Returns true if the text is null or empty
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsEmpty(this string text)
        {
            return string.IsNullOrEmpty(text);
        }

        // Probably useless functions, but i find them useful

        /// <summary>
        /// Checks if a string is bigger than or equal to the <paramref name="minimumLength"/>
        /// </summary>
        /// <param name="str"></param>
        /// <param name="minimumLength"></param>
        /// <returns></returns>
        public static bool IsLongEnough(this string str, int minimumLength)
        {
            return str.Length >= minimumLength;
        }

        /// <summary>
        /// Is the char a letter/number or an underscore
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        public static bool IsWord(this char character)
        {
            return char.IsLetterOrDigit(character) || character == '_';
        }


        /// <summary>
        /// Checks if the text in value after the specified index is equal to <paramref name="check"/>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="startIndex"></param>
        /// <param name="length"></param>
        /// <param name="check">The value to be checked</param>
        /// <returns></returns>
        public static bool CheckAfter(this string value, int startIndex, string check)
        {
            return value.Extract(startIndex, check.Length) == check;
            //return value.IsLongEnough(startIndex + 1 + length) && value.Substring(startIndex, length) == check;
        }

        /// <summary>
        /// Repeats <see cref="value"/>, <see cref="n"/> number of times
        /// </summary>
        /// <param name="value">The value to be repeated</param>
        /// <param name="n">The number of times to repeat the value</param>
        /// <returns>A new string with the repeated text</returns>
        public static string Repeat(this string value, int n)
        {
            string newValue = "";
            for (int i = 0; i < n; i++)
            {
                newValue += value;
            }
            return newValue;
        }

        /// <summary>
        /// Repeats <see cref="value"/>, <see cref="n"/> number of times
        /// </summary>
        /// <param name="value">The character to be repeated</param>
        /// <param name="n">The number of times to repeat the value</param>
        /// <returns>A new string with the repeated text</returns>
        public static string Repeat(this char value, int n)
        {
            string newValue = "";
            for (int i = 0; i < n; i++)
            {
                newValue += value;
            }
            return newValue;
        }

        /// <summary>
        ///     Forces a given string to be a certain length by filling it with an excess of a given character (whitespace by default),
        ///     or by removing characters on the end if you require a shorter string
        /// </summary>
        /// <param name="text">the text</param>
        /// <param name="length">The length of the string that will be returned</param>
        /// <returns></returns>
        public static string EnsureLength(this string text, int length, char fillCharacter = ' ')
        {
            int repeatLength = length - text.Length;
            if (repeatLength == 0)
                return text;
            else if (repeatLength < 0)
                return text.Remove(length);
            else
                return text + Repeat(fillCharacter, repeatLength);
        }

        /// <summary>
        /// Counts the total number of occourances of a given character
        /// </summary>
        /// <param name="value"></param>
        /// <param name="character"></param>
        /// <returns></returns>
        public static int Count(this string value, char character)
        {
            int counts = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == character) counts++;
            }
            return counts;
        }

        /// <summary>
        /// Replaces all occourances of repeated whitespaces with single whitespaces
        /// </summary>
        /// <param name="value"></param>
        /// <returns>A string where all occourances of whitespaces are always 1 character long</returns>
        public static string CollapseWhitespaces(this string value)
        {
            //return Regex.Replace(value, @"\s+", " ");
            return value.CollapseCharacter(' ');
        }

        /// <summary>
        /// Replaces all repeated occourances of the given character with just 1 occourance
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string CollapseCharacter(this string value, char character)
        {
            string[] values = value.Split(character);
            List<string> newValues = new List<string>(values.Length);
            for (int i = 0; i < values.Length; i++)
            {
                string val = values[i];
                if (val.Trim() == string.Empty)
                    continue;
                newValues.Add(val);
            }
            return string.Join(character.ToString(), newValues);
        }

        /// <summary>
        /// Extracts a region of a string
        /// </summary>
        /// <param name="value">The string</param>
        /// <param name="startIndex">The start of the extraction</param>
        /// <param name="endIndex">The end of the extraction</param>
        /// <returns>The text between <paramref name="startIndex"/> and <paramref name="endIndex"/> within <paramref name="value"/></returns>
        public static string Extract(this string value, int startIndex, int endIndex)
        {
            return value.Substring(startIndex, Math.Min(endIndex - startIndex, value.Length));
        }

        /// <summary>
        /// Replaces all occourances of <paramref name="oldText"/> with <paramref name="newText"/>. 
        /// If the word isn't in the text, it returns the original text
        /// </summary>
        /// <param name="text">The text</param>
        /// <param name="oldText">Replace this text...</param>
        /// <param name="newText">with this tex</param>
        /// <returns></returns>
        public static string ReplaceAll(this string text, string oldText, string newText)
        {
            if (text.IsEmpty())
            {
                return text;
            }

            int currentIndex = 0;
            while (true)
            {
                int position = text.IndexOf(oldText, currentIndex);
                if (position == -1)
                {
                    return text;
                }
                int indexAfter = position + oldText.Length;
                if ((position == 0 || !IsWord(text[position - 1])) && (indexAfter == text.Length || !IsWord(text[indexAfter])))
                {
                    text = text.Substring(0, position) + newText + text.Substring(indexAfter);
                    currentIndex = position + newText.Length;
                }
                else
                {
                    currentIndex = position + oldText.Length;
                }
            }
        }

        /// <summary>
        /// Replaces the last occourance of a word with another word. If the word isn't in the text, it returns the original text
        /// </summary>
        /// <param name="text">The original text (HelloThereHello)</param>
        /// <param name="oldText">Replace the last occourance of this...</param>
        /// <param name="newText">with this</param>
        /// <returns></returns>
        public static string ReplaceLast(this string text, string oldText, string newText)
        {
            int place = text.LastIndexOf(oldText);

            if (place == -1)
                return text;

            return text.Remove(place, oldText.Length).Insert(place, newText);
        }

        /// <summary>
        /// Replaces the first occourance of a word with another word. If the word isn't in the text, it returns the original text
        /// </summary>
        /// <param name="text">The original text (HelloThereHello)</param>
        /// <param name="oldText">Replace the last occourance of this...</param>
        /// <param name="newText">with this</param>
        /// <returns></returns>
        public static string ReplaceFirst(this string text, string oldText, string newText)
        {
            int place = text.IndexOf(oldText);

            if (place == -1)
                return text;

            return text.Remove(place, oldText.Length).Insert(place, newText);
        }

        /// <summary>
        /// Replaces the first occourance of a word (at a given index) with another word. If the word isn't in the text, it returns the original text
        /// </summary>
        /// <param name="text">The original text (HelloThereHello)</param>
        /// <param name="oldText">Replace the last occourance of this...</param>
        /// <param name="newText">with this</param>
        /// <returns></returns>
        public static string Replace(this string text, string oldText, string newText, int startIndex)
        {
            int place = text.IndexOf(oldText, startIndex);

            if (place == -1)
                return text;

            return text.Remove(place, oldText.Length).Insert(place, newText);
        }

        public static string EfficientToLower(this string value)
        {
            string output = "";
            for (int i = 0; i < value.Length; i++)
            {
                char character = value[i];
                if (character.IsUppercase())
                    output += character.MakeLowercase();
                else
                    output += character;
            }

            return output;
        }

        public static string EfficientToUpper(this string value)
        {
            string output = "";
            for (int i = 0; i < value.Length; i++)
            {
                char character = value[i];
                if (character.IsLowercase())
                    output += character.MakeLowercase();
                else
                    output += character;
            }

            return output;
        }

        private static bool IsLowercase(this char character)
        {
            return character > 96 && character < 123;
        }

        private static bool IsUppercase(this char character)
        {
            return character > 96 && character < 123;
        }

        private static char MakeUppercase(this char value)
        {
            return (char)(value - 32);
        }

        private static char MakeLowercase(this char value)
        {
            return (char)(value + 32);
        }
    }
}
