using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToffeeTavern.Models
{
    [Table("C_CHARACTER")]
    public class Character
    {
        [Key]
        [Column("C_ID")]
        public int Id { get; set; }

        [Column("C_NAME")]
        public string Name { get; set; }

        [Column("C_LEVEL")]
        public int Level { get; set; }
    }
}
