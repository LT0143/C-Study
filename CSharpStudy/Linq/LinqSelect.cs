using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// linq查询表达式
/// </summary>
public class LinqSelect
{
    static string[] keyWords = {"aa", "*bb", "cc", "*bc", "*dd" };

    /* 
    static void Main()
    {
        ShowContextualKeyWords();
    }
    */

    static void ShowContextualKeyWords()
    {
        IEnumerable<string> selection = from word in keyWords
            where !word.Contains('*')
            select word;

        foreach (string keyWord in selection)
        {
            Console.WriteLine(keyWord + " ");
        }

    }
}
 
