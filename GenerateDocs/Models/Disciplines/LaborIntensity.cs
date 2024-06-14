using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GenerateDocs.Models.Disciplines
{
    public class LaborIntensity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string IdSem { get; set; }
        public string Info { get; set; }
    }
}
