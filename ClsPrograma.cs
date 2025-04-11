using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace pryGorocitoConexionBD
{
    internal class ClsPrograma
    {
        static void Main()
        {
            string connectionString = "Server=localhost;Database=Producto;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    //  ____________("✅ Conexión exitosa a la base de datos.");
                }
                catch (Exception ex)
                {
                    // _____________ ("❌ Error al conectar: " + ex.Message);
                }
            }
        }
    }


}
        
    

