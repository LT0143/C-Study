using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


interface IReadableSettingsProvider
{
    string GetSetting(string name,string DefaultValue);
}


/// <summary>
/// 派生接口
/// </summary>
interface IWriteableSettingProvider:IReadableSettingsProvider
{
    void SetSetting(string name, string value);
}

public class FileSettingProvider : IWriteableSettingProvider
{
    #region ISettingProvider
   public void SetSetting(string name, string value)
    {
 
    }
    #endregion

    #region IReadableSettingsProvider
    //在显示实现接口成员时，使用的完全限定接口成员接口名称中，必须引用最初声明它的那个接口的名称
   //下面这种实现编译会报错 “FileSettingProvider”不实现接口成员“IReadableSettingsProvider.GetSetting(string, string)”,错误	3	显式接口声明中的“ISettingProvider.GetSetting”不是接口成员

   //string ISettingProvider.GetSetting(string name, string DefaultValue)
   //{
   //    return "";

   //}
   public string GetSetting(string name, string DefaultValue)
   {
       return "";
   }
    #endregion
}
 
