namespace AgendaMedica.Models
{
    public class Agenda
    {
        public Guid AgendaId { get; set; } // chave primaria PK
        public Guid PacienteId { get; set; } // chave estrangeira FK
        public Paciente? Paciente { get; set; } // objeto referente a chave acima
        public Guid MedicoId { get; set; } // chave estrangeira FK
        public Medico? Medico { get; set; } // objeto referente a chave acima
        public DateTime DataConsulta { get; set; }
        public string? Status { get; set; }
    }
}
