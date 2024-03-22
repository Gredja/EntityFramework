using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using PostgreSQL.Configurations;

namespace PostgreSQL.Models;

[Index("CompanyId", Name = "IX_Users_CompanyId")]
[Index("CountryId", Name = "IX_Users_CountryId")]
[Index("PassportNumber", "PassportSeria", Name = "IX_Users_PassportNumber_PassportSeria")]
//[EntityTypeConfiguration(typeof(UserConfiguration))]
public partial class User
{
    [Key]
    [Column("User_id")]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Position { get; set; }

    public int? CompanyId { get; set; }

    public int Age { get; set; }

    public int? CountryId { get; set; }

    public int PassportNumber { get; set; }

    public string PassportSeria { get; set; } = null!;

    [ForeignKey("CompanyId")]
    [InverseProperty("Users")]
    public virtual Company? Company { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("Users")]
    public virtual Country? Country { get; set; }
}
