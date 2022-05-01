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

namespace Курсовая_Работа__Трекер_Инициативы_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void OpenAllList(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Открыт список элементов");
        }

        private void OpenPatterns(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Открыт список паттернов");
        }
        private void Open_Directories(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Открыт список справочников");
        }
    }
}
