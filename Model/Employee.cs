using CRUD_EMPLOYEE.Enum;
using CRUD_EMPLOYEE.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_EMPLOYEE.Model
{
    public class Employee : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public EStatus.Status Status { get; set; }
        public ERole.Role Role { get; set; }
        public string? CreatedDate { get; set; }
        public string? UpdatedDate { get; set; }
        public string? DeletedDate { get; set; }

        public static Employee AddEmployee()
        {
            return new Employee
            {
                Name = "Ulugbek",
                Surname = "Pulathodjaev",
                Email = "UP@gmail.com",
                Login = "Logandin",
                Password = "1234567",
                Status = EStatus.Status.Created,
                Role = ERole.Role.Programmer,
            };
        }
    }
}
