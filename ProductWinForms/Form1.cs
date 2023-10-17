using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace ProductWinForms
{
    public partial class Form1 : Form
    {
        DataSet dsMyStore = new DataSet();
        static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory
                                                      .GetCurrentDirectory())
                                                     .AddJsonFile("appsettings.json", true, true)
                                                     .Build();
            var strConnection = config["ConnectionStrings:MyStoreDB"];
            return strConnection;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DbProviderFactory factory = SqlClientFactory.Instance;
            using DbConnection connection = factory.CreateConnection();
            if (connection == null)
            {
                Console.WriteLine($"Unable to create connection ");
                return;
            }

            connection.ConnectionString = GetConnectionString();
            connection.Open();
            string sql = "Select ProductID, ProductName from Products; Select * from Caretories";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, GetConnectionString());
                adapter.Fill(dsMyStore);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Data From Database");
            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dvgData.DataSource = dsMyStore.Tables[0];
        }

        private void btnViewCatory_Click(object sender, EventArgs e)
        {
            dvgData.DataSource = dsMyStore.Tables[1];
        }
    }
}