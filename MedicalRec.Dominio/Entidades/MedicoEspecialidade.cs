namespace MedicalRec.Dominio.Entidades
{
    public class MedicoEspecialidade : Entidade
    {

        public int MedicoId { get; set; }
        public virtual Medico Medico { get; set; }

        public int EspecialidadeId { get; set; }
        public virtual Especialidade Especialidade { get; set; }


        public override void Validate()
        {         
          throw new System.NotImplementedException();
        }
    }
}
