using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 匿名类型
/// </summary>
public class AnonymousType
{/*
    static void Main()
    {
        var patent1 = new {Title = "B", YearOfPublication = "1784"}; //匿名类型,
        var patent2 = new {YearOfPublication = "1877", Title = "P"};
        var patent3 = new {patent1.Title, Year = patent1.YearOfPublication};

        Console.WriteLine("{0} ({1})", patent1.Title, patent1.YearOfPublication);
        Console.WriteLine("{0} ({1})", patent2.Title, patent2.YearOfPublication);
        Console.WriteLine();
        Console.WriteLine("patent1 " + patent1);
        Console.WriteLine("patent2 " + patent2);
        Console.WriteLine("patent3 " + patent3);
        Console.WriteLine();

        //类型兼容：属性名称、数据类型和属性顺序必须完全匹配
        //patent1 = patent2; //错误，属性顺序不一样
        Console.WriteLine("patent1 " + patent1);
        //错误，属性类型不一样
        // patent1 = patent3;

        //错误，匿名类型是只读的，不可变的，匿名类型一旦实例化就不允许再更改他的某个属性
        // patent3.Title = "1212";

        collectionInitializers();
        Console.WriteLine();

        AnonymousArry();
        ForeachStack();
    }
    */
    //集合初始化器
    static void collectionInitializers()
    {

        List<string> sevenWorldBlunders;
        sevenWorldBlunders = new List<string>()   //没有参数，最后这个()可以不要
        {
            "walth without work",
            "k",
            "s",
            "c",
            "w",
            "p",
            "z"
        };
        PrintTool.PrintIEnumerable(sevenWorldBlunders);
    }



    //匿名类型数组,由匿名类型构成的数组，每个项的类型必须相同
    static void AnonymousArry()
    {
        var worldCup = new[]
        {
            new
            {
                teamNma = "a",
                players = new string[]
                {
                    "a", "b", "c"
                }
            },
            new
            {
                teamNma = "b",
                players = new string[]
                {
                    "d", "e", "f"
                }
            }
        };
        PrintTool.PrintIEnumerable(worldCup);
    }

    /// <summary>
    /// foreach循环期间集合中的计数是不能变动，集合项本身也不能被修改
    /// </summary>
   static void ForeachStack()
    {
        Stack<int> statck = new Stack<int>();
        Stack<int>.Enumerator enumerator;
        IDisposable disposable;
        int num;

        enumerator = statck.GetEnumerator();
        //try
        //{
        //    while (enumerator.MoveNext())
        //    {
        //        num = enumerator.Current;
        //        Console.WriteLine(num);
        //    }
        //}
        //finally
        //{
        //    //退出循环后对状态进行清理
        //    disposable = enumerator;
        //    disposable.Dispose();
        //}

        //使用using的错误处理和资源清理
        using (enumerator)
        {
            while (enumerator.MoveNext())
            {
                num = enumerator.Current;
                Console.WriteLine(num);
            }
        }
      
    }
}
 
