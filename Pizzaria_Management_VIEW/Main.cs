using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Management_VIEW
{
    public partial class Main : Form
    {
        string login;
        public Main(string login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CadFuncionario = new CadFuncionario();
            panel1.Visible = false;
            CadFuncionario.MdiParent = this;
            CadFuncionario.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            label1.Text = login;
            loginToolStripMenuItem.Text += login;
            dataToolStripMenuItem.Text += DateTime.Now.ToLongDateString();//.Date.ToString().Substring(0,10);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CadCliente = new CadCliente();
            panel1.Visible = false;
            CadCliente.MdiParent = this;
            CadCliente.Show();
            
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form CadProduto = new CadProduto();
            panel1.Visible = false;
            CadProduto.MdiParent = this;
            CadProduto.Show();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form GerenciamentoPedido = new GerenciamentoPedido();
            panel1.Visible = false;
            GerenciamentoPedido.MdiParent = this;
            GerenciamentoPedido.Show();
        }

        private void cadstroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form GerenciamentoCadastro = new GerenciamentoCadastro();
            panel1.Visible = false;
            GerenciamentoCadastro.MdiParent = this;
            GerenciamentoCadastro.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form GerenciamentoEstoque = new GerenciamentoEstoque();
            panel1.Visible = false;
            GerenciamentoEstoque.MdiParent = this;
            GerenciamentoEstoque.Show();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Form pedido = new CadPedido();
            panel1.Visible = false;
            pedido.MdiParent = this;
            pedido.Show();
        }

        private void pedidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
    }
}
