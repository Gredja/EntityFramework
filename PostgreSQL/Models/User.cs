using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PostgreSQL.Models;

[Index("CompanyId", Name = "IX_Users_CompanyId")]
[Index("PassportNumber", "PassportSeria", Name = "IX_Users_PassportNumber_PassportSeria")]
//[EntityTypeConfiguration(typeof(UserConfiguration))]
public partial class User
{
    [Key]
    [Column("User_id")]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Position { get; set; }

    public int Age { get; set; } = 18;

    public int PassportNumber { get; set; }

    public string PassportSeria { get; set; } = null!;

    public int? CompanyId { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("Users")]
    public virtual Company? Company { get; set; }
}
