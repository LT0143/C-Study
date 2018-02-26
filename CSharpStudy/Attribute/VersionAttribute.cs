using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//特性，为元素提供附加信息，类似于注释。会被编译器编译进程序集的元数据里
[AttributeUsage(AttributeTargets.Class)]
public class VersionsAttribute : Attribute
{
    public string Name { get; set; }
    public string Date { get; set; }
    public string Describtion { get; set; }
}

[Versions(Name = "hydd",Date = "2018-2-26",Describtion = "hydd is class")]
public class MyCode
{
    
}

public class AttributeTest
{
    static void Main(string[] args)
    {
        var info = typeof (MyCode);
        var classAttribute = (VersionsAttribute) Attribute.GetCustomAttribute(info, typeof (VersionsAttribute));
        Console.WriteLine(classAttribute.Name);
        Console.WriteLine(classAttribute.Date);
        Console.WriteLine(classAttribute.Describtion);
    }
}

 
 
