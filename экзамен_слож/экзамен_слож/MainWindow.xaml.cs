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

namespace экзамен_слож
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Window1 taskWindow = new Window1();
            taskWindow.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {

        }

        //    using System;
        //using System.Data.Entity;
        //using System.Data.Entity.ModelConfiguration;
        //public partial class ToursBaseEntities : DbContext
        //{
        //    private static ToursBaseEntities _context;
        //    public ToursBaseEntities()
        //       : base("name = ToursBaseEntities")
        //    {

        //    }
        //    public static ToursBaseEntities GetContext()
        //    {
        //        if (_context == null)
        //            _context = new ToursBaseEntities();
        //        return _context;
        //}
    }
}
