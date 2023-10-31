using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_EMPLOYEE.Interface
{
    public interface IEmployee
    {
        public int Id { get; set; }
        public string? CreatedDate { get; set; }
        public string? UpdatedDate { get; set; }
        public string? DeletedDate { get; set; }
    }
}
