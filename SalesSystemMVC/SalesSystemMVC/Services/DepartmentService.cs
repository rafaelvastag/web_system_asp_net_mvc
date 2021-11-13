using SalesSystemMVC.Data;
using SalesSystemMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystemMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesSystemMVCContext _context;

        public DepartmentService(SalesSystemMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
