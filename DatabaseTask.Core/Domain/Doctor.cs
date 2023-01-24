using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Doctor
    {
        [Key]
        public Guid DoctorId { get; set; }
        public string Name { get; set; }
        public int DepartmentNumber { get; set; }
    }
}
