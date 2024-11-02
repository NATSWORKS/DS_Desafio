namespace DS_Desafio
{
    public class Task
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateConclusion { get; set; }

        public StatusE Status { get; set; }

        public enum StatusE
        {
            Pendente,
            EmProgresso,
            Concluida
        }
    }
}
