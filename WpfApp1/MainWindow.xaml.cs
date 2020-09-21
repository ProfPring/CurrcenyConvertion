using App1;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserInputHelper userInputHelper = new UserInputHelper();
        ConvertCurrencyToUSD ConvertCurrency = new ConvertCurrencyToUSD();
        ConvertCurrencyToAUD convertCurrencyToAUD = new ConvertCurrencyToAUD();
        ConvertCurrencyToEUR convertCurrencyToEUR = new ConvertCurrencyToEUR();
        CurrencyDict CurrencyDict = new CurrencyDict();
        AuditLogging auditLogging = new AuditLogging();
        getLogsAuditFile getLogsAuditFile = new getLogsAuditFile();
        Alert Alert = new Alert();

        public MainWindow()
        {
            InitializeComponent();
            CurrencyDict.AddElements();
        }

        private void SearchLogs_click(object sender, RoutedEventArgs e)
        {
           
            auditLogsList.Items.Clear();

            if (userInputHelper.IsUserInputDateTime(serachLogsStartDate.Text) && userInputHelper.IsUserInputDateTime(serachLogsEndDate.Text))
            {
                var dates = getLogsAuditFile.getLogsspecified(serachLogsStartDate.Text, serachLogsEndDate.Text);
                foreach (var line in dates)
                {
                    auditLogsList.Items.Add(line);
                }
            }
            else
            {
                Alert.ShowMessage("user input must be date time stirng in this form: 21 September 2020");
            }
        }

        private void ConvertToUSD_Click(object sender, RoutedEventArgs e)
        {
            if (userInputHelper.IsUserInputNumberOrEmppty(ConvertFromTextInput.Text))
            {
                Alert.ShowMessage("user input must be a number and cannot be empty");
            }
            else
            {
                int userInput = userInputHelper.ConvertUserInput(ConvertFromTextInput.Text);
                var convertedAmounted = (ConvertCurrency.ConvertGPDToUSD((userInput), CurrencyDict.Currency_Dictionary()).ToString());
                convertedAmmount.Text = convertedAmounted;
                auditLogging.writeLogs("USD", convertedAmounted);
            }
        }

        private void ConvertToAUD_Click(object sender, RoutedEventArgs e)
        {
            if (userInputHelper.IsUserInputNumberOrEmppty(ConvertFromTextInput.Text))
            {
                Alert.ShowMessage("user input must be a number and cannot be empty");
            }
            else
            {
                int userInput = userInputHelper.ConvertUserInput(ConvertFromTextInput.Text);
                var convertedAmounted = (convertCurrencyToAUD.ConvertGPDToAUD((userInput), CurrencyDict.Currency_Dictionary()).ToString());
                convertedAmmount.Text = convertedAmounted;
                auditLogging.writeLogs("AUD", convertedAmounted);
            }
        }

        private void ConvertToEUR_Click(object sender, RoutedEventArgs e)
        {
            if (userInputHelper.IsUserInputNumberOrEmppty(ConvertFromTextInput.Text))
            {
                Alert.ShowMessage("user input must be a number and cannot be empty");
            }
            else
            {
                int userInput = userInputHelper.ConvertUserInput(ConvertFromTextInput.Text);
                var convertedAmounted = (convertCurrencyToEUR.ConvertGPDToEUR((userInput), CurrencyDict.Currency_Dictionary()).ToString());
                convertedAmmount.Text = convertedAmounted;
                auditLogging.writeLogs("EUR", convertedAmounted);
            }
        }

       
    }
}
