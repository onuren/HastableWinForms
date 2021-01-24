using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace HastableIleWinforms
{
    public partial class Form1 : Form
    {
        Hashtable sehirler = new Hashtable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sehirler.Add("01", "Adana");
            sehirler.Add("06", "Ankara");
            sehirler.Add("26", "Eskişehir");
            sehirler.Add("34", "İstanbul");
            sehirler.Add("35", "İzmir");
            Listele();
        }

        public void Listele()
        {
            ListViewItem item = new ListViewItem();
            ICollection kod = sehirler.Keys;
            listView1.Clear();

            listView1.Columns.Add("il Kodu", 60);
            listView1.Columns.Add("İl Adı", 120);
            listView1.View = View.Details;
            listView1.GridLines = true;

            foreach (string eleman in kod)
            {
                item = listView1.Items.Add(eleman);
                item.SubItems.Add(sehirler[eleman].ToString());
            }
            listView1.Sorting = SortOrder.Ascending;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            sehirler.Add(tb_alan.Text, tb_isim.Text);
            tb_alan.Text = tb_isim.Text = "";
            Listele();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            string anahtar = tb_ara.Text;

            if (sehirler[anahtar] != null)
            {
                MessageBox.Show(sehirler[anahtar].ToString(), "Aranan değer bulundu");
            }
            else
            {
                MessageBox.Show("Bulunamadı", "Upsss");
            }
        }
    }
}
