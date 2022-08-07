using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections;
using System.Data.SqlClient;

namespace gebzedemo.Controllers
{
    public class IletisimController : Controller
    {
        private readonly IConfiguration configuration;

        public IletisimController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            string connectionString = configuration.GetConnectionString("DefaultConnectionString");

            SqlConnection connection = new SqlConnection(connectionString);
            ArrayList valuesList = new ArrayList();
            connection.Open();
            SqlCommand com = new SqlCommand("Select isim from iletisim", connection);


            SqlDataReader dataReader = com.ExecuteReader();

            while (dataReader.Read())
            {
                valuesList.Add(dataReader[0].ToString());
            }
            ViewBag.valuesList = valuesList;
            connection.Close();
            return View();
        }
    }
}
