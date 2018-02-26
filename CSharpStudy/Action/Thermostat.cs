using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//为Event-Coding（事件-编码）模式使用event关键字
public class Thermostat
{
    public class TemperatureArgs:System.EventArgs
    {
        public TemperatureArgs(float newTemperature)
        {
            NewTemperature = newTemperature;
        }

        public float NewTemperature
        {
            get { return _newTemperature; }
            set { _newTemperature = value; }
        }

        private float _newTemperature;
    }

    public event EventHandler<TemperatureArgs> onTemperatureChange = delegate { };

    public float CurrentTemperature
    {
        get { return _CurrentTemperature; }
        set { _CurrentTemperature = value; }
    }

    private float _CurrentTemperature;

}
 
