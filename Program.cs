using System.Globalization;

namespace ConsoleApp3
{
    internal class Program
    {
        /*Travelling through Europe one needs to pay attention to
        how the license plate in the given country is displayed.
        When crossing the border you need to park on the shoulder,
        unscrew the plate, re-group the characters according to
        the local regulations, attach it back and proceed with the journey.

        Create a solution that can format the dmv number
        into a plate number with correct grouping.
        The function input consists of string s and group length n.
         The output has to be upper case characters and digits.
        The new groups are made from right to left and connected by -.
         The original order of the dmv number is preserved.

        Examples
        LicensePlate("5F3Z-2e-9-w", 4) ➞ "5F3Z-2E9W"

        LicensePlate("2-5g-3-J", 2) ➞ "2-5G-3J"

        LicensePlate("2-4A0r7-4k", 3) ➞ "24-A0R-74K"

        LicensePlate("nlj-206-fv", 3) ➞ "NL-J20-6FV"
         */
        public static void LicensePlate(string dmvNum, int n)
        {
            string s =new string( dmvNum.Where(char.IsLetterOrDigit).ToArray());
            s=s.ToUpper();
            Console.WriteLine(s);
            List<string> groups = new List<string>();
            for (int i=s.Length; i > 0;i=i-n)
            {
                if (i - n > 0)
                {
                    if(i<n)
                    {
                        groups.Add(s.Substring(i - n, i));
                    }
                    else
                    {
                        groups.Add(s.Substring(i - n, n));
                    }
                }
                else
                {
                    if (i < n)
                    {
                        groups.Add(s.Substring(0, i));
                    }
                    else
                    {
                        groups.Add(s.Substring(0, n));
                    }
                }
            }
            groups.Reverse();
            string result = string.Join("-", groups);
            Console.WriteLine($"The License Plate is: {result}");

            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the DMV Number");
            string dmvNum = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the lenght of grouping");
            int groupLen = Convert.ToInt32(Console.ReadLine());
            LicensePlate(dmvNum, groupLen);
        }
    }
}
 
