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
    public partial class frmObtener_Letras : Form
    {
        string form1;
       
        public frmObtener_Letras(string t)
        {
            InitializeComponent();
            form1 = t;
            for (int i = 1; i < t.Length; i++)
            {
                cmbInicial.Items.Add(i);
            }
            cmbInicial.Text = "";
            
        }

        private void frmObtener_Letras_Load(object sender, EventArgs e)
        {            
        }
               
        private void btnCopiar_Click(object sender, EventArgs e)
        {
            string texto1 = "";
            int pos = cmbInicial.SelectedIndex;
            var chars = form1.ToCharArray();
            int tam = Convert.ToInt32(cmbCopiar.SelectedItem);
            for (int i = pos; i < tam; i++)
            {
                texto1 += chars[i].ToString();
            }
            string texto2 = form1;
            Form1 ventana = new Form1(texto1, texto2);
            ventana.Show();           
        }
       
        private void cmbInicial_SelectedIndexChanged(object sender, EventArgs e)
        {            
            cmbCopiar.Items.Clear();
            int pos = cmbInicial.SelectedIndex +1;
            var cadena = form1.ToCharArray();
            int tam = cadena.Length +1;
            for (int x = pos; x < tam; x++)
                cmbCopiar.Items.Add(x);
        }
    }
}
