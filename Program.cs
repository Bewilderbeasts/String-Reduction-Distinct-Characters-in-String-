using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{

    /*
     * Complete the 'getMinDeletions' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int getMinDeletions(string s)
    {
        int minumumDeletions;
        int stringLength = s.Length;
        int distChar = 0;

        //create a array to store different characters occurences (max 26 in alphabet, considering only lowercase or only uppercase)
        int[] count = new int[26];

        //fill the array with zeroes
        for (int i = 0; i < 26; i++)
        {
            count[i] = 0;
        }

        //for makes the loop as many times as long is the string
        for (int i = 0; i < stringLength; i++)
        {

            //then it check if the value in array at index (s[i]) subsctracted by 'a' (first char in alphabet) is equal to 0

            // IN OTHER WORDS: if the value at index i is 0, that means that character did not appear in the string
            // EXAMPLE: we check the letter 'j' that is at second position/place in our string (eg: "ajkajkg")
            // so in the count[s[i] - 'a'] its going to be 0, because it not appeared in our string yet
            // NOTE to self: s[i] - 'a' returns the number which is the index of the "letter's place in the alphabet" in the array 
            if (count[s[i] - 'a'] == 0)
            {
                //then we increment the distchar, because we found new distinct character in string
                distChar++; 
            }
            //and at last we  increment the count[s[i] - 'a'], which is the place in array that coresponds to 'j' letter (26 zeroes in array = 26 chars in alphabet)
            count[s[i] - 'a']++;
        }

        //substract number of distinct characters from the legnth of string to get minumum deleteions needed
        minumumDeletions = stringLength - distChar;

        return minumumDeletions;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = Result.getMinDeletions(s);

        Console.WriteLine(result);
        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
