using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mock_2.Model.Entity
{
    [Table("Rooms")]
    public class Room : UserSupervise
    {
        [Key]
        public int RooomID { get; set; }
        public string? RoomName { get; set; }
        public int? Price { get; set; }
        public string? Airon { get; set; }
        public string? Information { get; set; }
        public float? Area { get; set; }
        public int? MaxAmountOfPeople { get; set; }
        public int? CurrentAmountOfPeople { get; set; }
        public int? BuildingNumber { get; set; }
        public int? FloorNumber { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        // Statuses N-1 StatusID
        [ForeignKey("StatusID")]
        public Status Statuses { get; set; }
        // RoomType N-1 RoomTypeID
        [ForeignKey("RoomType")]
        public RoomType? RoomTypes { get; set; }
        // Houses N-1 HouseID
        [ForeignKey("HouseID")]
        public House? Houses { get; set; }
        // RoomImages 1-N ID
        public ICollection<RoomImage>? RoomImages { get; set; }
        // RoomHistory 1-N ID
        public ICollection<RoomHistory>? RoomHistories { get; set; }
      



    }
}
