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
    /// Логика взаимодействия для PageBooks.xaml
    /// </summary>
    public partial class PageBooks : Page
    {
        LoadList load = new LoadList();
        List<Books> ls;
        public PageBooks()
        {
            InitializeComponent();
            BookList.ItemsSource = load.books;
            ls = load.books;

        }
      
        private void AddKorzine_Click(object sender, RoutedEventArgs e)
        {
            PageLoad.MainFrame.Navigate(new PageBasket());
        }
    }
}
