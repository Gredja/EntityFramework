using System.ComponentModel.DataAnnotations.Schema;

namespace PostgreSQL.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
