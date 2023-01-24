using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Department
    {
        [Key]
        public Guid DepartmentId { get; set; }
        public string SectionType { get; set; }
        public int DepartmentNumber { get; set; }
    }
}
