using System;

namespace stlib
{
    public static class FormatterLibrary
    {
        public static string FormatGreetings(this string Input)
        {
            string formatted = $"{DateTime.Now.ToString("h:mm:ss tt") } Hello, {Input}!";
            
            return formatted;
        }
    }
}
