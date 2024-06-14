using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GenerateDocs.Models.Disciplines
{
    public class DisciplineInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CodeCompetence { get; set; }
        public string? Description { get; set; } = null;
        public string Knowledge { get; set; }
        public string Skill { get; set; }
        public string Ownership { get; set; }
    }
}
