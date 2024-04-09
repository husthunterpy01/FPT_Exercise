using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mock_2.Model.Entity
{
    [Table("RoomImages")]
    public class RoomImage : UserSupervise
    {
        [Key]
        public int ImageID { get; set; }
        public string? ImageLink { get; set; }

        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifedDate { get; set; }
        [ForeignKey("RoomID")]
        public Room? Rooms { get; set; }
    }
}
