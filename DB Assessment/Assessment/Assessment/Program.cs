using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Assessment
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            string loginDetails = "server=ysjcs.net;database=callumburnsoregan;uid=callum.b;pwd=NKAFAXJ6";
            MySqlConnection con = new MySqlConnection(loginDetails);
            try
            {
                con.Open();
                MessageBox.Show("Connection Established");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}