using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Ward
    {
        [Key]
        public Guid WardId { get; set; }
        public int RoomNumber { get; set; }
        public int DepartmentNumber { get; set; }
    }
}
