using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hotel_BuenDespertar
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            conexion cn = new conexion();

            cn.open();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            VBhabitaciones.Visibility = Visibility.Hidden;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            VBhabitaciones.Visibility = Visibility.Visible;
            clHabitaciones habitaciones = new clHabitaciones();

            habitaciones.cargarDatos(dgvHabitaciones);
        }
    }
}
