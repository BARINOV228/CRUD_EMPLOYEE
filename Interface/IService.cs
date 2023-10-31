using CRUD_EMPLOYEE.DTO;
using CRUD_EMPLOYEE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_EMPLOYEE.Interface
{
    public interface IService
    {
        public static void CreateEmployee(Employee employee) { }
        public static void UpdateEmployee(int id, EmployeeDTO e) { }
        public static void DeleteEmployee(int id) { }
        public static void DeepDelete(int id) { }
        public static void GetAllEmployee() { }
        public static void GetEmployeeById(int id) { }

    }
}
