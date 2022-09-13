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
    public partial class riverColores : Form
    {
        River verc = new River();
        public riverColores()
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
            txtmostrarc.Text = verc.colores();
        }

        private void rojoyblanco_Tick(object sender, EventArgs e)
        {
            if (txcolores.BackColor == Color.White)
            {
                txcolores.BackColor = Color.Red;
            }
            else if (txcolores.BackColor == Color.Red)
            {
                txcolores.BackColor = Color.White;
            }
        }
    }
}
