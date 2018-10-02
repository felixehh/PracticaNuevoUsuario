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

namespace PracticaNuevoUsuario
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            paneldatos.Children.Clear();

            switch (CBTipoUsuario.SelectedIndex)
            {
                case 0:
                    paneldatos.Children.Add(new controldatosalumno());
                    break;

                case 1:
                    paneldatos.Children.Add(new controldatosmaestro());
                    break;
            }
        }
    }
}
