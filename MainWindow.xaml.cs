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

namespace WPFDemoThing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GridPanelOne gridThing;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window stackP = new StackPanelDemo();
            stackP.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WrapPanel wr_P = new WrapPanel();
            wr_P.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = TextBox1.Text.ToLower();
            if (TextBox1.Text == "canvas")
            {
                CanvasDemo cd = new CanvasDemo();
                cd.Show();
                Title = "Main Window";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window cthulhu = new tDockPanelDemo();
            cthulhu.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (gridThing != null)
            {
                gridThing.Close();
                gridThing = null;
            }
            gridThing = new GridPanelOne();
            gridThing.Show();
        }
    }
}
