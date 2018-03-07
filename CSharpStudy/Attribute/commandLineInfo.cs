using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;



public class commandLineInfo
{
    //[commandlineSwitchAlias("?")]
    public bool Help
    {
        get { return _Help; }
        set {  _Help = value; }
    }
    private bool _Help;

    //[commandlineSwitchAlias("fileName")]
    [CommandLineSwitchRequired("aa")]
    public string Out
    {
        get { return _Out; }
        set { _Out = value; }
    }

    private string _Out;

    public System.Diagnostics.ProcessPriorityClass Priority
    {
        get { return _Priority; }
        set { _Priority = value; }
    }

    private System.Diagnostics.ProcessPriorityClass _Priority = System.Diagnostics.ProcessPriorityClass.Normal;
}

 


