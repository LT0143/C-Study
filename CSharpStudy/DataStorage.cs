using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/// <summary>
/// 152页 从文件中获取数据
/// </summary>
  public  class DataStorage
    {
      /// <summary>
      /// 写入文件
      /// </summary>
      /// <param name="employee"></param>
      public static void Store(Employee employee)
      {
        //实例化一个filestream对象，将它与一个对应的文件关联,若果此.dat文件不存在则创建，否则覆盖它
          FileStream file = new FileStream(employee.firstName+employee.lastName+".dat",FileMode.Create);
          //接着创建一个StreamWriter类，负责将文本写入filestream，数据是用writeline()方法写入的
          StreamWriter write = new StreamWriter(file);
          write.WriteLine(employee.firstName);
          write.WriteLine(employee.lastName);
          write.WriteLine(employee.salary);
          //close the StreamWriter and its stream
          write.Close();
          //FileStream 和 StreamWriter都需要关闭，避免他们在等待垃圾回收器期间，处于“不确定性打开状态”
      }

      /// <summary>
      /// 读取文件
      /// </summary>
      /// <param name="firstName"></param>
      /// <param name="lastName"></param>
      /// <returns></returns>
      public static Employee Load(string firstName, string lastName)
      {
          Employee emp = new Employee();
          //实例化一个filestream对象，将它与一个对应的文件关联,若果此.dat文件不存在则创建，否则覆盖它
          FileStream file = new FileStream(firstName + lastName + ".dat", FileMode.Open);
          //接着创建一个StreamWriter类，负责将文本写入filestream，数据是用writeline()方法写入的
          StreamReader reader = new StreamReader(file);
          emp.firstName = reader.ReadLine();
          emp.lastName = reader.ReadLine();
          emp.salary = reader.ReadLine();
          //close the StreamWriter and its stream
          reader.Close();
          //FileStream 和 StreamWriter都需要关闭，避免他们在等待垃圾回收器期间，处于“不确定性打开状态”
          return emp;
      }

    }
  public class Employee 
  {
      public string firstName;
      public string lastName;
      public string salary;

      public void Save() 
      {
          DataStorage.Store(this);
      }
      public void SetName(string firstName,string lastName)
      {
          this.firstName = firstName;
          this.lastName = lastName;
          salary = firstName + lastName;
      }
      public string GetName()
      {
          string s = "name change to" + firstName + lastName;
          return s;
      }
  }
  public class Program
  {
      static void Main()
      {
          Employee employee1;
          Employee employee2 = new Employee();
          employee2.SetName("Inigo", "Montoya");
          employee2.Save();

          employee1 = DataStorage.Load("Inigo", "Montoya");

          Console.WriteLine("{0}:{1}",employee1.GetName(),
              employee1.salary);
      }
  }


