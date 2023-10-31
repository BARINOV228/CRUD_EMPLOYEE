////EmployeeService.CreateEmployee(Employee.AddEmployee());
//EmployeeService.GetAllEmployee();
//EmployeeService.GetEmployeeById(1);

using CRUD_EMPLOYEE.DTO;
using CRUD_EMPLOYEE.Service;
using static CRUD_EMPLOYEE.Enum.ERole;

EmployeeDTO employeeDTO = new EmployeeDTO();
employeeDTO.Login = "ChangedLogin";
employeeDTO.Password = "ChangedPassword";
employeeDTO.Role = Role.Manager;

//EmployeeService.UpdateEmployee(1, employeeDTO);
//EmployeeService.DeleteEmployee(2);
EmployeeService.DeepDelete(3);