using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proj.Domain;

namespace Proj.FormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FutbolContext ctx = new FutbolContext();
            List<Country> deger = ctx.Countries.ToList();
            foreach (var item in ctx.Countries)
            {
                MessageBox.Show(item.Ad);
            }
        }
    }
}
