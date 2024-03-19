using DataProvider.Abstractions;
using DataProvider.Models.Contoso;
using DataProvider.Models.Enums;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Engines
{
	public class DeviceRepository : IDeviceRepository
	{
		private readonly string CS = @$"Data Source=EPESMALW042D;Initial Catalog=TIMELINE;Integrated Security=True;TrustServerCertificate=true;";
		public void DeleteDevice(int deviceId)
		{
			using (SqlConnection connection = new SqlConnection(CS))    
            {    
                var cmd = new SqlCommand("spDeleteDevice", connection);    
                cmd.CommandType = CommandType.StoredProcedure;    
                connection.Open();    
                cmd.Parameters.AddWithValue("@Id", deviceId);    
                cmd.ExecuteNonQuery();    
            }    
		}

		public Device GetDeviceById(int deviceId)
		{
			var device = new Device();    
            using (SqlConnection connection = new SqlConnection(CS))    
            {    
                SqlCommand cmd = new SqlCommand("spGetDevice", connection);    
                cmd.CommandType = CommandType.StoredProcedure;    
                connection.Open();    
                SqlDataReader reader = cmd.ExecuteReader();    
                while (reader.Read())    
                {    
                    device.Id = Convert.ToInt32(reader["Id"]);
                    device.SerialNumber = reader["SerialNumber"].ToString();
                    device.Status = (DeviceStatus)Enum.Parse(typeof(DeviceStatus), reader["Status"].ToString());
                    device.StartDate = Convert.ToDateTime(reader["StartDate"]);
                    device.EndDate = Convert.ToDateTime(reader["EndDate"]);
                }
            }
            return device;
		}

		public IEnumerable<Device> GetDevices()
		{
			List<Device> devices = new List<Device>();    
            using (SqlConnection connection = new SqlConnection(CS))    
            {    
                SqlCommand cmd = new SqlCommand("spGetAllDevices", connection);    
                cmd.CommandType = CommandType.StoredProcedure;    
                connection.Open();    
                SqlDataReader reader = cmd.ExecuteReader();    
                while (reader.Read())    
                {    
                    var device = new Device   
                    {    
                        Id = Convert.ToInt32(reader["Id"]),    
                        SerialNumber = reader["SerialNumber"].ToString(),    
                        Status = (DeviceStatus)Enum.Parse(typeof(DeviceStatus), reader["Status"].ToString()),    
                        StartDate = Convert.ToDateTime(reader["StartDate"]),    
                        EndDate = Convert.ToDateTime(reader["EndDate"])
                    };    
                    devices.Add(device);    
                }
            }    

            return (devices);
		}

		public void InsertDevice(Device device)
		{
			using (SqlConnection connection = new SqlConnection(CS))
            {    
                var cmd = new SqlCommand("spAddNewDevice", connection);    
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();                        
                cmd.Parameters.AddWithValue("@SerialNumber", device.SerialNumber);    
                cmd.Parameters.AddWithValue("@Status", device.Status.ToString());    
                cmd.Parameters.AddWithValue("@StartDate", device.StartDate);    
                cmd.Parameters.AddWithValue("@EndDate", device.EndDate);
                cmd.ExecuteNonQuery();    
            }    
		}

		public void UpdateDevice(Device device)
		{
			using (SqlConnection connection = new SqlConnection(CS))    
            {    
                var cmd = new SqlCommand("spUpdateDevice", connection);    
                cmd.CommandType = CommandType.StoredProcedure;    
                connection.Open();    
                cmd.Parameters.AddWithValue("@SerialNumber", device.SerialNumber);    
                cmd.Parameters.AddWithValue("@Status", device.Status.ToString());    
                cmd.Parameters.AddWithValue("@StartDate", device.StartDate);    
                cmd.Parameters.AddWithValue("@EndDate", device.EndDate);
                cmd.ExecuteNonQuery();    
            }    
		}
	}
}
