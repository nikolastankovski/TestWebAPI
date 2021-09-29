using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Movie
    {
        [Key]
        public long Movie_Id { get; set; }
        public string? Title { get; set; }
        public int? Year { get; set; }
        public int? Genre_Id { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public bool? IsActive { get; set; }

    }
}
