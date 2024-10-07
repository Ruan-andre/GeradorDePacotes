
namespace GeradorDePacotes.Database.Entities
{
    public class DeletedFiles
    {
        public int Id { get; set; }
        public string? FileName { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
