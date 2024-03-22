using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostgreSQL.Models;

[Table("Company")]
public partial class Company
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
