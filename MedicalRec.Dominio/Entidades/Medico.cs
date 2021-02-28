using System.Collections.Generic;

namespace MedicalRec.Dominio.Entidades
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CRM { get; set; } //somente numeros no formato (00.000.00)

        //public String TelFixo { get; set; }

        //public string TelCel { get; set; }
        
        /// <summary>
        /// Medico deve ter no minimo duas especialidades
        /// ou mais
        /// </summary>
        public ICollection<Especialidade> Especialidades { get; set; }

        // CEP (Endereço).

        public int EnderecoId { get; set; }



    }
}
