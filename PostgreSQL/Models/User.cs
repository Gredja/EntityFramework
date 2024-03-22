using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PostgreSQL.Models;

[Table("Users")]
[Index("PassportNumber", "PassportSeria")]
public class User
{
    [Column("User_id")]
    [Required]
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public int Age { get; set; }

    [NotMapped]
    public bool IsMarried { get; set; }

    public string? Position { get; set; }

    [Required]
    public int PassportNumber { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    [DefaultValue("11111111")]
    public string PassportSeria { get; set; }

    public Company? Company { get; set; }

    public Country? Country { get; set; }
}
