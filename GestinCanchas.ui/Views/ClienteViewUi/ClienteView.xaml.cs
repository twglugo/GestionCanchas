
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
using Controlador;

namespace GestinCanchas.ui.Views.ClienteViewUi
{
    /// <summary>
    /// Lógica de interacción para ClienteView.xaml
    /// </summary>
    public partial class ClienteView : Window
    {
        public ClienteView()
        {
            InitializeComponent();
            LlenarTabla();

        }

        public void LlenarTabla()
        {
            ControladorCliente Prueba = new();
            Consultatotal.ItemsSource = Prueba.ConsultaTotalCliente();
        }




        private void Prueba1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ControladorCliente Prueba = new();
                string cedula = Cedula.Text;
                string nombre = Nombre.Text;
                string telefono = Telefono.Text;
                bool Puerta = Prueba.RegistrarClienteControlador(cedula, nombre, telefono);

                if (Puerta)
                {
                    LlenarTabla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
