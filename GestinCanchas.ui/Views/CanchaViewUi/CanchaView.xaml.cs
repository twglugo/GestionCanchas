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
using System.Windows.Shapes;
using Controlador.ControladorCancha; 

namespace GestinCanchas.ui.Views.CanchaViewUi
{
    /// <summary>
    /// Lógica de interacción para CanchaView.xaml
    /// </summary>
    public partial class CanchaView : Window
    {
        public CanchaView()
        {
            InitializeComponent();
            LlenarTabla();
        }

        public void LlenarTabla()
        {
            ControladorCancha cancha = new();
            ConsultaTotalCancha.ItemsSource = cancha.ConsultaTotalCanchas();
        }
        public void InsertarCanchas()
        {
            ControladorCancha cancha = new();
            string direccion = Direccion.Text;
            string precio = Precio.Text;
            ConsultaTotalCancha.ItemsSource = cancha.ConsultaTotalCanchas();

        }

        private void InsertarCancha_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
