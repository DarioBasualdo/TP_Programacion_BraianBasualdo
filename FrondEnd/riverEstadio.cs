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
    public partial class riverEstadio : Form
    {
        River vere = new River();
        public riverEstadio()
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
            txtmostrare.Text = vere.estadio();
        }
    }
}
