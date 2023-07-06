using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__8
{
    public enum TransformatorType { Multiplier, Divider }

    public class TactileSensor
    {
        public double Sensitivity { set; get; }
    }

    public class GentleSmartphone
    {
        public TactileSensor Sensor;
        public int SerialNumber { set; get; }
        public GentleSmartphone()
        {
            Sensor = new TactileSensor();
        }
    }

    public class Transformator
    {

        public TransformatorType TransformType { set; get; }
    }

    public class Customer
    {
        public string? FullName { set; get; }
        public double GentelRate { set; get; }
        public GentleSmartphone? Smartphone { set; get; }
        public Transformator? TransformModule { set; get; }
    }

    public class Factory
    {
        public List<GentleSmartphone> Smartphones = new List<GentleSmartphone>();
        public List<Customer> Customers = new List<Customer>();
        public string SaleSmartphone()
        {
            string fs = "-------------------\n";
            var tr = (TransformatorType)0;
            for (int i = 0; i < Smartphones.Count; i++)
            {
                for (int j = 0; j < Customers.Count; j++)
                {
                    if (Smartphones[i].Sensor.Sensitivity < Customers[j].GentelRate)
                    {
                        if (Customers[j].GentelRate / Smartphones[i].Sensor.Sensitivity <= 2.0)
                        {
                            fs += $"Смартфон №{Smartphones[i].SerialNumber} Продан покупателю: {Customers[j].FullName}\n";
                            Smartphones.Remove(Smartphones[i]);
                            Customers.Remove(Customers[j]);
                            j -= 1;
                        }
                        else if (Customers[j].GentelRate / (Smartphones[i].Sensor.Sensitivity * 2.0) <= 2.0)
                        {
                            tr = (TransformatorType)0;
                            fs += $"Смартфон №{Smartphones[i].SerialNumber} c ТТ:{tr} Продан покупателю: {Customers[j].FullName}\n";
                            Smartphones.Remove(Smartphones[i]);
                            Customers.Remove(Customers[j]);
                            j -= 1;
                        }
                    }
                    else
                        {
                        if (Smartphones[i].Sensor.Sensitivity / Customers[j].GentelRate <= 1.5)
                        {
                            fs += $"Смартфон №{Smartphones[i].SerialNumber} Продан покупателю: {Customers[j].FullName}\n";
                            Smartphones.Remove(Smartphones[i]);
                            Customers.Remove(Customers[j]);
                            j -= 1;
                        }
                        else if ((Smartphones[i].Sensor.Sensitivity / 2.0) / Customers[j].GentelRate <= 1.5)
                        {
                            tr = (TransformatorType)1;
                            fs += $"Смартфон №{Smartphones[i].SerialNumber} c ТТ:{tr} Продан покупателю: {Customers[j].FullName}\n";
                            Smartphones.Remove(Smartphones[i]);
                            Customers.Remove(Customers[j]);
                            j -= 1;
                        }
                    }
                }
            }
            fs += "-------------------";
            if (Customers.Count == 0)
            {
                for (int i = 0; i < Smartphones.Count; i++)
                {
                    Smartphones.Remove(Smartphones[i]);
                    i -= 1;
                }
            }
            return fs;
        }
    }
}
