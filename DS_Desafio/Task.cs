namespace DS_Desafio
{
    public class Task
    {
        public int id { get; set; }
        public string? title { get; set; }
        public string? description { get; set; }
        public DateTime? dateCreated { get; }
        public DateTime? dateConclusion { get; set; }

        /*
        ========================
        Task
        ------------------------
        Inicializador, define a hora automaticamente na criação.
        ========================
        */
        public Task()
        {
            dateCreated = DateTime.Now;
        }
    }
}
