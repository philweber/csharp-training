using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Lab02
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (AccountType accountType in Enum.GetValues(typeof(AccountType)))
            {
                TypeList.Items.Add(accountType);
            }

            // TypeList.ItemsSource = Enum.GetValues(typeof(AccountType)).Cast<AccountType>();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            BankAccount account;
            account.Number = NumberTextBox.Text;
            account.Type = (AccountType)TypeList.SelectedValue;
            account.Balance = decimal.Parse(BalanceTextBox.Text);

            ResultTextBlock.Text = String.Format(
                "Account created: \n\n" +
                "Number: {0}\nType: {1}\nBalance: {2:C}",
                account.Number, account.Type, account.Balance);
        }
    }
}
