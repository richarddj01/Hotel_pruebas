using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace Hotel_BuenDespertar
{
    public class conexion
    {
        public SqlConnection cn = new SqlConnection("Server=tcp:sqlserver-desarrollosoftware.database.windows.net,1433;Initial Catalog=Hotel_BuenDespertar;Persist Security Info=False;User ID=desarrollosoftware2022;Password=SoftwareMemitox10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");

        public void open()
        {
            try
            {
                cn.Open();
                MessageBox.Show("exito");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
