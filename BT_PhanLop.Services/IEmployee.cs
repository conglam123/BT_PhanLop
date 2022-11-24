using BT_PhanLop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BT_PhanLop.Services
{
    public interface IEmployee
    {
        Task CreateAsync(Employee employee);
        Task UpdateAsync(Employee employee);
        Task UpdateById(int id);
        Employee GetById(int id);
        Task Delete(int employeeId);
        IEnumerable<Employee> GetAll();
        decimal UnionFee(int id);
        decimal StudentLoanRepaymentAmount(int id, decimal totalAmount);
    }
}
