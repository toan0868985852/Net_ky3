using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical.Models
{
    public class EFEmployeeRepository : ISEmployeeRepository
    {

        private EmployeeDbContext context;

        public EFEmployeeRepository(EmployeeDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Employees> employees => context.employees;
    }
}
