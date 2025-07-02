using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AeigisAPI;
using Guna.UI2.WinForms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AeigisAPI.Module.Execute(richTextBox1.Text);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AeigisAPI.Module.Inject();
        }
    }
}
