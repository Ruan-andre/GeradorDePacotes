﻿namespace GeradorDePacotes.Database.Entities
{
    public class FoldersToVerify
    {
        public int Id { get; set; }
        public string NameFolder { get; set; }

        public bool Disconsider { get; set; }
    }
}
