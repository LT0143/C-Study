using System;
using System.Diagnostics;
 

public partial class DynamicCallMember
{
    public class CommandLineInfo
    {
        public bool Help { get; set; }
        public string Out { get; set; }
        /// <summary>
        /// 进程优先级
        /// </summary>
        private ProcessPriorityClass _priority = ProcessPriorityClass.Normal;

        public ProcessPriorityClass priority
        {
            get { return _priority; }
            set { _priority = value; }
        }
    }

}
