using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 236页，使用工厂接口代替构造器约束。将Tkey传给一个需要获取参数的Tvalue方法，
/// </summary>
/// <typeparam name="Tkey"></typeparam>
public class EntityBase<Tkey>
{
    public Tkey Key 
    {
        get { return _key; }
        set { _key = value;}
    }
    private Tkey _key;
    public EntityBase(Tkey key)
    {
        Key = key;
    }

}

public class EntityDictionnary<Tkey,Tvalue,Tfactory>:Dictionary<Tkey,Tvalue>
    where Tkey:IComparable<Tkey>,IFormattable
    where Tvalue:EntityBase<Tkey>
    where Tfactory:IEntityFactory<Tkey,Tvalue> , new ()
{
    public Tvalue New(Tkey key)
    {
        Tfactory fac = new Tfactory();
        Tvalue newEntity = fac.creatnew(key);
        Add(key, newEntity);
        return newEntity;
    }
}

public interface IEntityFactory<Tkey, TValue>
{
    TValue creatnew(Tkey key);
}