using System.Configuration;

namespace DataLayer
{
    public class Connection
    {
        public static string String = ConfigurationManager.ConnectionStrings["connection"].ToString();
    }
}
