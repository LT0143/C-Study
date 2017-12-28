using System;
using System.Diagnostics;
using System.Reflection;
 


/// <summary>
/// 反射，动态调用成员
/// </summary>
 public partial  class DynamicCallMember
{
     //public static void Main(string[] args)
     //{
     //    string erroMsg;
     //   CommandLineInfo commandLine = new CommandLineInfo();
     //    if (!CommandLineHandler.TryParse(args, commandLine, out erroMsg))
     //    {
     //       Console.WriteLine("erroMsg main"+erroMsg);
     //        DisplayHelp();
     //    }
     //    if (commandLine.Help)
     //    {
     //        DisplayHelp();
     //    }
     //    else
     //    {
     //        if (commandLine.priority != ProcessPriorityClass.Normal)
     //        {
     //         Console.WriteLine("change thread priority");
     //       }
     //   }
        
    //}

    private static void  DisplayHelp()
    {
        Console.WriteLine("DisplayHelp");
    }

}


