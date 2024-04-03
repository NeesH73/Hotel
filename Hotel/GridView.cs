using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Hotel
{
    public class GridView
    {
        public string Stringmy = @"server=localhost;port=3306;username=root;password=root;database=hotel";
        public DataTable MySqlReturnData(string quary, DataGridView grid)
        {
            try
            {
                using (MySqlConnection myCon = new MySqlConnection(Stringmy))
                {
                    myCon.Open();
                    if (myCon.State != ConnectionState.Open)
                    {
                        return null;
                    }
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(quary, myCon))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        grid.DataSource = dt;
                        return dt;
                    }
                }
            }
            catch (MySqlException ex)
            { return null; }
        }
    }
}
