namespace GeradorDePacotes.Database.Entities
{
    public class DeletedFolders
    {
        public int Id { get; set; }
        public string? FolderName { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
