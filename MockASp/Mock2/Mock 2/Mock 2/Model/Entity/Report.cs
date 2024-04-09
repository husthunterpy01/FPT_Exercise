using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mock_2.Model.Entity
{
    [Table("Report")]
    public class Report :UserSupervise
    {
        [Key]
        public int? ReportID { get; set; }

        public string? ReportContent { get; set; }
        [ForeignKey("HouseID")]
        public House? House { get; set; }
        [ForeignKey("StudentID")]
        public User? Student { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get;set; }
    }
}
