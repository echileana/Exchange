using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exchange
{
   public  class Sertar 
    {
        [XmlAttribute]
        public int ID { get; set; }
        public int NumCode { get; set; }
        public string CharCode { get; set; }
        public int Nominal { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; } //how to read XML values as decimal knowing that decimals have the suffix m/M

    }
}
