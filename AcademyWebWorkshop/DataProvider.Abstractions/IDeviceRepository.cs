using DataProvider.Models.Contoso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Abstractions
{
	public interface IDeviceRepository
	{
		IEnumerable<Device> GetDevices();
        Device GetDeviceById(int deviceId);
        void InsertDevice(Device device);
        void DeleteDevice(int deviceId);
        void UpdateDevice(Device device);
	}
}
