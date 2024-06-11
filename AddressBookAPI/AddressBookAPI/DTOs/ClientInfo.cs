using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddressBookAPI.DTOs
{
    [Table("client_info")]
    public class ClientInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("id")]
        public long Id { get; set; }
        [Required]
        [Column("first_name")]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Column("middle_name")]
        [StringLength(50)]
        public string MiddleName { get; set; } = string.Empty;

        [Column("last_name")]
        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;
        [Required]
        [Column("phone_number")]
        [StringLength(20)]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        [Column("address")]
        [StringLength(200)]
        public string Address { get; set; } = string.Empty;
    }
}
