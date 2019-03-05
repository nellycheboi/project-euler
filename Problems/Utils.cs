using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    public class Utils
    {
        public static bool IsPalindrome(string input)
        {
            input = input.ToLower();
            int forward = 0;
            int backward = input.Length - 1;
            char[] characterToIgnore = new char[] { ' ', '.', '\'', '-', ',', '!', ':', '?'};

            while (backward > forward && (backward - forward) > 1)
            {
                char currentLeft = input[forward];
                char currentRight = input[backward];

                if (characterToIgnore.Any(x => x == currentLeft))
                {
                    forward++;
                    continue;
                }
                if (characterToIgnore.Any(x => x == currentRight))
                {
                    backward--;
                    continue;
                }
                if (currentLeft == currentRight)
                {
                    forward++;
                    backward--;
                }
                else
                {
                    return false;
                }

            }
            return true;
        }
    }
}
