using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// C#事件访问器,网上教程。add执行+=运算符的代码和remove执行-=运算符的代码.
/// 声明了事件访问器后，事件不包含任何内嵌委托对象。我们必须实现自己的机制来存储和移除事件的方法。
/// 事件访问器表现为void方法，也就是不能使用return语句。
/// </summary>


//声明一个委托
delegate void MyEventHandler();


class MyClass
    {
    //声明一个成员变量来保存事件句柄
    private MyEventHandler m_Handler = null;
    
    /// <summary>
    /// 激发事件
    /// </summary>
    public void FireAEvent()
    {
        if (m_Handler != null)
        {
            m_Handler();
        }
    }

    /// <summary>
    /// 声明事件
    /// </summary>
    public event MyEventHandler AEvent
    {
        //添加访问器
        add
        {
            Console.WriteLine("AEvent add 被调用，value的hashCode为：" + value.GetHashCode());
            //注意,访问器中实际包含了一个名为value的隐含参数
            //该参数的值即为客户程序调用+=时传递过来的delegate
            if (value != null)
            {
                m_Handler = value;
            }
        }
        //移除访问器
        remove
        {
            Console.WriteLine("AEvent add 被调用，value的hashCode为：" + value.GetHashCode());
            //设置m_Handler为null,该事件将不再被激发
            if (value == m_Handler)
            {
                m_Handler = null;
            }
        }
    }

}

class Show
{
    /*
    static void Main() {
        MyClass obj = new MyClass();
        //创建委托
        MyEventHandler myHandler = new MyEventHandler(showEventHandler);
        myHandler += showEventHandler2;
        //将委托注册到事件
        obj.AEvent += myHandler;
        //再次激发事件
        obj.FireAEvent();

        Console.ReadKey();
    } 
    //事件处理程序
    static void showEventHandler()
    {
        Console.WriteLine("showEventHandler" );
    }
    //事件处理程序
    static void showEventHandler2()
    {
        Console.WriteLine("showEventHandler2");
    }
    */
}

