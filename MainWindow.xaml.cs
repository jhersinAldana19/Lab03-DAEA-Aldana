using System.Windows;
using System.Data;
using Microsoft.Data.SqlClient;

namespace WpfApp1
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

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection connection =
            new SqlConnection("Data Source=DESKTOP-QMNREBJ\\SQLEXPRESS2017; Initial Catalog=LabDB; Integrated Security=True; TrustServerCertificate=True; Encrypt = True");

                connection.Open();
                DataTable dataTable = new DataTable();
                SqlCommand command = new SqlCommand("Select * from Products", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();

                dgDemo1.ItemsSource = dataTable.DefaultView;
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
                throw;
            }
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SqlConnection connection =
           new SqlConnection("Data Source=DESKTOP-QMNREBJ\\SQLEXPRESS2017; Initial Catalog=LabDB; Integrated Security=True; TrustServerCertificate=True; Encrypt = True");

            List<Producto> products = new List<Producto>();

            connection.Open();

            SqlCommand command = new SqlCommand("Select * from Products", connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read()) {

                products.Add(new Producto
                {
                    ProductID = Convert.ToInt32(dataReader["ProductID"].ToString()),
                    Nombre = dataReader["Nombre"].ToString(),
                    Precio = dataReader["Precio"].ToString(),
                });

            }
            connection.Close();
            dgDemo2.ItemsSource = products;
        }
    }
}