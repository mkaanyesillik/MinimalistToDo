using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MinimalistToDo
{
    public partial class GorevEkle : Form
    {
        public GorevEkle()
        {
            InitializeComponent();
        }
        public int grvid;
        
        MinimalToDo frm = new MinimalToDo();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            frm.gorevid= grvid;
            frm.GorevAdi = txtGorevAdi.Text;
            frm.GorevAciklama = txtGorevAciklama.Text;
            frm.GorevEklenmeSaati = DateTime.Now.Day.ToString() +"/"+ DateTime.Now.Month.ToString()+"/" + DateTime.Now.Year.ToString()+"-" + DateTime.Now.Hour.ToString()+":"+DateTime.Now.Minute.ToString();
            frm.GorevTahminiTamamlamaSaati = txtTahminiTamamlama.Text;
            XDocument x = XDocument.Load(@"MinimalToDo.kaan");

            x.Element("MinimalToDo").Add(
            new XElement("Gorev",
            new XElement("id", frm.gorevid.ToString()),
            new XElement("GorevAdi", frm.GorevAdi),
            new XElement("GorevAciklama", frm.GorevAciklama),
            new XElement("GorevEklenmeSaati", frm.GorevEklenmeSaati),
            new XElement("GorevTamamlanmaSaati", frm.GorevTamamlamaSaati),
            new XElement("GorevTahminiTamamlanmaSaati", frm.GorevTahminiTamamlamaSaati)
            ));
            frm.gorevid++;
            x.Save(@"MinimalToDo.kaan");
            
            this.Close();
        }
    }
}
