using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DAL
    {
        public string ConnectionString = string.Empty;// Public ConnectionString variable of string type.

        public DAL()// Default Constructor
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["RehomingDB"].ConnectionString;//Accessing ConnectionString with name RehomingDB.
        }

        public int SignUpDAL(Donator objDonator)
        {
            int output = 0;
            SqlConnection connection = new SqlConnection(ConnectionString);
            string sql = string.Format(@"INSERT INTO
		[Donator] (FullName, Email, Password, Active, Role) VALUES
		('{0}','{1}','{2}','{3}','{4}')",
            objDonator.FullName,
      objDonator.Email, objDonator.Password, objDonator.Active, objDonator.Role);
            SqlCommand command = new SqlCommand(sql, connection);

            try
            {
                connection.Open();
                // ExecuteNonQuery() is Used to execute the insert command. 
                // This inserts the data into the DB.
                output = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return output;
        }

        public string GetColumnValue(SqlDataReader dr, string columnName)
        {
            string columnValue = string.Empty;
            if (dr[columnName] != null && dr[columnName] != DBNull.Value)
            {
                columnValue = dr[columnName].ToString();
            }
            return columnValue;
        }

        public Donator SignInDAL(Donator objDonator)
        {
            Donator objUser = null; /*new UserMaster();*/
            SqlConnection connection = new SqlConnection(ConnectionString);
            string sql = string.Format(@"SELECT TOP 1 * FROM [Donator] WHERE Email='{0}' AND Password ='{1}' AND Active= 1",
                     objDonator.Email, objDonator.Password);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                // Used to execute the query to validate the entered details (email and password) and returns a corresponding row if user is valid and present in DB.
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    objUser = new Donator();
                    if (dr.Read())
                    {
                        // Calling GetColumnValue method to handle null values and retrieve the data from dr object and assign it to objUser variables without exceptions.
                        objUser.FullName = GetColumnValue(dr, "FullName");
                        objUser.Email = GetColumnValue(dr, "Email");
                        objUser.Role = GetColumnValue(dr, "Role");
                        objUser.Active = Convert.ToInt16(GetColumnValue(dr, "Active"));
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return objUser;
        }

        public int DonateAnimalDAL(Animal objAnimal)
        {
            int output = 0;
            if (objAnimal != null)
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                string sql = string.Format(@"INSERT INTO [Animal] (AnimalName, Location, Type , Status, Active, PickUpDate) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
                              objAnimal.AnimalName,  objAnimal.Location, objAnimal.Type,  objAnimal.Status, objAnimal.Active, objAnimal.PickUpDate);
                SqlCommand command = new SqlCommand(sql, connection);
                try
                {

                    connection.Open();
                    // Used to execute the insert command. This inserts the Donation data into the DB.
                    output = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }

            }
            return output;
        }

        public int AdoptAnimalDAL(Adopter objAdopter)
        {
            int output = 0;
            if (objAdopter != null)
            {
                SqlConnection connection = new SqlConnection(ConnectionString);

                string sql = string.Format(@"INSERT INTO [Adopter] (FullName, Email, PhoneNumber,Active,AnimalType)
                                	VALUES ('{0}','{1}','{2}','{3}','{4}')",
                                    objAdopter.FullName, objAdopter.Email, objAdopter.PhoneNumber, objAdopter.Active = 1,objAdopter.AnimalType
                                    );
                SqlCommand command = new SqlCommand(sql, connection);

                try
                {
                    connection.Open();
                    // Used to execute the insert command. This inserts the Donation data into the DB.
                    output = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
            return output;
        }

        public DataSet GetAnimalsDataDAL()
        {
            DataSet dsAnimalsData = new DataSet();
            SqlConnection connection = new SqlConnection(ConnectionString);

            string cmd = "Select * from [Animal] order by CreatedDate DESC";
            SqlCommand command = new SqlCommand(cmd, connection);

            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);// Used to execute the select command.
                adapter.Fill(dsAnimalsData);// Fill the dataset dsDonationsData from the sql adapter.
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dsAnimalsData; // return the entire dataset.

        }
        public DataSet GetUsersDataDAL()
        {
            DataSet dsUsersData = new DataSet();
            SqlConnection connection = new SqlConnection(ConnectionString);

            string cmd = "Select * from [Donator] order by CreatedDate DESC";
            SqlCommand command = new SqlCommand(cmd, connection);

            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);// Used to execute the select command.
                adapter.Fill(dsUsersData);// Fill the dataset dsDonationsData from the sql adapter.
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dsUsersData; // return the entire dataset.

        }

        public int UpdateAnimalDAL(string[] strAnimalUpdate)
        {
            int output;

            SqlConnection connection = new SqlConnection(ConnectionString);

            string sql = string.Format(@"update [Animal] set Status = '{0}', AdopterId='{2}',AdopterName='{3}'
            where AnimalId ='{1}'",
                strAnimalUpdate[0], strAnimalUpdate[1],strAnimalUpdate[2],strAnimalUpdate[3]);

            //string sql = "update [Donations] set RecipientId = " + Convert.ToInt32(strArrUpdate[2]) + ", Status = '" + strArrUpdate[1] + "', CharityName='" + strArrUpdate[3] + "' where DonationId = " + Convert.ToInt32(strArrUpdate[0]) + "";

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {

                connection.Open();
                // Used to execute the insert command. This inserts the Donation data into the DB.
                output = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return output;
        }

        public int UpdateUserDAL(string[] strUserUpdate)
        {
            int output;

            SqlConnection connection = new SqlConnection(ConnectionString);

            string sql = string.Format(@"update [Donator] set FullName = '{0}', Email = '{1}', Role = '{3}'
            where DonatorId ='{2}'",
                strUserUpdate[0], strUserUpdate[1], strUserUpdate[2], strUserUpdate[3]);

            //string sql = "update [Donations] set RecipientId = " + Convert.ToInt32(strArrUpdate[2]) + ", Status = '" + strArrUpdate[1] + "', CharityName='" + strArrUpdate[3] + "' where DonationId = " + Convert.ToInt32(strArrUpdate[0]) + "";

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {

                connection.Open();
                // Used to execute the insert command. This inserts the Donation data into the DB.
                output = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return output;
        }

        public int DeleteAnimalDAL(string AnimalId)
        {
            int output;

            SqlConnection connection = new SqlConnection(ConnectionString);


            SqlCommand command = new SqlCommand(@"delete from [Animal] where  AnimalId =" + AnimalId + "", connection);
            try
            {

                connection.Open();
                // Used to execute the insert command. This inserts the Donation data into the DB.
                output = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return output;
        }

        public int DeleteUserDAL(string DonatorId)
        {
            int output;

            SqlConnection connection = new SqlConnection(ConnectionString);


            SqlCommand command = new SqlCommand(@"delete from [Donator] where  DonatorId =" + DonatorId + "", connection);
            try
            {

                connection.Open();
                // Used to execute the insert command. This inserts the Donation data into the DB.
                output = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return output;
        }

        public List<Data> GetIndividualChartData(DataTable dt)
        {
            List<Data> dataList = new List<Data>();
            string ColumnName = "";
            int val = 0;
            foreach (DataRow dr in dt.Rows)
            {

                if (dr[0].GetType().Name == "DateTime")
                {
                    DateTime dtTime;
                    DateTime.TryParse(dr[0].ToString(), out dtTime);

                    ColumnName = dtTime.ToShortDateString();
                }
                else
                    ColumnName = dr[0].ToString();


                val = Convert.ToInt32(dr[1]);
                dataList.Add(new Data(ColumnName, val));
            }
            return dataList;
        }


        public List<ChartData> GetDataAnalyticsDAL()
        {
            List<ChartData> lstChartData = new List<ChartData>();

            DataSet ds = null;
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                string cmd1 = "select Status, count(AnimalId)  'Number of Animals' from Animal group by Status";
                using (SqlCommand cmd = new SqlCommand(cmd1, cn))
                {
                    ds = new DataSet();

                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    dt = ds.Tables[0];
                    List<Data> dataList = GetIndividualChartData(dt);
                    lstChartData.Add(new ChartData() { ChartType = "PieChart", lstData = dataList });
                }

                string cmd2 = "select Type, count(AnimalId)  'Number of Animals' from Animal group by Type";//select DonationType, CharityName, count(DonationId)  'Number of Donations' from Donations group by DonationType, CharityName
                using (SqlCommand cmd = new SqlCommand(cmd2, cn))
                {

                    ds = new DataSet();
                    dt.Clear();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    dt = ds.Tables[0];
                    List<Data> dataList = GetIndividualChartData(dt);
                    lstChartData.Add(new ChartData() { ChartType = "ColumnChart1", lstData = dataList });
                }

                string cmd3 = @"select'Number of Animals', count(AnimalId) from Animal
                            	union all
                           	select 'Number of Adopters', count(AdopterId) from Adopter";
                using (SqlCommand cmd = new SqlCommand(cmd3, cn))
                {

                    ds = new DataSet();
                    dt.Clear();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    dt = ds.Tables[0];
                    List<Data> dataList = GetIndividualChartData(dt);
                    lstChartData.Add(new ChartData() { ChartType = "ColumnChart2", lstData = dataList });
                }

                string cmd4 = "select CONVERT(date, CreatedDate) 'Dates', count(AnimalId) 'Number of Animals' from Animal group by CONVERT(date, CreatedDate)";
                using (SqlCommand cmd = new SqlCommand(cmd4, cn))
                {

                    ds = new DataSet();
                    dt.Clear();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    dt = ds.Tables[0];
                    List<Data> dataList = GetIndividualChartData(dt);
                    lstChartData.Add(new ChartData() { ChartType = "ColumnChart3", lstData = dataList });
                }

            }


            return lstChartData;

        }



    }
}
