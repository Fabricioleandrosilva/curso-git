using Exercicio_Banco.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Exercicio_Banco
{
    public partial class FBanco : Form
    {
        public FBanco()
        {
            InitializeComponent();
            

        }
        Conta C = new Conta();
        private void Bgrava_Click(object sender, EventArgs e)
        {
            Double v = Double.Parse(Tbvalor.Text);
            C.ValidaInf(Tnome.Text,"S",v);
            MessageBox.Show(C.Nome);
        }

        private void FBanco_Load(object sender, EventArgs e)
        {
           
        }
    }
}
