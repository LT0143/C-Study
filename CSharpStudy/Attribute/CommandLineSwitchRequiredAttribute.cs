using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


public class CommandLineSwitchRequiredAttribute:Attribute
{
    public CommandLineSwitchRequiredAttribute(string alias)
    {
        
    }

    public string Alias
    {
        get { return _Alias; }
        set { _Alias = value;    }
    }
    private string _Alias;

    public static Dictionary<string, PropertyInfo> GetSwitches(object commandLine)
    {
        PropertyInfo[] properties = null;
        Dictionary<string,PropertyInfo> options = new Dictionary<string, PropertyInfo>();
        //BindingFlags.Instance 搜索成员实例，包括字段及方法等
        properties = commandLine.GetType().GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        foreach (PropertyInfo property in properties)
        {
            options.Add(property.Name.ToLower(),property);
            foreach (CommandLineSwitchRequiredAttribute attribute in property.GetCustomAttributes(typeof(CommandLineSwitchRequiredAttribute),false))
            {
                options.Add(attribute.Alias.ToLower(),property);
            }
        }
        return options;
    }
}

//使用AttributeUsage限制特效的使用，还可以指定是否允许特效在一个构造上进行多次复制 P489
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
public class CommandLineSwitchAiasAttribute :Attribute
{

}
 
