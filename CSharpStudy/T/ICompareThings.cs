using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 333，协变性和逆变性。
/// </summary>
public class Fruit { }
class Apple : Fruit { }
class Orange : Fruit { }

/// <summary>
/// 使用in类型参数修饰符实现逆变。
/// </summary>
/// <typeparam name="T"></typeparam>
public interface ICompareThings<in T>
{
   bool FirstIsBetter(T t1, T t2);
}
 public class CompareThings
{
     public class FruitComparer : ICompareThings<Fruit> 
    {
     public   bool FirstIsBetter(Fruit t1, Fruit t2)
        {
            Console.WriteLine("{0},{1}", t1.ToString(), t2.ToString());
            return true;
        }
    }
  /*  static void Main() 
    {
        ICompareThings<Fruit> fc = new FruitComparer();
        Apple ap1 = new Apple();
        Apple ap2 = new Apple();

        Orange org = new Orange();
        //子类可以转基类，因为逆变
        bool b1 = fc.FirstIsBetter(ap1, org);
        bool b2 = fc.FirstIsBetter(ap1, ap2);
        //接口是逆变的
        ICompareThings<Apple> ac = fc;
        bool b3 = ac.FirstIsBetter(ap1, ap2);
        //下面这个会报错，Orange不是apple的子类
        //bool b4 = ac.FirstIsBetter(ap2, org);
    }
    */
}
 
