using Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AnketV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DAL.Context db = new DAL.Context();
        private void button2_Click(object sender, EventArgs e)
        {
            Soru soru = new Soru();
            soru.SoruCumlesi = textBox2.Text;
            db.Sorular.Add(soru);
            db.SaveChanges();
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SorularıYenile();
        }
        public void SorularıYenile()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.Sorular.ToList();
          //  flowLayoutPanel1.AutoScroll = true;   kaydırma çubuğu veriyor.
            foreach (Soru soru in db.Sorular)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Text = soru.SoruCumlesi;
                flowLayoutPanel1.Controls.Add(lbl);

                RadioButton r1 = new RadioButton();
                r1.Text = "Evet";
              //  flowLayoutPanel1.Controls.Add(r1);

                RadioButton r2 = new RadioButton();
                r2.Text = "Hayır";
          //      flowLayoutPanel1.Controls.Add(r2);
                flowLayoutPanel1.SetFlowBreak(r2, true);



                FlowLayoutPanel p = new FlowLayoutPanel();
                p.Width = 300;
                p.Height = 100;
                p.Controls.Add(r1);
                p.Controls.Add(r2);
                flowLayoutPanel1.Controls.Add(p);


            }
            }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
