using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class ManyToMany
{
    /*
    static void Main()
    {
        IEnumerable<LinqEmployee> employees = CorporateData.Employees;
        IEnumerable<Department> departments = CorporateData.Departments;
        //PrintTool.PrintIEnumerable(employees);
        Console.WriteLine();
        //PrintTool.PrintIEnumerable(departments);
        //使用join进行内部联接,join第一个参数称为inner，指定employees要联接到的集合（即employees）。后面两个参数都是lambda表达式，指定了两个集合如何联接
        //employee => employee.DepartmentId，指出每个employee的key是DepartmentId。
        //department => department.Id，将id作为key，每个员工都联接到employee.DepartmentId=department.Id的一个部门。
        //最后一个参数是匿名类型，描述如何对结果进行选取，Department用于存储联接的department对象
        var items = employees.Join(departments, employee => employee.DepartmentId, department => department.Id,
            (employee, department) => new
            {
                employee.Id,
                employee.Name,
                employee.Title,
                Department = department
            });

        foreach (var item in items)
        {
            Console.WriteLine("{0}({1})", item.Name, item.Title);
            Console.WriteLine("\t" + item.Department);
        }

        //对数据进行分组(employee) => employee.DepartmentId是分组的依据
        IEnumerable<IGrouping<int, LinqEmployee>> groupedEnumerables =
            employees.GroupBy((employee) => employee.DepartmentId);

        foreach (var groupedEnumerable in groupedEnumerables)
        {
            Console.WriteLine();
            foreach (LinqEmployee employee in groupedEnumerable)
            {
                Console.WriteLine("\t" + employee);
            }
            Console.WriteLine("\t count " + groupedEnumerable.Count());
        }
    }
    */
}

/// <summary>
/// 以部门和员工的多对多关系为例
/// </summary>
public class Department
{
    /// <summary>
    /// 部门ID
    /// </summary>
    public long Id { get; set; } 
    public string Name { get; set; }

    public override string ToString()
    {
        return string.Format("{0}({1})", Id, Name);
    }
}

/// <summary>
/// 员工数据
/// </summary>
public class LinqEmployee
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public int DepartmentId { get; set; }

    public override string ToString()
    {
        return string.Format("{0}({1})",  Name,Title);
    }
}

/// <summary>
/// 公司数据
/// </summary>
public static class CorporateData
{
    public static readonly Department[] Departments =
    {
        new Department() {Name = "c", Id = 0},
        new Department() {Name = "f", Id = 1},
        new Department() {Name = "e", Id = 2},
    };

    public static readonly LinqEmployee[] Employees =
  {
        new LinqEmployee() {Name = "mm", Title = "ccn",DepartmentId = 0},
        new LinqEmployee() {Name = "ms", Title = "scw",DepartmentId = 2},
        new LinqEmployee() {Name = "bj", Title = "eig",DepartmentId = 2}
    };
}