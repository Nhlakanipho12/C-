using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace VO2_Max.Database
{
    class DataAccess
    {
        MySqlConnection connect;
        MySqlCommand command;
        String connectionStr = "server=localhost;user id=root;database=fitness";

        public DataAccess()
        {
            connect = new MySqlConnection(connectionStr);
        }

        public void databaseWrite(string query)
        {
            if (query != null)
            {
                try
                {
                    connect.Open();
                    command = new MySqlCommand(query, connect);
                    command.ExecuteNonQuery();
                    //command.CommandType = CommandType.StoredProcedure;
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("An Error Occured {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
                
            }
            else
            {
                MessageBox.Show(string.Format("An Error Occured {0}", "Query is Null"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
