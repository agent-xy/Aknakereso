using Aknakereso.Classes;
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

namespace Aknakereso
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow _MW_V;
        public MainWindow()
        {
            InitializeComponent();

            _MW_V = this;

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Back_End.Back_End_Main();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Back_End.Back_End_Main();
        }

        private void _Btn_Point_Click(object sender, RoutedEventArgs e)
        {
            if (_Btn_Point.Background != Brushes.Green)
            {
                _Btn_Point.Background = Brushes.Green;
                Back_End.Pointer_Bube = true;
            } else
            {
                Back_End.Pointer_Bube = false;
                _Btn_Point.Background = default;
            }
        }
    }
}
