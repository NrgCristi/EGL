using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EGL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Path = System.IO.Path.Combine(this.textBox3.Text, "FortniteGame/Binaries/Win64/FortniteLauncher.exe");
            string args = "-AUTH_LOGIN=" + textBox1.Text + " -AUTH_PASSWORD=" + textBox2.Text + " -AUTH_TYPE=exchangecode";
            System.Diagnostics.Process.Start(Path, args);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://rebrand.ly/authcode");
        }
    }
}
