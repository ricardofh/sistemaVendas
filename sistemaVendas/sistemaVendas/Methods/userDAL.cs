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
    class userDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        #region selecionar dados do banco
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tbl_users";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
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
        public bool Insert(userBLL u)
        {
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO tbl_users(first_name, last_name, email, username, password, contact, adress, " +
                    "user_type, added_date, added_by, gender) VALUES(@first_name, @last_name, @email, @username, @password, " +
                    "@contact, @adress, @user_type, @added_date, @added_by, @gender)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@adress", u.adress);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@gender", u.gender);



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
            catch(Exception ex)
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
        public bool Update(userBLL u)
        {
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE tbl_users SET first_name=@first_name, last_name=@last_name, email=@email, username=@username," +
                    "password=@password, contact=@contact, adress=@adress, user_type=@user_type, added_date=@added_date, " +
                    "added_by=@added_by, gender=@gender WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@adress", u.adress);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@id", u.id);

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
        public bool Delete(userBLL u)
        {
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM tbl_users WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", u.id);

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
                String sql = "SELECT * FROM tbl_users WHERE id LIKE '%" + keywords + "%' or first_name LIKE '%" + keywords + "%' or last_name LIKE '%" + keywords + "%' or username LIKE '%" + keywords + "%'";
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
    }
}
