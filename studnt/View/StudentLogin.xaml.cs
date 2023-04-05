using studnt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace studnt.View
{
    /// <summary>
    /// Interaction logic for StudentLogin.xaml
    /// </summary>
    public partial class StudentLogin : Window
    {
        public StudentLogin()
        {
            InitializeComponent();
        }

        

        private void loginTheStudent_Click(object sender, RoutedEventArgs e)
        {
            //here we hae to ccheck the a=data baseand the allow  the studdent to Login
            //read


            //user name and pass
            var StudentuserName = StudentName.Text;
            var Studentpassword = StudentPassword.Text;

            using (ViewModel.DataContext context = new ViewModel.DataContext())
            {
                //here the userfound is true if the student f name is the user name
                bool userFound = context.Students.Any(student => student.SFirstName == StudentuserName && student.SRegistrationNumbrer == Studentpassword);

                if (userFound)
                {
                    GiveAccess();
                    Close();
                }

                else
                {
                    MessageBox.Show("Your Details are not found.Please , contact your Instructor!");
                    //MessageBox.Show("Your "+ context.Students. +"");
                }
                StudentName.Text=null;
                StudentPassword.Text=null;




            }

            

        }

        //function for checcing 
        public void GiveAccess()
        {
            StudentDashboard studentDashboard = new StudentDashboard();
            studentDashboard.Show();
        }
    }
}
