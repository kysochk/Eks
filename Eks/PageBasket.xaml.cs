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

namespace Eks
{
    /// <summary>
    /// Логика взаимодействия для PageBasket.xaml
    /// </summary>
    public partial class PageBasket : Page
    {
        int index = 0;
        public PageBasket()
        {
            InitializeComponent();
        }
        public PageBasket(int i)

        {
            InitializeComponent();
           
            Books books = BaseConnect.BaseModel.Books.FirstOrDefault(x => x.Id_Book == i);

            DataContext = books;
            index = i;
           
        }

        private void goback_Click(object sender, RoutedEventArgs e)
        {
            PageLoad.MainFrame.Navigate(new PageBooks());

        }

        private void TextBlock_DragEnter(object sender, DragEventArgs e)
        {

        }
    }
}
