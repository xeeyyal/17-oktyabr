using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16._10_Interface.Models
{
    //TASK-2
    //public static class Helper
    //{
    //    public static bool IsOdd(this int number)
    //    {
    //        return number % 2 != 0;
    //    }

    //    public static bool IsEven(this int number)
    //    {
    //        return number % 2 == 0;
    //    }

    //    public static bool HasDigit(this string input)
    //    {
    //        foreach (char digit in input)
    //        {
    //            if (char.IsDigit(digit))
    //                return true;
    //        }
    //        return false;
    //    }

    //    public static bool CheckPassword(this string password)
    //    {
    //        return password.Length >= 8 &&
    //               password.Any(char.IsUpper) &&
    //               password.Any(char.IsLower) &&
    //               password.Any(char.IsDigit);
    //    }

    //    public static string Capitalize(this string text)
    //    {
    //        if (string.IsNullOrWhiteSpace(text))
    //            return text;

    //        string[] words = text.Split(' ');
    //        for (int i = 0; i < words.Length; i++)
    //        {
    //            if (!string.IsNullOrEmpty(words[i]))
    //            {
    //                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
    //            }
    //        }
    //        return string.Join(" ", words);
    //    }
    //}

}
