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

namespace Gallery
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>


    
    public partial class MainWindow : Window
    {
        int numPicture = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            numPicture--;
            if (numPicture == 0)
                numPicture = 4;

            ImageArea.ImageSource = new BitmapImage(new Uri(@"C:\Users\Леша\source\repos\Gallery\Gallery\Images\" + numPicture + ".jpg", UriKind.Relative));

        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            numPicture++;
            if (numPicture == 5)
                numPicture = 1;

            ImageArea.ImageSource = new BitmapImage(new Uri(@"C:\Users\Леша\source\repos\Gallery\Gallery\Images\" + numPicture + ".jpg", UriKind.Relative));
        }
    }
}
