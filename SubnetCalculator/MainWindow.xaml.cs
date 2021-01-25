using SubnetCalculator.Model;
using SubnetCalculator.Util;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace SubnetCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Ip ip = new Ip();
        private SubnetUtil util = new SubnetUtil();

        private readonly CidrRangeCollections collections = new CidrRangeCollections();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ip.Address = "10.0.0.0";
            ip.SubnetClass = 'A';
            IpAddress.Content = ip.Address;
            ComboBox1.ItemsSource = collections.cidrClassARange;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            ip.Address = "172.16.0.0";
            ip.SubnetClass = 'B';
            IpAddress.Content = ip.Address;
            ComboBox1.ItemsSource = collections.cidrClassBRange;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            ip.Address = "192.168.1.0";
            ip.SubnetClass = 'C';
            IpAddress.Content = ip.Address;
            ComboBox1.ItemsSource = collections.cidrClassCRange;
        }

        private void CalculateSubnetsBtn_Click(object sender, RoutedEventArgs e)
        {
            string selectedItem = ComboBox1.SelectedItem.ToString();
            int.TryParse(selectedItem, out int cidr);
            var maxHosts = util.ConfigureCidrMaxHosts(cidr, ip.SubnetClass);
            MaxHosts.Content = maxHosts;
            var maxSubnets = util.GetMaximumNumberOfSubnets(cidr, ip.SubnetClass);
            MaxSubnets.Content = maxSubnets;
            UsableHosts.Content = (util.ConfigureCidrMaxHosts(cidr, ip.SubnetClass) - 2);
            solutions.ItemsSource = util.GetSolution(ip.Address, maxHosts, maxSubnets);
            CalculateSubnetsBtn.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var value = MessageBox.Show("Would you like to save the solution to a file?", "Save", MessageBoxButton.YesNo);
            UsableHosts.Content = value;
        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            solutions.Items.Refresh();
            solutions.ItemsSource = null;
            solutions.Items.Refresh();
            CalculateSubnetsBtn.IsEnabled = true;
        }
    }
}
