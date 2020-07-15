using System;

namespace stlib
{
    public static class FormatterLibrary
    {
        public static string FormatGreetings(this string Input)
        {
            string formatted = $"Hello, {Input}!";
            
            return formatted;
        }
    }
}
