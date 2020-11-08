using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tvarkarastis
{
   public class SqlConn
    {
        public static string connStr = @"Server=localhost;user=root;database=tvarkarastis;port=3306;password=";
        MySqlConnection conn = new MySqlConnection(connStr);
        public void connect()
        {
            string connStr = @"Server=localhost;user=root;database=tvarkarastis;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                MessageBox.Show("Connecting to MySQL...");
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
            //string cmdStr = "SELECT COUNT(*) FROM tvarkarastis.lapkritis";
            //MySqlCommand cmd = new MySqlCommand(cmdStr, conn);

            /*MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())

            {

                int count = reader.GetInt32(0);

                if (count == 0)

                {

                    MessageBox.Show("No such data table exists!");

                }

                else if (count >= 1)

                {

                    MessageBox.Show("Such data table exists!");

                }

            }*/
            MessageBox.Show("Done.");
        }
        public void AddMonth()
        {
            string createTable = string.Format(@"CREATE TABLE 'gruodis'(
                'Name' TEXT NOT NULL,
                'Data' DATA NOT NULL,
                'Laipsnis' TEXT NOT NULL,
                'PP' INT(11) NOT NULL)");
            conn.Open();
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE Gruodis(First_Name char(50),Last_Name char(50),Laipsnis char(50),Budejimas Date);", conn))
                command.ExecuteNonQuery();
        }
    }
}
