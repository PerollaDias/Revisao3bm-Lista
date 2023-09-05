namespace REVISAO3B
{
    public class Paciente
    {
        public int Id_paciente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime DateNac { get; set; }
        public Paciente()
        {

        }
        public Paciente(int id_paciente, string nome, string cpf, string email, DateTime dateNac)
        {
            Id_paciente = id_paciente;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            DateNac = dateNac;
        }
    }
}
