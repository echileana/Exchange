using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Configuration;
using System.Net;
using System.Xml.Serialization;

namespace Exchange
{
    [XmlRoot("ValCurs")]

  public  class ExchangeRate //dulap
    {
        [XmlElement("Valute")]
        public Sertar[] Sertare;
        //un array de tip sertar care contine sertare
      //  public Valute[] Valutes; 
      //type ->Valute
      //variable name -> Valutes


    }
}
