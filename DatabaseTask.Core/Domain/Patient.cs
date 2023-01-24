using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Patient
    {
        [Key]
        public Guid PatientId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime Birthdate { get; set; }
        public string Ilness { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
