using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; //library suara
using System.Net.Security;

namespace latihan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(353, 266);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNama.Text != "")
            {
                if (tbKelas.Text != "")
                {
                    if (tbProdi.Text != "")
                    {
                        //mulai suara
                        
                        SystemSounds.Question.Play();
                        MessageBox.Show
                        ("data lengkap!",
                        "informsi data submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        //after klik button ok, seluruh form muncul
                        this.Size = new Size(353, 474);
                    }
                    else
                    {
                        MessageBox.Show
                        ("prodi belum diisi!",
                        "informsi data submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show
                    ("kelas belum diisi!",
                    "informsi data submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show
                    ("nama belum diisi!",
                    "informsi data submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }//end private void button1_Click(object sender, EventArgs e)

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                //checkBox2.Checked = false; => u/ hilangkan tanda ceklis
                //checkBox1.Enabled = true; => u/ biar bisa diklik
                checkBox1.Enabled = true;
                checkBox2.Enabled = false; checkBox2.Checked = false;
                checkBox3.Enabled = true;
               
            }
            else
            {
                checkBox1.Enabled = false; checkBox1.Checked = false;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
        }
    }
}
