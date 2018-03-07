using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


public class CommandLineHander
{
    // 要为必需的参数提供只能取值的属性（提供私有赋值函数）。要提供构造器参数来初始化与必需的参数对应的属性。每个参数的名称都应该和对应的属性同名
    //避免提供构造器参数来初始化与可选参数对应的属性
    public static bool TryParse(string[] args, object commandLine, out string errorMsg )
    {
        bool success = false;
        errorMsg = null;

        Dictionary<string, PropertyInfo> options =  CommandLineSwitchRequiredAttribute.GetSwitches(commandLine);

        foreach (string arg in args)
        {
            PropertyInfo property;
            string option;
            Console.WriteLine(arg[0]);
            if (arg[0] == '/' || arg[0] == '_')
            {
                string[] optStrings = arg.Split(new char[] {':'}, 2);//以冒号划分成2段
                option = optStrings[0].Remove(0, 1).ToLower();

                if (options.TryGetValue(option, out property))
                {
                    success = SetOption(commandLine, property, optStrings, ref errorMsg);

                }
                else
                {
                    success = false;
                    errorMsg = string.Format("Option '{0}' is not surpported.", option);
                }
            }
        }
        return success;
    }

    private static bool SetOption(object commandLine,PropertyInfo property, string[] optionParts,ref string errorMsg)
    {
        bool success = false;
        if(property.PropertyType == typeof(bool))
        {
            property.SetValue(commandLine,true,null);
            success = true;
        }
        else
        {
            if(optionParts.Length <2 || optionParts[1] ==""|| optionParts[1] == ":")
            {
                success = false;
                errorMsg = string.Format("you must specify the value for the {0} option.", property.Name);
                
            }
            else if(property.PropertyType == typeof(string))
            {
                property.SetValue(commandLine, optionParts[1], null);
                success = true;
            }
            else if (property.PropertyType.IsEnum)
            {
                Console.WriteLine("property.PropertyType.IsEnum");
                //success = TryParseEnumSwitch(commandLine,optionParts,property,ref errorMsg);
            }
            else  
            {
                success = false;
                errorMsg = string.Format("Data type '{0}' on {1} is not supported.", property.PropertyType,commandLine.GetType());
            }
        }
        return success;
    }
}

