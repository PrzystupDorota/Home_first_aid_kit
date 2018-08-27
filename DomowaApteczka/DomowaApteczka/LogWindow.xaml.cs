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
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;

namespace DomowaApteczka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.setConnection();
        }
        OracleConnection con = null;
        private void setConnection()
        {
            String connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            con = new OracleConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception exp)
            {

            }
        }
        private void BTNLog_Click(object sender, RoutedEventArgs e)
        {
            string query = "SELECT LEK.NAZWA, PRODUCENT.NAZWA, LEKI_W_APTECZCE.STEZENIE, LEKI_W_APTECZCE.POSTAC, " +
                "LEKI_W_APTECZCE.DATA_WAZNOSCI, LEKI_W_APTECZCE.DATA_OTWARCIA, LEKI_W_APTECZCE.OKRES_WAZNOSCI_OD_OTWARCIA, " +
                "LEKI_W_APTECZCE.POZOSTALO, LEKI_W_APTECZCE.MIN_WIEK, LEKI_W_APTECZCE.WAR_PRZECHOWYWANIA, LEKI_W_APTECZCE.ULOTKA " +
                "from LEK, PRODUCENT, LEKI_W_APTECZCE WHERE ID_LEKU_W_APTECZCE = LEK.ID_LEK and ID_PRODUCENTA_LEKU = PRODUCENT.ID_PRODUCENT";
            //  if (BXUser.Text == )
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            con.Close();
        }
    }
}
