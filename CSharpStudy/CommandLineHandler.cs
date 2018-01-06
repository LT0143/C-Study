using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public class CommandLineHandler
{
    public static void Parse(string[] args, object commandLine)
    {
        string errorMsg;
        if (!TryParse(args, commandLine, out errorMsg))
        {
            throw new AccessViolationException(errorMsg);
        }
    }

    public static bool TryParse(string[] args, object commandLine, out string errorMessage)
    {
        bool success = false;
        errorMessage = null;
        foreach (string arg in args)
        {
            string option;
            if (arg[0] == '/' || arg[0] == '_')
            {
                string[] optionParts = arg.Split(new char[] { ':' }, 2); //用冒号拆成有2个字符串的字符串数组
                option = optionParts[0].Remove(0, 1);//移除第0个起第一个元素，即 '/'和 '_'
                                                     //忽略大小写获取属性值
                PropertyInfo property = commandLine.GetType().GetProperty(option, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
                if (property != null)
                {
                    if (property.PropertyType == typeof(bool))
                    {
                        property.SetValue(commandLine, true, null); //commandLine属性是BOOL的话就给他赋值true
                        success = true;
                    }
                    else if (property.PropertyType == typeof(string))
                    {
                        property.SetValue(commandLine, optionParts[1], null);
                        success = true;
                    }
                    else if (property.PropertyType.IsEnum)
                    {
                        try
                        {
                            //只有索引器第（字典或数组列表等属性）3个参数才不为null
                            property.SetValue(commandLine, Enum.Parse(typeof(ProcessPriorityClass), optionParts[1], true), null);
                            success = true;
                        }
                        catch (ArgumentException)
                        {
                            success = false;
                            errorMessage = string.Format("The option '{0}'is" + "invalid for '{1}'", optionParts[1],
                                option);
                        }
                    }
                    else
                    {
                        success = false;
                        errorMessage = string.Format("Data type '{0}'on {1} is not" + "supported.", property.PropertyType.ToString(), commandLine.GetType().ToString());
                    }
                }
                else
                {
                    success = false;
                    errorMessage = string.Format("option'{0}' is not supported.", option);
                }
            }
        }
        Console.WriteLine("success:{0}    errorMessage:{1}", success, errorMessage);
        return success;
    }
}
