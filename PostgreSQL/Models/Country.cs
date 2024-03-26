using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostgreSQL.Models;

[Table("Country")]
public partial class Country
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }

    [InverseProperty("Country")]
    public List<Company> Companies { get; set; } = [];
}
