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
using studnt.Model;
using studnt.ViewModel;

namespace studnt.View
{
    /// <summary>
    /// Interaction logic for StudentDashboard.xaml
    /// </summary>
    public partial class StudentDashboard : Window
    {
        public List<Students>? MyStudents { get; set; }

        public StudentDashboard()
        {
            InitializeComponent();
            DataTest();
        }

        private void DataTest()
        {
            using (DataContext dataContext = new DataContext())
            {
                MyStudents = dataContext.Students.ToList();
            }

            StudentGrid.ItemsSource = MyStudents;
        }
    }
}
