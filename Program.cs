using System;

namespace MaskSensitiveInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey you....Yeah You. Tell me a secret. I promise that I won't tell anyone.");
            var theSecret = Console.ReadLine();
            var maskedInfo = theSecret.Substring(theSecret.Length - 4).PadLeft(theSecret.Length, '#');

            Console.WriteLine(maskedInfo);
        }
    }
}
