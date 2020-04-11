using MySql.Data.MySqlClient;
using System.Configuration;

namespace QuickTest
{
    class MyConnection
    {
        
        #region
        /// <summary>
        /// database connection class
        /// </summary>
        /// <returns>conntion string</returns>
        public MySqlConnection getConnection()
        { 
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["QuickTest"].ConnectionString);
        }
        #endregion
    }
}
