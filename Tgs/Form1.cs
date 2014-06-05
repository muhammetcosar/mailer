using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Tgs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List();
        }
        public void List()
        {
            cbProgram.DataSource = Db.ProgramListGet();

        }
        public void activiList()
        {
            Guid programid = new Guid(cbProgram.SelectedValue.ToString());
            cbactivities.DataSource = Db.ActivitiesListGet(programid);
        }
        public void activityMail()
        {
            Guid activityid = new Guid(cbactivities.SelectedValue.ToString());
            lbMail.DataSource = Db.ActivityMailListGet(activityid);
            lbMailCount.Text = this.lbMail.Items.Count.ToString();
        }

        public void Gonder()
        {
            List<MLog> logs = new List<MLog>();

            var coursename=cbactivities.Text.ToString();
            var cdate = DateTime.Now.ToShortDateString();

            foreach (ActivityMail item in this.lbMail.Items)
            {
                    var body = Mailer.Template("tgs");

                    body = body.Replace("{NAME}", item.NAME);
                    body = body.Replace("{SURNAME}", item.SURNAME);
                    body = body.Replace("{USERNAME}", item.USERNAME);
                    body = body.Replace("{IDENTITYNUMBER}", item.IDENTITYNUMBER);
                    body = body.Replace("{COURSENAME}", coursename);
                    body = body.Replace("{CDATE}", cdate);
                    string smessage = string.Empty;
                    var sended = Mailer.SendMail(body, item.NAME, item.SURNAME, item.EMAIL,ref smessage);


                    logs.Add(new MLog()
                    {
                        Name = item.NAME,
                        Surname = item.SURNAME,
                        Date = DateTime.Now.ToString(),
                        Body = body,
                        MAdress = item.EMAIL,
                        Sended = sended,
                        SendedMessage = smessage
                    });
            }
            Log(logs, coursename);


        }
        public void Log(List<MLog> logs,string coursename)
        {
            var date = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
            var lpath = @"D:\Tgs\Tgs\Log\" + coursename + "_" + date + ".xml";
            
             var xlogs = logs.Select(t=> 
                new XElement("Log",
                    new XAttribute("Name",t.Name),
                    new XAttribute("Surname",t.Surname),
                    new XAttribute("MAdress",t.MAdress),
                    new XAttribute("Date",t.Date),
                    new XAttribute("Sended",t.Sended),
                     new XElement("SendedMessage",new XCData(t.SendedMessage))
                    )
                ).ToList();



             var xdoc = new XDocument(
                 new XDeclaration("1.0", "utf-8", "yes"),
                 new XElement("Logs",
                     new XAttribute("Date", date),
                     xlogs)); 

            xdoc.Save(lpath);
        }

        private void cbactivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            activityMail();
        }

        private void cbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            activiList();
        }

        private void mailgonder_Click(object sender, EventArgs e)
        {
            Gonder();
        }
        //public void xml(string name, string surname, string mail)
        //{

        //    var lpath = @"D:\Tgs\Tgs\Log\";

        //    var saat = DateTime.Now.ToLongTimeString();
        //    var tarih = DateTime.Now.ToShortDateString();
        //    var url = @"D:\Tgs\Tgs\dosya.xml";
        //    var doc = XDocument.Load(url);
        //    var rootElement = doc.Root;
        //    var newElement = new XElement("Bilgiler");
        //    var idAttribute1 = new XAttribute("Name", name);
        //    var idAttribute2 = new XAttribute("Surname", surname);
        //    var idAttribute3 = new XAttribute("Mail", mail);
        //    var idAttribute4 = new XAttribute("Saat", saat);
        //    var idAttribute5 = new XAttribute("Tarih", tarih);
        //    newElement.Add(idAttribute1, idAttribute2, idAttribute3, idAttribute4, idAttribute5);
        //    rootElement.Add(newElement);
        //    doc.Save(url);
        //}
       
    }
}
