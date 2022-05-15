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

namespace WpfDay_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void handleFormSubmit(object sender, RoutedEventArgs e)
        {
            var result = $"you submitted\nfirst name : {first_name.Text}\nlast name : {last_name.Text}\ngender : {gender.Text}\naddress : {address.Text}\nphone : {phone.Text}\nmobile : {mobile.Text}\nemail : {email.Text}\n job title : {job_title.Text}";
            var user_action=MessageBox.Show(result,"Application Submit",MessageBoxButton.OKCancel);
            if (user_action == MessageBoxResult.OK)
            {
                MessageBox.Show("Your submitted data is saved");
                Close();
            }
           
           
        }

        private void handleClose(object sender, RoutedEventArgs e)
        {
            Close();
        }



        private void handleReset(object sender, RoutedEventArgs e)
        {
            first_name.Text = "";
            last_name.Text = "";
            mobile.Text = "";
            phone.Text = "";
            address.Text = "";
            gender.Text = "";
            job_title.Text = "";

        }
    }
}
