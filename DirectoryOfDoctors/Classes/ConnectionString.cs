using System.Configuration;

namespace DirectoryOfDoctors.Classes
{
    internal static class ConnectionString
    {
        internal static string GetDirectoryOfDoctorsConnectionString()
        {
            return GetConnectionStringByName("DirectoryOfDoctors");
        }

        internal static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
            {
                return settings.ConnectionString;
            }
            return returnValue;
        }
    }
}
