using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrondEnd
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bocaFundacion llamarfundacionb = new bocaFundacion();
            llamarfundacionb.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bocaColores llamarcoloresb = new bocaColores();
            llamarcoloresb.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bocaTitulos llamartitulosb = new bocaTitulos();  
            llamartitulosb.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bocaEstadio llamarestadiob = new bocaEstadio();
            llamarestadiob.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            riverFundacion llamarfundacionr = new riverFundacion();
            llamarfundacionr.Show();
            this.Close();        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            riverColores llamarcoloresr = new riverColores();
            llamarcoloresr.Show();
            this.Close();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            riverTitulos llamartitulor = new riverTitulos();
            llamartitulor.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            riverEstadio llamarestadior = new riverEstadio();
            llamarestadior.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            primer_super_clasico llamarclasico = new primer_super_clasico();
            llamarclasico.Show();
            this.Close();
        }
    }
}
