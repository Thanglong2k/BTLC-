using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALGeneric
    {
        static DBConnect dBConnect = new DBConnect();
        SqlConnection conn = dBConnect.Connection();
        public DataTable selectAll(string nameTB)
        {

            //SqlConnection Conn = dBConnect.Connection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + nameTB, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable selectAllByCV(string nameTB,string codeCV)
        {

            //SqlConnection Conn = dBConnect.Connection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + nameTB + " where MaCV="+ codeCV, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable selectAllProc(string sqlQuery)
        {
            SqlCommand command = new SqlCommand(sqlQuery,conn);
            command.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        
        public bool execNonQuery(string sqlQuery, SqlParameter[] sqlParameters)
        {
            try
            {
                //Conn = dbConnnectionData.HamKetNoi();
                SqlCommand command = new SqlCommand(sqlQuery, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(sqlParameters);
                // MoKetNoi();
                conn.Open();
                if (command.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                string t=e.Message;
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool ExecuteNonQuery(string execute)
        {
            
            try
            {

                //kết nối
                conn.Open();
                //query string:execute
                //command
                SqlCommand cmd = new SqlCommand(execute, conn);
                //query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                //đóng kết nối
                conn.Close();
            }
            return false;
        }

        public bool ExecuteNonQueryIMG(string execute,byte[] img)
        {
            //SqlConnection conn = dBConnect.Connection();
            try
            {

                //kết nối
                conn.Open();
                //query string:execute
                //command

                SqlCommand cmd = new SqlCommand(execute, conn);
                cmd.Parameters.AddWithValue("@Anh", img);
                //query và kiểm tra
                if (cmd.ExecuteNonQuery()>0)
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                //đóng kết nối
                conn.Close();
            }
            return false;
        }
        /*public DataTable selectAllSearch1(string nameTB)
        {

           // SqlConnection Conn = dBConnect.Connection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + nameTB + " where ", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }*/

        public DataSet rpDataset(string namePR,SqlParameter[] sql)
        {
            SqlCommand command = new SqlCommand(namePR, conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(sql);
            command.Connection = conn;

            conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(command);
            dap.Fill(ds);
            conn.Close();
            return ds;
        }

        
    }
}
