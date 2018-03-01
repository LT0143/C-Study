using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//相等性比较器P452.
public class ContactEquality:IEqualityComparer<Contact>
{
    public bool Equals(Contact x, Contact y)
    {
        //引用是否相等
        if (object.ReferenceEquals(x, y))
        {
            return true;
        }
        if (x == null || y == null)
            return false;
        return x.LastName == y.LastName && x.FirstName == y.FirstName;
    }
    //相等性比较器要求如下：
    //相等的对象必然有相等的散列码，实例生存期间（至少当期在散列表中的时候），其散列码一直不变
    //散列码算法应快速生成良好分布的散列码
    //散列算法应避免在所有可能的对象中引发异常 
    public int GetHashCode(Contact obj)
    {
         
        int h1 = obj.FirstName == null
            ? 0
            : obj.FirstName.GetHashCode();

        int h2 = obj.LastName == null
            ? 0
            : obj.LastName.GetHashCode();
        Console.WriteLine("h1: "+h1+" h2: "+h2);

        return h1 * 23+ h2;

    }

    static void Main()
    {
        Contact x = new Contact("aaa", "aaa", "add","123");
        Contact y = new Contact("aaa", "aaa", "add","123");

        ContactEquality contacte= new ContactEquality();
        Console.WriteLine(contacte.Equals(x, y));
        Console.WriteLine(contacte.GetHashCode(x));
        Console.WriteLine(contacte.GetHashCode(y));

    }

}
 
