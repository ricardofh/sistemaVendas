using sistemaVendas.BLLClasses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaVendas.Methods
{
    class clienteDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region selecionar dados do banco
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tbl_client";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion

        #region Inserir dados no banco
        public bool Insert(clienteBLL cl)
        {
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO tbl_client(type, name, email, contact, address, " +
                    "added_date, added_by) VALUES(@type, @name, @email, @contact, @address, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@type",cl.type);
                cmd.Parameters.AddWithValue("@name", cl.name);
                cmd.Parameters.AddWithValue("@email", cl.email);
                cmd.Parameters.AddWithValue("@contact", cl.contact);
                cmd.Parameters.AddWithValue("@address", cl.address);
                cmd.Parameters.AddWithValue("@added_date", cl.added_date);
                cmd.Parameters.AddWithValue("@added_by", cl.added_by);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSucces;
        }
        #endregion

        #region Atualizar dados do banco
        public bool Update(clienteBLL cl)
        {
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE tbl_client SET type=@type, name=@name, email=@email, contact=@contact, address=@address, added_date=@added_date, " +
                    "added_by=@added_by WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@type",cl.type);
                cmd.Parameters.AddWithValue("@name", cl.name);
                cmd.Parameters.AddWithValue("@email", cl.email);
                cmd.Parameters.AddWithValue("@contact", cl.contact);
                cmd.Parameters.AddWithValue("@address", cl.address);
                cmd.Parameters.AddWithValue("@added_date", cl.added_date);
                cmd.Parameters.AddWithValue("@added_by", cl.added_by);
                cmd.Parameters.AddWithValue("@id", cl.id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSucces;
        }
        #endregion

        #region Deletar dados do banco
        public bool Delete(clienteBLL cl)
        {
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM tbl_client WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", cl.id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSucces;
        }

        internal DataTable Search()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Pesquisa
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tbl_client WHERE id LIKE '%" + keywords + "%' or type LIKE '%" + keywords + "%' or name LIKE '%" + keywords + "%' or email LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion

        #region Pesquisa Cliente e Revendedor
        public clienteBLL SearchClientForTransaction(string keywords)
        {
            clienteBLL ct = new clienteBLL();

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT name, email, contact, address from tbl_client WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    ct.name = dt.Rows[0]["name"].ToString();
                    ct.email = dt.Rows[0]["email"].ToString();
                    ct.contact = dt.Rows[0]["contact"].ToString();
                    ct.address = dt.Rows[0]["address"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return ct;
        }
        #endregion
    }
}
