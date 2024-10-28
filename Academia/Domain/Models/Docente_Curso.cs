namespace Domain.Models
{
    public class Docente_Curso
    {
        public int Id { get; set; }
        public Curso Curso { get; set; } = null!;
        public Persona Docente { get; set; } = null!;
        public string Cargo { get; set; } = null!;
    }
}