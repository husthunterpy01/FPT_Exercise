using Mock_2.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mock_2.Model.DTO
{
    public class CampusCreateDTO
    {
        public string? CampusName { get; set; }
        public int? AddressId { get; set; }
        public Address? Addresses { get; set; }
        public ICollection<House>? Houses { get; set; }
    }
}
