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
using WpfApp.DAL.EF;
using WpfApp.DAL.Interfaces;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IUnitOfWork _db;
        public MainWindow(IUnitOfWork unitOfWork)
        {
            _db = unitOfWork;
            InitializeComponent();
            GetCalendars();
        }

        private void GetCalendars()
        {
            var calendars = _db.Calendars.GetAll();
            CalendarykDB.ItemsSource = calendars;
        }
    }
}
