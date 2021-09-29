using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Reference
    {
        [Key]
        public long Reference_Id { get; set; }
        public int? ReferenceTypeId { get; set; }
        public List<ReferenceType>? ReferenceType { get; set; }
        public string? Code { get; set; }
        public string? DefaultCode { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
