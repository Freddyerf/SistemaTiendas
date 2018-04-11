using Final.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Services
{
    public interface IDataTray
    {
        IEnumerable<Product> GetProducts();
        IEnumerable<Employee> GetEmployees();
    }
}
