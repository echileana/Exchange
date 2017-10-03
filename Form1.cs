using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Globalization;

namespace Exchange
{
    public partial class Form1 : Form
    {
        ExchangeRate dulap = new ExchangeRate();
        public Form1()
        {
            InitializeComponent();
            datePicker.MaxDate = DateTime.Now;
        }

        private void btnLoad_Click(object sender, EventArgs e) ////////////////////LOAD HERE XML DOC
        {
            upperGrBox.Enabled = true;
            var myXmlUrl = ConfigurationManager.AppSettings["bnmUrl"] + datePicker.Value.ToString("dd.MM.yyyy");
            XmlDocument doc = new XmlDocument();
            doc.Load(myXmlUrl);
            Form1 getResult = new Form1();
            dulap = getResult.Deserialize(doc);

            //call the method populate drop downs
            PopulateDropDowns(dulap);

        }

        public ExchangeRate Deserialize(XmlDocument doc) /////////DESERIALIZE
        {
            ExchangeRate result = new ExchangeRate();
            XmlSerializer serializer = new XmlSerializer(typeof(ExchangeRate));//both cases

            using (XmlReader reader = new XmlNodeReader(doc))
            {

                result = (ExchangeRate)serializer.Deserialize(reader);
            }
            return result;
        }
        public void PopulateDropDowns(ExchangeRate valute)
        {
            AddMdlToValutesArray();

            foreach (var item in valute.Sertare)
            {
                boxFrom.Items.Add(item.CharCode);
                boxTo.Items.Add(item.CharCode);
            }
        }

        private void txtFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows entering numbers only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            bool response = VerifyControls();
            if (response == true)
            {
                var srcValute = GetSourceValute();
                var targetValute = GetTargetValute();
                //call convert method               
                Convert(srcValute, targetValute);
            }
            else
            {
                MessageBox.Show("You must enter an amount or choose valutes!");
            }

        }
        public decimal Convert(Sertar srcValute, Sertar targetValute)
        {
            decimal sumToConvert = decimal.Parse(txtFrom.Text);
            decimal mdlSum = (sumToConvert * srcValute.Value) / srcValute.Nominal;
            decimal convertedSum;

            if ((boxFrom.SelectedItem.ToString() != "MDL") && ((boxTo.SelectedItem.ToString() != "MDL")))
            {
                convertedSum = (mdlSum * targetValute.Nominal) / targetValute.Value;
            }
            else if(boxFrom.SelectedItem.ToString()!="MDL")
            {
                convertedSum = mdlSum;
            }else
            {
                convertedSum = (sumToConvert * targetValute.Nominal) / targetValute.Value;
            }
            txtTo.Text = convertedSum.ToString("N4");
            return convertedSum;
        }
        public Sertar GetSourceValute()
        {
            var fromValute = new Sertar();

            foreach (var valute in dulap.Sertare)
            {

                if (valute.CharCode == boxFrom.SelectedItem.ToString())
                {
                    fromValute = valute;
                }
            }
            // fromValute = dulap.Sertare[boxFrom.SelectedIndex];
            return fromValute;

        }
        public Sertar GetTargetValute()
        {
            var toValute = new Sertar();
            foreach (var valute in dulap.Sertare)
            {
                if (valute.CharCode == boxTo.SelectedItem.ToString())
                {
                    toValute = valute;
                }
            }
            return toValute;
        }
        public bool VerifyControls()
        {
            bool allActive = false;
            if ((boxTo.SelectedIndex > -1) && (boxFrom.SelectedIndex > -1) && !(txtFrom.Text.Equals("")))
            {
                allActive = true;
            }

            return allActive;
        }
        public Sertar CreateMDLValute()
        {
            Sertar valuteMDL = new Sertar();
            valuteMDL.NumCode = 498;
            valuteMDL.CharCode = "MDL";
            valuteMDL.Nominal = 1;
            valuteMDL.Name = "Leu Moldovenesc";
            valuteMDL.Value = 1.000m;

            return valuteMDL;
        }
        public void AddMdlToValutesArray()
        {
            Array.Resize(ref dulap.Sertare, dulap.Sertare.Length + 1);
            dulap.Sertare[dulap.Sertare.Length - 1] = CreateMDLValute();
        }
    }
}
