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
    public partial class GerenciamentoCadastro : Form
    {
        ClienteDAL cdal = new ClienteDAL();
        public GerenciamentoCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> Clientes = new List<Cliente>();
                Clientes = cdal.ListarClientes();
                dataGridView1.DataSource = Clientes;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                List<Cliente> Clientes = new List<Cliente>();
                Clientes = cdal.BuscarClientePorID(x);
                dataGridView1.DataSource = Clientes.ToList();

            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        private void GerenciamentoCadastro_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = cdal.ListarClientes();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
           
        }
    }
}
