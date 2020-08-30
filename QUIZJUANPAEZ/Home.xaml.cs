using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QUIZJUANPAEZ
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
            cmbItms.Items.Add("Rings");
            cmbItms.Items.Add("Earrings");
            cmbItms.Items.Add("Necklace");
            cmbItms.Items.Add("Belt");
            cmbItms.Items.Add("Bracelet");

        }



        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string productName = txtProductName.Text;
            string category = lblCategory.Content.ToString();

            lstdata.Items.Add(txtProductName.Text);
            lstdata.Items.Add(lblCategory.Content);
            lstdata.Items.Add(cmbItms.Text);

        }

        private void btnLogout_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow ss = (MainWindow)Window.GetWindow(this);
            ss.frameMain.NavigationService.Navigate(new Login());
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if(rb.IsChecked.Value)
            {
                lblCategory.Content = rb.Content.ToString();
            }
        }


        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thanks for the donation, it will be very helpful");
        }
    }
}
