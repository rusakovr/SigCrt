using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace SigCrt
{
    class Element
    {
        private string name;
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        private double elementValue;
        public double Value
         {
            set
            {
                elementValue = value;
            }
            get
            {
                return elementValue;
            }
        }
        private string type;
        public string Type
        {
            set
            {
                Regex regex = new Regex("R|C|OpAmp");
                if (regex.IsMatch(value))
                {
                    type = value;
                }
                else
                {
                    Console.WriteLine("Wrong type name in netlist");
                }
            }
            get
            {
                return type;
            }
        }
    }
}
