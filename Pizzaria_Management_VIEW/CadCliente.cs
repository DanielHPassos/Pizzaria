using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Model;
using DAL;

namespace Pizzaria_Management_VIEW
{
    public partial class CadCliente : Form
    {
        public CadCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDAL cdal = new ClienteDAL();
                Cliente c = new Cliente();
                c.nm_Cliente = textBox1.Text;
                c.ds_Endereco = textBox2.Text;
                c.dt_Nascimento = dateTimePicker1.Value;
                c.cd_TelResidencial = maskedTextBox1.Text;
                c.cd_TelCelular = maskedTextBox2.Text;
                cdal.InserirCliente(c);
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
            
        }
    }
}
