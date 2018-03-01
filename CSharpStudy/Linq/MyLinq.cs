using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


public class Patent
{
    public string Title { get; set; }
    public string YearOfPublication { get; set; }
    public string ApplictionNumber { get; set; }
    public long[] InventorIds { get; set; }

    public  override string ToString()
    {
        return string.Format("{0}({1})", Title, YearOfPublication);
    }
}

public class Inventor
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string State { get; set; }
    public string City { get; set; }
    public string Country { get; set; }

    
    public override string ToString()
    {
        return string.Format("{0}({1},{2})", Name, City, State);
    }
}

class MyLinq
{
    /*
    static void Main()
    {
        IEnumerable<Patent> patents = patentData.patents;
        PrintTool.PrintIEnumerable(patents);//显示的打印格式由tostring定义
        Console.WriteLine();
        IEnumerable<Inventor> invertors = patentData.Inventors;
        PrintTool.PrintIEnumerable(invertors);
        Console.WriteLine();

        patents = patents.Where(patent => patent.YearOfPublication.StartsWith("18"));
        PrintTool.PrintIEnumerable(patents);

        //linq语句----
        //count对元素进行计数
        Console.WriteLine("patent count in 1800s:{0}",patents.Count(patent=> patent.YearOfPublication.StartsWith("18")));
        //判断集合中是否有符合条件的值
        Console.WriteLine("any patent count in 1800s :{0}", patents.Any(patent=> patent.YearOfPublication.StartsWith("18")));
        Console.WriteLine();
        
        //排序
        IEnumerable<Patent> items = patents.OrderBy(patent => patent.Title);
        PrintTool.PrintIEnumerable(items);
    }
    */
}

public static class patentData
{
    public static readonly Inventor[] Inventors = 
    {
        new Inventor() {Name = "bf", City = "p city", State = "PA", Country = "USA", Id = 1},
        new Inventor() {Name = "ow", City = "kh city", State = "NC", Country = "USA", Id = 2},
        new Inventor() {Name = "ww", City = "kh city", State = "NC", Country = "China", Id = 3},
        new Inventor() {Name = "mpj", City = "NY city", State = "NY", Country = "USA", Id = 4}
    };

    public static readonly Patent[] patents = 
    {
        new Patent() {Title = "b", YearOfPublication = "1784", InventorIds = new long[] {1}},
        new Patent() {Title = "p", YearOfPublication = "1877", InventorIds = new long[] {1}},
        new Patent() {Title = "k", YearOfPublication = "1888", InventorIds = new long[] {1}},
        new Patent() {Title = "e", YearOfPublication = "1837", InventorIds = new long[] {4}}
    };

}



