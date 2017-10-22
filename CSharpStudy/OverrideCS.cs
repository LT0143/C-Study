using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// override 与new 修饰符对比201页,sealed修饰符是禁止从该类继承
/// </summary>
public class OverrideCS
{
    //基类
    public class BaseClass 
    {
        public void DisplayName()
        {
            Console.WriteLine("BaseClass");
        }
    }
    //派生类
    public class DerivedClass :BaseClass
    {
        public virtual void DisplayName()
        {
            Console.WriteLine("DerivedClass");
        }
    }
    //代替派生类
    public  class SubDerivedClass : DerivedClass
    {
        //sealed 必须是override方法，并且子类不能再重写改方法
        //public override sealed void DisplayName()
        public override  void DisplayName()
        {
            Console.WriteLine("SubDerivedClass");
        }
    }
    //超级派生类
    public class SuperDerivedClass : SubDerivedClass
    {
        //public new void DisplayName()
        public override void DisplayName()
        {
            Console.WriteLine("SuperDerivedClass");
        }
    }

    //不能重写SubDerivedClass中修饰符带有 sealed 和 override的DisplayName()方法
    public class SupSupDerivedClass : SubDerivedClass
    {
        public override  void DisplayName()
        {
            Console.WriteLine("SupSupDerivedClass");
        }
    }
    public static void Main() 
    {  
        //new对象就是调用对象中的方法，不受方法的修饰符影响    结果如下
        SuperDerivedClass superNew = new SuperDerivedClass();  //SuperDerivedClass
        SubDerivedClass subNew = new SubDerivedClass();       //SubDerivedClass
        DerivedClass DerNew = new DerivedClass();               //DerivedClass
        BaseClass baseNew = new BaseClass();                   //BaseClass
        SupSupDerivedClass supSup = new SupSupDerivedClass();  //SupSupDerivedClass

        //调用的是当前层级链子类中最远的的override方法SubDerivedClass.DisplayName()是重写基类虚成员派生的最远的成员。
        //使用了new 修饰符的SuperDerivedClass.DisplayName()被隐蔽
        SubDerivedClass superTosub = superNew;              //SubDerivedClass
        DerivedClass superToDer = superNew;                 //SubDerivedClass
        BaseClass superToBase = superNew;                    //BaseClass

        DerivedClass subToDer = subNew;                   //SubDerivedClass
        BaseClass subToBase = subNew;                     //BaseClass

        DerivedClass supsupToder = supSup;                   //SupSupDerivedClass
        DerivedClass supToder = superNew;                   //SupDerivedClass


        superNew.DisplayName();
        subNew.DisplayName();
        DerNew.DisplayName();
        baseNew.DisplayName();
        supSup.DisplayName();
        Console.WriteLine("\n=======\n");

        superTosub.DisplayName();
        superToDer.DisplayName();
        superToBase.DisplayName();

        subToDer.DisplayName();
        subToBase.DisplayName();
        Console.WriteLine("\n=======\n");

        supsupToder.DisplayName();
        supToder.DisplayName();
    }
}

