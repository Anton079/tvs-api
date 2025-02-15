using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tvs_api.Tvs.Models
{
    [Table("tv")]

    public class Tv
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("type")]
        public string Type { get; set; }

        [Required]
        [Column("model")]
        public string model { get; set; }

        [Required]
        [Column("Price")]
        public int Price { get; set; }
    }
}
