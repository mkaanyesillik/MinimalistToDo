using System;
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
using System.Xml.Linq;

namespace MinimalistToDo
{
    public partial class MinimalToDo : Form
    {
        public MinimalToDo()
        {
            InitializeComponent();
        }

        #region değişkenler
        int i = 0;//ilk açılışta ki ekran sayacı
        int gizlegoster = 0;//içeri girerken ki ekran sayacı
        int k = 0;//butona gizle veya göster özelliğini verebilmek için eklenen trigger
        int ekrangenisligi = Screen.PrimaryScreen.Bounds.Width;
        public string GorevAdi;
        public string GorevAciklama;
        public string GorevEklenmeSaati;
        public string GorevTamamlamaSaati;
        public string GorevTahminiTamamlamaSaati;
        public int gorevid = 1;
        #endregion

        private void MinimalToDo_Load(object sender, EventArgs e)
        {
            tmrRefresh.Start();
            #region gizle göster
            if (k == 0)
            {
                tmrStartPosition.Start();
                k = 1;
            }
            else
            {
                tmrGizle.Start();
            }
            #endregion
            this.Size = new System.Drawing.Size(400, Screen.PrimaryScreen.Bounds.Height);//yukarıdan aşağı tüm ekranı kaplasın diye yazıldı.
            #region Formun şeffaflığı
            this.BackColor = Color.Beige;
            this.TransparencyKey = Color.Beige;
            #endregion

            GorevAdi = "iş";
            GorevAciklama = "Aciklama";
            GorevEklenmeSaati = "Saat";
            GorevTamamlamaSaati = "Saat";
            GorevTahminiTamamlamaSaati = "Saat";
            XmlOku();
        }
        public void XmlOku()
        {
            if (File.Exists(@"MinimalToDo.xml") == true)
            {

                XmlDocument i = new XmlDocument();
                DataSet ds = new DataSet();
                //xml dosyamızı okumak için bir reader oluşturuyoruz.
                XmlReader xmlFile;

                xmlFile = XmlReader.Create(@"MinimalToDo.xml", new XmlReaderSettings());
                //içeriği Dataset e aktarıyoruz.
                ds.ReadXml(xmlFile);
                //datagridviewin kaynağı olarak dataseti gösteriyoruz.
                dataGridView1.DataSource = ds.Tables[0];
                //dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[0].HeaderText = "Id";
                dataGridView1.Columns[1].HeaderText = "Görev Adı";
                dataGridView1.Columns[2].HeaderText = "Görev Açıklaması";
                dataGridView1.Columns[3].HeaderText = "Eklenme Zamanı";
                dataGridView1.Columns[4].HeaderText = "Tamamlanma Zamanı";
                dataGridView1.Columns[5].HeaderText = "Tahmini Tamamlanma Süresi";
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (item.Cells["GorevTamamlanmaSaati"].Value.ToString() == "11")
                    {
                        dataGridView1.Columns[Convert.ToInt32(item.Cells["id"].Value)].Visible = false;
                    }

                }
                gorevid = Convert.ToInt32(dataGridView1.RowCount);
                xmlFile.Close();
            }
            else
            {
                XmlTextWriter yaz = new XmlTextWriter("MinimalToDo.xml", System.Text.UTF8Encoding.UTF8);
                //Daha önce bu isimle oluşturulan bir XML dosyası var ise, eski dosya silinir.
                yaz.Formatting = Formatting.Indented;
                // Dosya yapısını hiyerarşik olarak oluşturarak okunabilirliği arttırır.

                yaz.WriteStartDocument(); //Xml dökümanına ait declaration satırını oluşturur. Kısaca yazmaya başlar.
                yaz.WriteStartElement("MinimalToDo");
                yaz.WriteStartElement("Gorev");

                yaz.WriteEndElement();
                yaz.WriteEndElement();
                yaz.Close();
            }
        }
        private void tmrStartPosition_Tick(object sender, EventArgs e)
        {
            if (Location.X == Screen.PrimaryScreen.Bounds.Width - 390)
            {
                ekrangenisligi = 1530;
                k = 1;
                tmrStartPosition.Stop();
            }
            else
            {
                this.Location = new Point(ekrangenisligi - i * 5);
                i++;
            }

        }

        private void btnGizle_Click(object sender, EventArgs e)
        {
            i = 0;
            gizlegoster = 0;
            if (k == 1)
            {
                tmrGizle.Start();
            }
            else
            {
                tmrStartPosition.Start();

            }

        }

        private void tmrGizle_Tick(object sender, EventArgs e)
        {
            if (Location.X == ekrangenisligi + 350)
            {
                k = 0;
                ekrangenisligi = Screen.PrimaryScreen.Bounds.Width - 60;
                tmrGizle.Stop();
            }
            else
            {
                this.Location = new Point(ekrangenisligi + gizlegoster * 5);
                gizlegoster++;
            }
        }

        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            GorevEkle grv = new GorevEkle();

            grv.Show();
            grv.grvid = Convert.ToInt32(dataGridView1.RowCount);
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
         
            
            
        }

        private void MinimalToDo_Activated(object sender, EventArgs e)
        {
            XmlOku();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            ds.ReadXml(@"MinimalToDo.xml");
            DataTable dt = ds.Tables[0];
            string a = dataGridView1.CurrentRow.Index.ToString();//Seçili Satırı siler
            dt.Rows[Convert.ToInt32(a)].Delete();
            dt.AcceptChanges();
            ds.WriteXml(@"MinimalToDo.xml");
            XmlOku();
        }
    }
}
