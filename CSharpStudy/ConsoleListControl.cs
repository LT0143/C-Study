using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 215页，通过接口实现多态性。Ilistable接口定义了一个类，为了让consoleListControl类显示它而必须支持的成员。
/// 任何类只要实现了IListable接口，就可以使用consoleListControl显示它自身，IListable皆有要求只读属性ColumnValues。
/// </summary>
interface IListable
{
    /// <summary>
    /// 列的值。不允许接口成员使用访问修饰符，自动定义为公共成员
    /// </summary>
    string[] ColumnValues
    { get; }
}

public abstract class PdaItem 

{
    public virtual string Name { get; set; }
    public PdaItem(string name)
    {
        Name = name;
    }
}

public class Contact : PdaItem, IListable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }

    public string[] ColumnValues
    {
        get
        {
            return new string[]
            {
                FirstName,
                LastName,
                Address,
                Phone
            };
        }
    }

    /// <summary>
    /// 标题
    /// </summary>
    public static string[] Headers
    {
        get
        {
            return new string[] {
                "First Name","Last Name   ",
                "Phone          ","Address          "
            };
        }
    }

    public Contact(string firsName, string lastName, string addres, string phone) : base(null)
    {
        FirstName = firsName;
        LastName = lastName;
        Address = addres;
        Phone = phone;
    }
}

/// <summary>
/// 出版类
/// </summary>
class Publication : IListable
{

    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Publication(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    /// <summary>
    /// 显式接口实现与接口关联。该接口不被看成是类的公共成员，因此没有必要使用virtual、override、public来修饰。
    /// 调用时要转换成该接口类型。非该类核心功能建议写成显示接口。
    /// </summary>
    string[] IListable.ColumnValues
    {
        get
        {
            return new string[]
                {
                    Title,
                    Author,
                    Year.ToString()
                };
        }
    }
    //隐式接口实现，必须是public，还可以virtual。当做是该类的公共成员，调用时直接用该类的实例对象调用。该类核心功能建议写成显示接口。
    //public string[] ColumnValues
    //{
    //    get
    //    {
    //        return new string[]
    //            {
    //                Title,
    //                Author,
    //                Year.ToString()
    //            };
    //    }
    //}

    public static string[] Headers
    {
        get
        {
            return new string[]
                {
                "Title          ","Author      ",
                "Year"
                };
        }
    }
}

class ConsoleListControl
{
    public static void List(string[] headers, IListable[] items)
    {
        int[] column = DisplayHearders(headers);
        for (int i = 0; i < items.Length; i++)
        {
            string[] values = items[i].ColumnValues;
            DisplayItemRow(column, values);
        }
    }

    private static int[] DisplayHearders(string[] headers)
    {
        int[] ints = new int[] { 10, 10, 50, 100 };
         return ints;
    }
    private static void DisplayItemRow(int[]columnwidths,string[] values)
    {
        string s = string.Join(",",values);
        Console.WriteLine(s);
    }
}


class Mypro
{
    /*早期测试入口
    public static void Main()
    {
        Contact[] contacts = new Contact[6];
        contacts[0] = new Contact("Dick", "Traci", "123 main st.,spok", "123-123-1234");
        contacts[1] = new Contact("Andrew", "Littman", "1417 palmary st.,dallas", "555-123-4567");
        contacts[2] = new Contact("Mary", "Hartfelt", "1520 thunder way st.,PA444", "444-123-4567");
        contacts[3] = new Contact("John", "Lindherst", "1 Aerial way,NH 8888", "222-987-1234");
        contacts[4] = new Contact("Pat", "wilson", "565 Irving Dr.,Fl 222", "123-456-789");
        contacts[5] = new Contact("Jane", "Doe", "123  st.,IL 222", "333-345-789");


        ConsoleListControl.List(Contact.Headers, contacts);

        Console.WriteLine();

        Publication[] publicaiton = new Publication[3]
        {
            new Publication("Celebration","richard",1978),
            new Publication("orthdo","richard",1980),
            new Publication("galaxy","richard",1979) 
        };
        ConsoleListControl.List(Publication.Headers, publicaiton);
        Console.ReadKey();

        //显示成员实现
        string[] values;
        values = contacts[0].ColumnValues;
        values = ((IListable)contacts[1]).ColumnValues;

        //显示实现接口不属于该类，无法通过实例直接访问
       // values = publicaiton[0].ColumnValues;
        values = ((IListable)publicaiton[1]).ColumnValues;
    }
    */
}

