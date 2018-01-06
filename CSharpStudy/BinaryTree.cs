using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 声明接口约束
/// </summary>
/// <typeparam name="T"></typeparam>
public class BinaryTree2<T> where T : System.IComparable<T>
{
    private Pair<BinaryTree<T>> _SubItems;   //二叉树
    public Pair<BinaryTree<T>> SubItems
    {
        get { return _SubItems; }
        set
        {
            IComparable<T> first;
            first = value.First.Item;
            if (first.CompareTo(value.Second.Item) < 0)
            {
                Console.WriteLine("first.CompareTo(value.Second.Item) < 0");
            }
            else
            {
                Console.WriteLine("first.CompareTo(value.Second.Item) >= 0");
            }
            _SubItems = value;
        }
    }
}


public class BinaryTree<T>
{
    public BinaryTree(T item)
    {
        Item = item;
    }

    private T _Item;

    public T Item
    {
        get { return _Item; }
        set { _Item = value; }
    }

    public Pair<BinaryTree<T>> _SubItems;

    public Pair<BinaryTree<T>> SubItems
    {
        get { return _SubItems; }
        set
        {
            IComparable<T> first;
            first = (IComparable<T>) value.First.Item; //需类型参数实现接口IComparable<T>
            if (first.CompareTo(value.Second.Item) < 0)
            {
                Console.WriteLine("first.CompareTo(value.Second.Item) < 0");
            }
            else
            {
                Console.WriteLine("first.CompareTo(value.Second.Item) >= 0");
            }
            _SubItems = value;
        }
    }

}

