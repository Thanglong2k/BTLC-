using System.Data.SqlClient;


namespace DAL
{
    public class DBConnect
    {
        public SqlConnection Connection()
        { 
            SqlConnection _conn = new SqlConnection(@"Data Source = DESKTOP-LI5H2JJ\SQLEXPRESS;
            Initial Catalog = QLGA; Persist Security Info=True;User ID=sa;Password=123");
            return _conn;
        }
        
    }
}
