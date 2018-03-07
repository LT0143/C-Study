using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 文档类，序列化举例用。 与序列化相关的特性，用SerializableAttribute来保存文档
/// </summary>
[Serializable]
public class Document
{
    public string Title = null;
    public string Data = null;

    [NonSerialized]
    public long _WindowHandle = 0;

    class Image
    {
         
    }

    [NonSerialized]
    private Image Picture = new Image();
}

public class SerializableTest
{
    /*
    public static void Main()
    {
        Stream stream;
        Document documentBefore = new Document();
        documentBefore.Title = "A cacophony of ramblings foem my potpourri of notes";
        Document documentAfter;
        //知识点插入
//        C#中的using除了作为命名空间指示符(using System)，类型的别名指示符(using Dos=System.Console)，还有资源管理的语句功能：
//         using (R r1 = new R())
//        {
//            r1.F();
//        }
//        在C#中被翻译为：
//        R r1 = new R();
//        try
//        {
//            r1.F();
//        }
//        finally
//        {
//            if (r1 != null) ((IDisposable)r1).Dispose();
//        }
        //using使用参考上述知识点
        using (stream = File.Open(documentBefore.Title + ".bin", FileMode.Create))
        {
            BinaryFormatter formatter = new BinaryFormatter(); //二进制流文件
            formatter.Serialize(stream,documentBefore);  //将对象或具有顶级（根）、对象图序列化到给定的流，写入文件
        }

        using (stream = File.Open(documentBefore.Title + ".bin", FileMode.Open))
        {
            BinaryFormatter formatter = new BinaryFormatter(); //二进制流文件
            //注意：序列化是针对整个对象图（object graph，所有的项通过字段与已序列化对象[Document]关联）发生的。因此，对象图中所有的字段也是必须可序列化的。
            documentAfter =(Document) formatter.Deserialize(stream);   //指定的流反序列化对象图，读取文件
        }
        Console.WriteLine(documentAfter.Title);
    }
    */
}
 
