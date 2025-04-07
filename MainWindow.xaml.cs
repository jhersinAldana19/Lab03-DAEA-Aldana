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
                SqlConnection connection =
            new SqlConnection("Data Source=DESKTOP-QMNREBJ\\SQLEXPRESS2017; Initial Catalog=LabDB; Integrated Security=True; TrustServerCertificate=True; Encrypt = True");

                connection.Open();
                DataTable dataTable = new DataTable();
                SqlCommand command = new SqlCommand("Select * from clientess", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();

                dgDemo1.ItemsSource = dataTable.DefaultView;
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SqlConnection connection =
           new SqlConnection("Data Source=DESKTOP-QMNREBJ\\SQLEXPRESS2017; Initial Catalog=LabDB; Integrated Security=True; TrustServerCertificate=True; Encrypt = True");

            List<Cliente> clientes = new List<Cliente>();

            connection.Open();

            SqlCommand command = new SqlCommand("Select * from clientess", connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read()) {

                clientes.Add(new Cliente
                {
                    ClienteID = Convert.ToInt32(dataReader["ClienteID"].ToString()),
                    Nombres = dataReader["Nombres"].ToString(),
                    Apellidos = dataReader["Apellidos"].ToString(),
                    DNI = dataReader["DNI"]?.ToString()
                });

            }
            connection.Close();
            dgDemo2.ItemsSource = clientes;
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(busqueda))
            {
                MessageBox.Show("Por favor ingresa un nombre para buscar.");
                return;
            }

            SqlConnection connection =
               new SqlConnection("Data Source=DESKTOP-QMNREBJ\\SQLEXPRESS2017; Initial Catalog=LabDB; Integrated Security=True; TrustServerCertificate=True; Encrypt = True");

            List<Cliente> clientes = new List<Cliente>();

            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM clientess WHERE Nombres LIKE @nombre", connection);
            command.Parameters.AddWithValue("@nombre", "%" + busqueda + "%");

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                clientes.Add(new Cliente
                {
                    ClienteID = Convert.ToInt32(dataReader["ClienteID"].ToString()),
                    Nombres = dataReader["Nombres"].ToString(),
                    Apellidos = dataReader["Apellidos"].ToString(),
                    DNI = dataReader["DNI"]?.ToString()
                });
            }

            connection.Close();
            dgDemo2.ItemsSource = clientes;
        }
    }
}