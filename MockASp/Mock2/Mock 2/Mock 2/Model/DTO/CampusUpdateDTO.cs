using Mock_2.Model.Entity;

namespace Mock_2.Model.DTO
{
    public class CampusUpdateDTO
    {
        public int CampusID { get; set; }
        public string? CampusName { get; set; }
        public int? AddressId { get; set; }
        public Address? Addresses { get; set; }
        public ICollection<House>? Houses { get; set; }
    }
}
