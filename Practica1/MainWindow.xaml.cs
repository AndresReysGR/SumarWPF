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

namespace Practica1
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

       private void BtnMulti_Click(object sender, RoutedEventArgs e)
        {
            int numero1 = int.Parse(boxM_2.Text);
            int numero2 = int.Parse(boxM_3.Text);
            int resultado = numero1 * numero2;

            txt_ResultadoM.Text = resultado.ToString();
        }

        private void BtnTrian_Click(object sender, RoutedEventArgs e)
        {
            int numero3 = int.Parse(boxT_2_Copy.Text);
            int numero4 = int.Parse(boxT_3_Copy.Text);
            int resultado = (numero3 * numero4)/2;

            txt_ResultadoT_Copy.Text = resultado.ToString();

        }

        private void BtnCircu_Click(object sender, RoutedEventArgs e)
        {
            int numero3 = int.Parse(boxT_2_Copy.Text);
            int numero4 = int.Parse(boxT_3_Copy.Text);
            int resultado = (numero3 * numero4) / 2;

            txt_ResultadoT_Copy.Text = resultado.ToString();

        }
    }
}
