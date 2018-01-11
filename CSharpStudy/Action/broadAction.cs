using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class broadAction
{
  static  Action<object> objAction =
(object data) =>
{
    Console.WriteLine(data);
};
  static  Action<string> strActino = objAction;

  static  Func<string> strFunc = () => Console.ReadLine();

    Func<object> objFunc = strFunc;

    public static void Main()
    {

        objAction(121);

        Console.WriteLine();


    }
 
}
 
