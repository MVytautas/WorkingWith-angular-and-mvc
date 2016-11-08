using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Text;

namespace WcfFromDb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        SqlConnection conn;
        SqlCommand comm;

        SqlConnectionStringBuilder connStringBuilder;

        void ConnectToDb()
        {
            connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = "DESKTOP-JGRMSDV\\SQLEXPRESS";
            connStringBuilder.InitialCatalog = "master";
            connStringBuilder.Encrypt = true;
            connStringBuilder.TrustServerCertificate = true;
            connStringBuilder.ConnectTimeout = 30;
            connStringBuilder.AsynchronousProcessing = true;
            connStringBuilder.MultipleActiveResultSets = true;
            connStringBuilder.IntegratedSecurity = true;

            conn = new SqlConnection(connStringBuilder.ToString());
            comm = conn.CreateCommand();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public int InsertUser(Data d)
        {
            throw new Exception("later");
        }

        //public Data GetData(Data d)
        //{
        //    Data data = new Data();

        //    try
        //    {
        //        comm.CommandText = "SELECT * FROM Table";

        //        conn.Open();
        //        SqlDataReader reader = comm.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            data.Id = Convert.ToInt32(reader[0]);
        //            data.Name = reader[1].ToString();
        //            data.Surename = reader[2].ToString();
        //            data.Address = reader[3].ToString();
        //        }
        //        return data;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        if (conn != null)
        //        {
        //            conn.Close();
        //        }
        //    }
        //}

        //async public void ReadData(int Id, string Name, string Surename, string Address)
        //{
        //    masterEntities _db = new masterEntities();
        //}

    }
}
