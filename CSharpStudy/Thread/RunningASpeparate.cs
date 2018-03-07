using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// 使用system.Threading.Thread启动一个方法
/// </summary>
public class RunningASpeparate
{
    public const int Repetitions = 3000;

    public static void Main()
    {
        ThreadStart threadStart = DoWork;
        Thread thread = new Thread(threadStart);
        //两个循环并行运行的
        thread.Start();
        for (int count = 0; count < Repetitions; count++)
        {
            Console.Write('-');
        }
    }

    public static void DoWork()
    {
        for (int count = 0; count < Repetitions; count++)
        {
            Console.Write('+');
        }
    }
}
 
