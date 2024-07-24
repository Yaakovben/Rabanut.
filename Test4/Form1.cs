using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.LinkLabel;

namespace Test4
{
    public partial class Form1 : Form
    {
        XmlDocument XmlDocument = new XmlDocument();
        string patName = Directory.GetCurrentDirectory() + "\\writingBill.xml";
        public Form1()
        {
            InitializeComponent();

            if (File.Exists(patName))
            {
                try
                {
                    XmlDocument.Load(patName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("שגיאה: " + ex.Message);

                }
            }
            else
            {
                XmlNode root = XmlDocument.CreateElement("Queries");
                XmlDocument.AppendChild(root);
                ShoeAll();

            }
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            XmlNode Query = XmlDocument.CreateElement("Query");
           
            Query.AppendChild(XmlDocument.CreateElement("day")).InnerText = cmbDey.Text;
            Query.AppendChild(XmlDocument.CreateElement("dayMonth")).InnerText = cmbMonthDay.Text;
            Query.AppendChild(XmlDocument.CreateElement("month")).InnerText = cmbMonth.Text;
            Query.AppendChild(XmlDocument.CreateElement("year")).InnerText = CmbYeer.Text;
            Query.AppendChild(XmlDocument.CreateElement("result")).InnerText = txtResult.Text;

           
            XmlDocument.FirstChild.AppendChild(Query);
         
           
            ShoeAll();
        }
        private void ShoeAll()
        {
            //עבור כל הילדים של האבר הראשון שבמסמך
            
            foreach (XmlNode query in XmlDocument.FirstChild.ChildNodes)
            {
                //איפוס נתונים
                string day = "", dayMonth = "", month = "", year ="";
               
                foreach (XmlNode node in query.ChildNodes)
                {
                    
                    switch (node.Name)
                    {
                      

                        case "day":
                            if (node.InnerText == "ראשון")
                                day = "באחד בשבת";
                            if (node.InnerText == "שני")
                                day = " בשני בשבת ";
                            if (node.InnerText == "שלישי")
                                day = " בשלישי בשבת";
                            if (node.InnerText == "רביעי")
                                day = "ברביעי בשבת ";
                            if (node.InnerText == "חמישי")
                                day = "בחמישי בשבת";
                            if (node.InnerText == "שישי")
                                day = " בששי בשבת";
                            break;

                        case "dayMonth":
                            if (node.InnerText == "1")
                                dayMonth = "יום אחד לירח" ;
                            if (node.InnerText == "2")
                                dayMonth = "שני ימים לירח";
                            if (node.InnerText == "3")
                                dayMonth = "שלשה ימים לירח";
                            if (node.InnerText == "4")
                                dayMonth = "ארבעה ימים לירח";
                            if (node.InnerText == "5")
                                dayMonth = "חמשה ימים לירח";
                            if (node.InnerText == "6")
                                dayMonth = "ששה ימים לירח ";
                            if (node.InnerText == "7")
                                dayMonth = "שבעה ימים לירח";
                            if (node.InnerText == "8")
                                dayMonth = "שמונה ימים לירח";
                            if (node.InnerText == "9")
                                dayMonth = "תשעה ימים לירח";
                            if (node.InnerText == "10")
                                dayMonth = "עשרה ימים לירח";
                            if (node.InnerText == "11")
                                dayMonth = "אחד עשר יום לירח";
                            if (node.InnerText == "12")
                                dayMonth = "שנים עשר יום לירח";
                            if (node.InnerText == "13")
                                dayMonth = "שלושה עשר יום לירח";
                            if (node.InnerText == "14")
                                dayMonth = "ארבעה עשר יום לירח";
                            if (node.InnerText == "15")
                                dayMonth = "חמשה עשר יום לירח";
                            if (node.InnerText == "16")
                                dayMonth = "ששה עשר יום לירח";
                            if (node.InnerText == "17")
                                dayMonth = "שבעה עשר יום לירח";
                            if (node.InnerText == "18")
                                dayMonth = "שמונה עשר יום לירח";
                            if (node.InnerText == "19")
                                dayMonth = "תשעה עשר יום לירח";
                            if (node.InnerText == "20")
                                dayMonth = " עשרים יום לירח";
                            if (node.InnerText == "21")
                                dayMonth = "אחד ועשרים יום לירח";
                            if (node.InnerText == "22")
                                dayMonth = "שנים ועשרים יום לירח";
                            if (node.InnerText == "23")
                                dayMonth = "שלושה ועשרים יום לירח";
                            if (node.InnerText == "24")
                                dayMonth = "ארבעה ועשרים יום לירח";
                            if (node.InnerText == "25")
                                dayMonth = "חמשה ועשרים יום לירח";
                            if (node.InnerText == "26")
                                dayMonth = "ששה ועשרים יום לירח";
                            if (node.InnerText == "27")
                                dayMonth = "שבעה ועשרים יום לירח";
                            if (node.InnerText == "28")
                                dayMonth = "שמונה ועשרים יום לירח";
                            if (node.InnerText == "29")
                                dayMonth = "תשעה ועשרים יום לירח";
                            if (node.InnerText == "30")
                                dayMonth = "יום שלושים לחודש" ;
                            break;

   
                        case "month":
                            month = node.InnerText;
                         

                            break;
                        case "year":
                            if (node.InnerText == "תשפד")
                                year = "חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם";
                            if (node.InnerText == "תשפה")
                                year = "חמשת אלפים ושבע מאות ושמנים וחמש לבריאת העולם";
                            if (node.InnerText == "תשפו")
                                year = "חמשת אלפים ושבע מאות ושמנים ושש לבריאת העולם";
                            if (node.InnerText == "תשפז")
                                year = "חמשת אלפים ושבע מאות ושמנים ושבע לבריאת העולם";
                            break;

                           



                    }
                    
                }
                txtResult.Text = day+ " " + dayMonth + " " + month + " " + year;
                query.SelectSingleNode("result").InnerText = txtResult.Text;
                XmlDocument.Save(patName);


            }
        }

    }
}
