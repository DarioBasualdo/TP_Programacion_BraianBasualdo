using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd;

namespace FrondEnd
{
    public partial class riverTitulos : Form
    {
        River vert = new River();
        public riverTitulos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu llamarmenu = new Menu();
            llamarmenu.Show();
            this.Close();
        }

        private void btinformacionf_Click(object sender, EventArgs e)
        {
            txtmostrart.Text = vert.titulos();
        }
    }
}
