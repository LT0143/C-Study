using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 327,声明中entityDictionary<....>中使用的实体
/// </summary>
public class Order:EntityBase<Guid>
{
    public Order(Guid guid)
        : base(guid)
    {
 
    }
}

public class OrderFactory : IEntityFactory<Guid, Order>
{
    public Order creatnew(Guid key) 
    {
        return new Order(key);
    }
}

class Genericity
{
    //测试入口
    public static void Main()
    {
        Guid guid = new Guid("6F9619FF-8B86-D011-B42D-00C04FC964FF");
        Order od = new Order(guid);
        OrderFactory fc = new OrderFactory();
        fc.creatnew(guid);
        EntityDictionnary<Guid, Order, OrderFactory> entity = new EntityDictionnary<Guid, Order, OrderFactory>();

        string key = entity.Count.ToString();
        //string value = entity[0].vale.ToString();

        Console.WriteLine();

        
    }
    
}
 
