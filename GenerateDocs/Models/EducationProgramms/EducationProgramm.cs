using GenerateDocs.Models.Users;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using GenerateDocs.Models.Disciplines;

namespace GenerateDocs.Models.EducationProgramms
{
    public class EducationProgramm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string? Description { get; set; } = null;
       // public User User { get; set; }
        public List<Discipline> Disciplines { get; set; }
        public List<CompetenceInfo> Competences { get; set; }
    }
}
