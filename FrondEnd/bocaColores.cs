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
    public partial class bocaColores : Form
    {
        Boca verc = new Boca();

        public bocaColores()
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

        private void azulyamarillo_Tick(object sender, EventArgs e)  
        {
            if (txcolor.BackColor == Color.MediumBlue)
            {
                txcolor.BackColor = Color.Yellow;
            }
            else if (txcolor.BackColor == Color.Yellow)
            {
                txcolor.BackColor = Color.MediumBlue;
            }
        }
    }
}
