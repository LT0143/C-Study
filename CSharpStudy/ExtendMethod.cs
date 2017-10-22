using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.拓展方法91页： static 类名，static方法名。用于给别的类当方法用，别的类就不需要再写这个方法了。
//2.第一个参数带有this指明了参数类型，该实例对象可以在其他类中直接调用这个方法而不输入第一个参数.
//如果类中的方法与拓展方法同名则调用类中的方法
    public static class ExtendMethod
{
    //第一个参数，拓展；类型，可以访问拓展类型所有公有方法和属性
    public static string GetCentreShift(this Employee node)
    {
        string axis =   node.firstName;
        Console.WriteLine("拓展方法收到个string {0} ", axis);
        return   axis; 
    }  
}


 
