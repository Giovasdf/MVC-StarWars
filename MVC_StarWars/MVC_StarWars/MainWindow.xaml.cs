using Controlador;
using Modelo;
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

namespace MVC_StarWars
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isJedi = true;
        string JediText = "";
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            //var result = ControladorPersona.AgregarPersona(txtNombre.Text, isJedi);

            //JediText = isJedi ? "Jedi" : "Sith";

            ////if(result == true)
            //if (result)
            //{
            //    lbMensaje.Text = $"Agregado {txtNombre.Text} correctamente como {JediText}";
            //}
            //else
            //{
            //    lbMensaje.Text = $"No se pudo agregar {txtNombre.Text} como {JediText}";
            //}

        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            isJedi = !isJedi;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var result = ControladorPersona.AgregarPersona(txtNombre.Text, isJedi);

            JediText = isJedi ? "Jedi" : "Sith";

            //if(result == true)
            if (result)
            {
                lbMensaje.Text = $"Agregado {txtNombre.Text} correctamente como {JediText}";
            }
            else
            {
                lbMensaje.Text = $"No se pudo agregar {txtNombre.Text} como {JediText}";
            }
        }
    }
}
