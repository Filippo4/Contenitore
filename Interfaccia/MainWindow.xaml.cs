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
using Figure;
using Politiche;

namespace Interfaccia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmb_contenitore.Items.Add("Quadrato");
            cmb_contenitore.Items.Add("Cerchio");
            cmb_politica.Items.Add("AreaMassima");
            cmb_politica.Items.Add("PerimetroMinimo");
        }
        static int n = 0;
        private void btn_crea_Click(object sender, RoutedEventArgs e)
        {
            n++;
            Contenitore c = new Contenitore();
            lbx_Contenitori.Items.Add(c.ToString()+$" {n}");
        }

        private void cmb_contenitore_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cmb_contenitore.SelectedIndex==1)
            {
                txt_parametro2.IsEnabled = false;
            }
            else
            {
                txt_parametro2.IsEnabled = true;
            }
        }
    }
}
