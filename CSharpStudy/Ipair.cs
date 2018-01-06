using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 314页，使用多个类型参数声明泛型
/// </summary>
/// <typeparam name="TFirsst"></typeparam>
/// <typeparam name="TSecond"></typeparam>
interface IPair<TFirsst,TSecond>
{
    TFirsst First { get; set; }
    TSecond Second { get; set; }

}

interface IPair<T>
{
    T First { get; set; }
    T Second { get; set; }
}

public struct Pair<T> : IPair<T>
{
    public Pair(T first)
    {
        _First = first;
        _Second = default(T);
    }
    private T _First;

    public T First
    {
        get { return _First; }
        set { _First = value; }
    }
    private T _Second;

    public T Second
    {
        get { return _Second; }
        set { _Second = value; }
    }
}

public struct Pair<TFirst, TSecond> : IPair<TFirst, TSecond>
{
    public Pair(TFirst first, TSecond second)
    {
        _First = first;
        _Second = second;
    }

    private TFirst _First;

    public TFirst First
    {
        get { return _First; }
        set { _First = value; }
    }
    private TSecond _Second;

    public TSecond Second
    {
        get { return _Second; }
        set { _Second = value; }
    }

}

public class PairTest
{
    //public static void Main(string[] args)
    //{
    //    Pair<int, string> historicalEvent = new Pair<int, string>(1914, "what ....");
    //    Console.WriteLine("{0},{1}", historicalEvent.First, historicalEvent.Second);
    //}

}