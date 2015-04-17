using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
     public class ClienteDAL : Conexao
    {
        public void InserirCliente(Cliente c)
        {
            try
            {
                AbrirConexao();
                cmd = new SqlCommand("INSERT INTO Cliente (nm_Cliente,ds_Endereco,dt_Nascimento,cd_TelResidencial,cd_TelCelular) VALUES (@v1,@v2,@v3,@v4,@v5)", con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@v1", c.nm_Cliente);
                cmd.Parameters.AddWithValue("@v2", c.ds_Endereco);
                cmd.Parameters.AddWithValue("@v3", c.dt_Nascimento);
                cmd.Parameters.AddWithValue("@v4", c.cd_TelResidencial);
                cmd.Parameters.AddWithValue("@v5", c.cd_TelCelular);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        public void AtualizarCliente(Cliente c)
        {
            try
            {
                AbrirConexao();
                cmd = new SqlCommand("UPDATE Cliente SET nm_Cliente = @v1,ds_Endereco = @v2,dt_Nascimento = @v3,cd_TelResidencial = @v4,cd_TelCelular = @v5 WHERE cd_Cliente = @v6", con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@v1", c.nm_Cliente);
                cmd.Parameters.AddWithValue("@v2", c.ds_Endereco);
                cmd.Parameters.AddWithValue("@v3", c.dt_Nascimento);
                cmd.Parameters.AddWithValue("@v4", c.cd_TelResidencial);
                cmd.Parameters.AddWithValue("@v5", c.cd_TelCelular);
                cmd.Parameters.AddWithValue("@v6", c.cd_Cliente);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        public void ExcluirCliente(int x)
        {
            try
            {
                AbrirConexao();
                cmd = new SqlCommand("DELETE FROM Cliente WHERE cd_Cliente = @v1", con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@v1", x);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        public List<Cliente> BuscarClientePorID(int x)
        {
            try
            {
                AbrirConexao();
                Cliente c = new Cliente();
                List<Cliente> Clientes = new List<Cliente>();
                cmd = new SqlCommand("SELECT * FROM Cliente WHERE cd_Cliente = @v1", con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@v1", x);
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    c.cd_Cliente = Convert.ToInt32(dr["cd_Cliente"]);
                    c.nm_Cliente = dr["nm_Cliente"].ToString().Trim();
                    c.ds_Endereco = dr["ds_Endereco"].ToString().Trim();
                    c.dt_Nascimento = Convert.ToDateTime(dr["dt_Nascimento"]);
                    c.cd_TelResidencial = dr["cd_TelResidencial"].ToString().Trim();
                    c.cd_TelCelular = dr["cd_TelCelular"].ToString().Trim();
                    Clientes.Add(c);

                }
                return Clientes;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        public List<Cliente> ListarClientes()
        {
            try
            {

                AbrirConexao();
                cmd = new SqlCommand("SELECT * FROM Cliente", con);
                List<Cliente> Clientes = new List<Cliente>();
                Cliente c = null;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    c = new Cliente();
                    c.cd_Cliente = Convert.ToInt32(dr["cd_Cliente"]);
                    c.nm_Cliente = dr["nm_Cliente"].ToString().Trim();
                    c.ds_Endereco = dr["ds_Endereco"].ToString().Trim() ;
                    c.dt_Nascimento = Convert.ToDateTime(dr["dt_Nascimento"]);
                    c.cd_TelResidencial = dr["cd_TelResidencial"].ToString().Trim();
                    c.cd_TelCelular = dr["cd_TelCelular"].ToString().Trim();
                    Clientes.Add(c);
                }
                return Clientes;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
