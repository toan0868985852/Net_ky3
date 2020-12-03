using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical.Models
{
    public interface ISEmployeeRepository
    {
        IQueryable<Employees> employees { get; }
    }
}
