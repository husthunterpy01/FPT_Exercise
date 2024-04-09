using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mock_2.Model.Entity
{
    [Table("Statuses")]
    public class Status 
    {
        [Key]
        public int StatusId { get; set; }

        public string? StatusName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public ICollection<Room>? Rooms { get; set; }
    }
}
