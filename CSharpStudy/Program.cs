using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //}
        public Action<float> ChangeAction;
        public Action<float> delegeate1;
        public Action<float> delegeate2;

        void ac()
        {
            ChangeAction = delegeate1 + delegeate2; //合并委托，刷新委托的赋值
            ChangeAction = delegeate1 - delegeate2;

        }

        void c(float a)
        {
        }
    }
}
