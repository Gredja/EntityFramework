using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostgreSQL.Models;

[Table("Company")]
public partial class Company
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
    public int CountryId { get; set; }
    public Country? Country { get; set; }

    [InverseProperty("Company")]
    public List<User> Users { get; set; } = new();
}
