using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/// <summary>
/// 121页，参数的关键字 ref out params
/// </summary>
  public  class RefAndOut
    {
      /**
      public static void Main()
      {
          int i = 1;
          int f = 2;
          Change(ref i,ref f); //关键字ref，传引用方式传递变量。需先初始化变量的值
          System.Console.WriteLine(@"first = ""{0}"",seconed =""{1}""",i,f);

          int o;
          if(OutValue(out o))
              System.Console.WriteLine(@"0 = ""{0}""", o);

          string fullName;
          fullName = combine(Directory.GetCurrentDirectory(),"bin","config","index.html");
          System.Console.WriteLine(fullName);

          fullName = combine(Environment.SystemDirectory, "timp", "index.html");
          System.Console.WriteLine(fullName);

          fullName = combine("D:?????" , new string[]{ "c:\\","data", "index.html"});
          System.Console.WriteLine(fullName);

      }
      **/
      public static void Change(ref int a, ref int b)
      {
          int m = a;
          a = b;
          b = m;
      }

      public static bool OutValue(out int i) 
      {
          i = 9;
          return true;
      }


      /// <summary>
      /// params允许调用方法时提供数量可变的参数，
      /// </summary>
      /// <param name="paths">在方法声明的最后一个参数前添加param,将最后一个参数声明为数组，每个参数都</param>
      /// <returns></returns>
      static string combine( string a, params string[] paths) 
      {
          string result = string.Empty;

          foreach (string path in paths)
          {
              result = Path.Combine(result,path);
          }
          result += a;
          return result;
      }
    }
