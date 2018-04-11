using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final.Data;
using Final.Models.Entities;

namespace Final.Services
{
    public class DataTraySQL : IDataTray
    {
        private ApplicationDbContext _AplicationDbContext;

        public DataTraySQL(ApplicationDbContext applicationDbContext)
        {
            _AplicationDbContext = applicationDbContext;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _AplicationDbContext.Employees;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _AplicationDbContext.Products;
        }
    }
}
