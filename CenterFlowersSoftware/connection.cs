using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CenterFlowersSoftware
{
   internal class connection
    {
        private SqlConnection sCon = new SqlConnection();
        private string conn = "Data Source=DESKTOP-OJTKK35\\SQLEXPRESS;Integrated Security=SSPI;Initial catalog=Instituto";
        public SqlConnection conectar()
        {
            try
            {
                sCon = new SqlConnection(conn);
                if (sCon.State.Equals(ConnectionState.Open))
                {
                    sCon.Close();
                }
                else
                {
                    sCon.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return sCon;


        }

    }
}
