using System;
using System.Collections.Generic;

namespace BestBuyBestPractices
{
    public interface IDepartmentRepository
    {
        public IEnumerable<Department> GetAllDepartments();
        public void CreateDepartment(string Name);
    }
}
