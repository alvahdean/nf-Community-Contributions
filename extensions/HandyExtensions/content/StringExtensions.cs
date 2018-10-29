using System;
using System.Text;

namespace nanoFramework.Contrib.HandyExtensions.StringExtensions
{
    /// <summary>
    /// Provides various System.string methods for compatobility with existing c# code
    /// </summary>
    public static class StringEx
    {
        /// <summary>
        /// Indicates whether the specified string is null or an Empty string.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>true if the value parameter is null or an empty string (""), otherwise false.</returns>
        public static bool IsNullOrEmpty(string value)
        {
            return value == null || value == String.Empty;
        }

        /// <summary>
        /// Indicates whether a specified string is null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>true if the value parameter is null or Empty, or if value consists exclusively of white-space, otherwise false</returns>
        public static bool IsNullOrWhitespace(string value)
        {
            return value == null || StringEx.IsNullOrEmpty(value.Trim());
        }

        /// <summary>
        /// Indicates whether the specified string is null or an Empty string.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>true if the value parameter is null or an empty string (""), otherwise false.</returns>
        public static bool isNullOrEmpty(this string value) => StringEx.IsNullOrEmpty(value);

        /// <summary>
        /// Indicates whether a specified string is null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>true if the value parameter is null or Empty, or if value consists exclusively of white-space, otherwise false</returns>
        public static bool isNullOrWhitespace(this string value) => StringEx.IsNullOrWhitespace(value);

        /// <summary>
        /// Determines whether the beginning of this string instance matches a specified string.
        /// </summary>
        /// <param name="str">The string to test</param>
        /// <param name="value">The string to compare</param>
        /// <returns>true if value matches the beginning of str, otherwise false</returns>
        public static bool StartsWith(this string str,string value)
        {
            if (str == null || value == null)
                return false;

            int strLen = str.Length;
            int valLen = value.Length;

            return valLen <= strLen ? value == str.Substring(0, valLen) : false;

        }

        /// <summary>
        /// Determines whether the first character of this string instance matches a specified character.
        /// </summary>
        /// <param name="str">The string to test</param>
        /// <param name="value">The char to compare</param>
        /// <returns>true if value matches the beginning of str, otherwise false</returns>
        public static bool StartsWith(this string str, char value)
        {
            if (IsNullOrEmpty(str) || value == '\0')
                return false;

            return str.ToCharArray()[0]==value;

        }

        /// <summary>
        /// Determines whether the end of this string instance matches a specified string.
        /// </summary>
        /// <param name="str">The string to test</param>
        /// <param name="value">The string to compare</param>
        /// <returns>true if value matches the end of str, otherwise false</returns>
        public static bool EndsWith(this string str, string value)
        {
            if (str == null || value == null)
                return false;

            int strLen = str.Length;
            int valLen = value.Length;

            return valLen <= strLen ? value == str.Substring(strLen - valLen, valLen) : false;
        }
        
        /// <summary>
        /// Determines whether the last character of this string instance matches a specified character.
        /// </summary>
        /// <param name="str">The string to test</param>
        /// <param name="value">The character to compare</param>
        /// <returns>true if value matches the end of str, otherwise false</returns>
        public static bool EndsWith(this string str, char value)
        {
            if (IsNullOrEmpty(str) || value == '\0')
                return false;
            int idx = str.Length - 1;
            return str.ToCharArray()[idx] == value;
        }

        /// <summary>
        /// Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string.
        /// </summary>
        /// <param name="str">The string to modify</param>
        /// <param name="oldValue">The string to replace (may NOW be null or String.Empty)</param>
        /// /// <param name="newValue">The replacement string (may be null ot String.Empty)</param>
        /// <returns>A new string with replacements made (String.Empty if str is null)/returns>
        public static string Replace(this string str, string oldValue, string newValue)
        {
            if (str.isNullOrEmpty())
                return String.Empty;

            if (oldValue.isNullOrEmpty())
                throw new ArgumentNullException("oldValue");

            if (newValue == null)
                newValue = "";
   
            int newLen = newValue.Length;
            int oldLen = oldValue.Length;
            int idx;
            string result = str;
            while ((idx=result.IndexOf(oldValue))>0)
            {
                string tmp = result;
                result = tmp.Substring(0, idx) + newValue + tmp.Substring(idx + oldLen);
            }
            return result;
        }

        /// <summary>
        /// Returns a new string in which all occurrences of a specified character in the current instance are replaced with another specified character.
        /// </summary>
        /// <param name="str">The string to modify</param>
        /// <param name="oldValue">The character to replace (may NOT be '\0')</param>
        /// /// <param name="newValue">The replacement character (may be '\0')</param>
        /// <returns>A new string with replacements made (String.Empty if str is null)/returns>
        public static string Replace(this string str, char oldValue, char newValue)
        {
            if (oldValue == Char.MinValue)
                throw new ArgumentException($"Invalid character [NUL]","oldValue");

            if (str.isNullOrEmpty())
                return String.Empty;

            int newLen = newValue==Char.MinValue ? 0 : 1;
            int idx;
            string result = str;
            while ((idx = result.IndexOf(oldValue)) > 0)
            {
                string tmp = result;
                result = tmp.Substring(0, idx);
                if (newLen == 1)
                    result += newValue;
                result+=tmp.Substring(idx + 1);
            }
            return result;
        }

    }


}
