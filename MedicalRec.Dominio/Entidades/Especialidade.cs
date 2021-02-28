namespace MedicalRec.Dominio.Entidades
{
    public class Especialidade : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
