using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace Hotel_BuenDespertar
{
    internal class clHabitaciones:conexion
    {

        SqlDataAdapter sda;
        SqlCommand cmd;
        DataTable dt;

        public void cargarDatos(DataGrid dgv)
        {
            try
            {
                sda = new SqlDataAdapter("EXEC HABITACIONES_DGV", cn);
                dt = new DataTable();
                sda.Fill(dt);
                dgv.ItemsSource = dt.DefaultView;
            }
            catch (Exception e){
                MessageBox.Show("Error" + e);
            }
        }

    }
}
