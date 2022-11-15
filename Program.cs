using System;
class Solution
{
    public static string CompressedWord(string word)
    {
        var txt = "";
        var txt1 = "";
        var charCount = 1;

        for (var i = 0; i < word.Length; i++)
        {
            
            if (i > 0 && word[i] == word[i - 1])
            {
                charCount++;
                txt1 = '{' + Convert.ToString(charCount) + Convert.ToString(word[i]) + '}';
            }
            else
            {
                txt1 = Convert.ToString(word[i]);
                charCount = 1;
            }

            txt += txt1;

            if (txt1.Length > 1 && charCount == 2)
            {
                txt = txt.Substring(0, txt.Length - (txt1.Length + 1)) + txt1;
            }
            else if (txt1.Length > 1)
            {
                txt = txt.Substring(0, txt.Length - (txt1.Length + 3 + Convert.ToString(charCount - 1).Length)) + txt1;
            }

            
            
        }
        
        return txt;
    }

    static void Main()
    {
        string compressedWord = CompressedWord("heeeeeeeeeell0");
        string compressedWord1 = CompressedWord("hhhheeeeeeeeeeeeeeeeeeell0");
        string compressedWord2 = CompressedWord("Hhheeeeeeeeee eeeeeeeeell0");
        Console.WriteLine(compressedWord);
        Console.WriteLine(compressedWord1);
        Console.WriteLine(compressedWord2);
    }

}