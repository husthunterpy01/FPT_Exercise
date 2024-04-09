using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mock_2.Model.Entity
{
    [Table("RoomTypes")]
    public class RoomType
    {
        [Key]
        public int RoomTypeId { get; set; }
        public string? RoomTypeName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public ICollection<Room>? Rooms { get; set; }
    }
}
