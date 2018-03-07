using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

[Versions(Name = "hydd", Date = "2018-2-26", Describtion = "hydd is class")]
public class MyCode
{

}

public class AttributeTest
{
   /*
    static void Main(string[] args)
    {
        //var info = typeof(MyCode);
        //var classAttribute = (VersionsAttribute)Attribute.GetCustomAttribute(info, typeof(VersionsAttribute));
        //Console.WriteLine(classAttribute.Name);
        //Console.WriteLine(classAttribute.Date);
        //Console.WriteLine(classAttribute.Describtion);

        //泛型反射
        //Type type;
        //type = typeof (System.Nullable<>);
        //Console.WriteLine(type.ContainsGenericParameters);//判断方法是否包含尚未设置的泛型参数
        //Console.WriteLine(type.IsGenericType);//是否是泛型
        //Console.WriteLine();


        //type = typeof(System.Nullable<DateTime>);
        //Console.WriteLine(type.ContainsGenericParameters);//判断方法是否包含尚未设置的泛型参数
        //Console.WriteLine(type.IsGenericType);

        //Stack<int> s = new Stack<int>();
        //Type t = s.GetType();
        //foreach (Type argument in t.GetGenericArguments())
        //{
        //    System.Console.WriteLine("Type parameter: " + argument.FullName);
        //}
  
        //flag特性,这个文件路径要先创建下
        string directoryName = @"d:/test";
        string fileName = directoryName+"/enumtest.txt";

        DirectoryInfo directory = new DirectoryInfo(directoryName);
        try
        {
            if (!directory.Exists)
                directory.Create();
        }
        catch (IOException e)
        {
            Console.WriteLine("the process failed:{0}", e.ToString());
        }


        FileInfo file = new FileInfo(fileName);
            if (!file.Exists)
                file.Create();
       
        file.Attributes = FileAttributes.Hidden | FileAttributes.ReadOnly;
        Console.WriteLine("\"{0}\" output as \"{1}\"",file.Attributes.ToString().Replace(","," |"),file.Attributes);

        FileAttributes attributes =(FileAttributes) Enum.Parse(typeof(FileAttributes),file.Attributes.ToString());
        Console.WriteLine(attributes);
    }
    */
}



