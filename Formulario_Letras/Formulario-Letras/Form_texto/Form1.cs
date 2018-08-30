using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_texto
{
    public partial class Form1 : Form
    {        
        public Form1(string text1, string text2)
        {
            InitializeComponent();           
            txtTextoSecundario.Text = text1;
            txtTextoPrincipal.Text = text2;
        }

        private void obtenerLetrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string t = txtTextoPrincipal.Text;
            frmObtener_Letras objeto = new frmObtener_Letras(t);
            objeto.MdiParent = this;      
            objeto.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTextoPrincipal_TextChanged(object sender, EventArgs e)
        {
            for (int x = 0; x < txtTextoPrincipal.TextLength; x++)
                lblcontador.Text = x.ToString();
        }

        private void lblcontador_Click(object sender, EventArgs e)
        {
            lblcontador.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
