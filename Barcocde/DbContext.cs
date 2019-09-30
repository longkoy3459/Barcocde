using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VsLogistics.UIComponent
{
    public partial class DBHangHoaEntitiesNH : DbContext
    {
        public DBHangHoaEntitiesNH(string connectionString)
            : base(connectionString)
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
        }
        
        
        //Caution : Do this will reload ALL DATABASE ???
        public void RefreshEntryDatabase()
        {
            foreach (var entity in this.ChangeTracker.Entries())
            {
                entity.Reload();
            }
        }

        public bool CheckConnection()
        {
            try
            {
                this.Database.Connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public static class ConnectionTools
    {
        private const string providerName = "System.Data.SqlClient";
       

      
        public static string BuildConnectionOffline(string _DataSource, string _InitialCatalog, string _UserID, string _Password)
        {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
            {
                //    DataSource = @".\SQLEXPRESS",
                //    InitialCatalog = "DBHangHoa1111",
                //    UserID = "sa",
                //    Password = "longkoy3459",


                DataSource = _DataSource,
                InitialCatalog = _InitialCatalog,
                UserID = _UserID,
                Password = _Password,
                PersistSecurityInfo = true,
                ConnectTimeout = 10
            };

            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();

            string DataModelName = "DBHangHoa";

            string providerString = builder.ConnectionString;

            //Set the provider name.
            entityBuilder.Provider = providerName;

            // Set the provider-specific connection string.
            entityBuilder.ProviderConnectionString = providerString;

            // Set the Metadata location.
            entityBuilder.Metadata = string.Format(@"res://*/{0}.csdl|res://*/{1}.ssdl|res://*/{2}.msl", DataModelName, DataModelName, DataModelName);

            return entityBuilder.ToString();

        }



        public static string BuildConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
            {
                DataSource = "118.70.116.130",
                InitialCatalog = "DBHangHoa",
                UserID = "qr",
                Password = "M2thanhcong",
                PersistSecurityInfo = true,
                ConnectTimeout = 10
            };

            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();

            string DataModelName = "DBHangHoa";

            string providerString = builder.ConnectionString;

            //Set the provider name.
            entityBuilder.Provider = providerName;

            // Set the provider-specific connection string.
            entityBuilder.ProviderConnectionString = providerString;

            // Set the Metadata location.
            entityBuilder.Metadata = string.Format(@"res://*/{0}.csdl|res://*/{1}.ssdl|res://*/{2}.msl", DataModelName, DataModelName, DataModelName);

            return entityBuilder.ToString();

        }

    }
}
