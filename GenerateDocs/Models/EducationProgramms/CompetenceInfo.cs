using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GenerateDocs.Models.EducationProgramms
{
    public class CompetenceInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CodeCompetence { get; set; }
        public string Description { get; set; }
    }
}
