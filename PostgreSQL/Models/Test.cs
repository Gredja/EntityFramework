using Microsoft.EntityFrameworkCore;
using PostgreSQL.Configurations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostgreSQL.Models;

[Table("Test")]
//[EntityTypeConfiguration(typeof(TestConfiguration))]
public class Test
{
    [Key]
    public Guid Id { get; set; }

    public string Text { get; set; }
}
