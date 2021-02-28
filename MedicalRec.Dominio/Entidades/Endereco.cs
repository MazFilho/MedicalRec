namespace MedicalRec.Dominio.Entidades
{
    public class Endereco : Entidade
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("CEP deve estar preenchido");
        }
    }
}
