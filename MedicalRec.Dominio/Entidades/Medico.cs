﻿using System.Collections.Generic;
using System.Linq;

namespace MedicalRec.Dominio.Entidades
{
    public class Medico : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CRM { get; set; } //somente numeros no formato (00.000.00)
        public string TelFixo { get; set; }
        public string TelCel { get; set; }

        /// <summary>
        /// Medico deve ter no minimo duas especialidades
        /// ou mais
        /// </summary>
        //public virtual ICollection<Especialidade> Especialidades { get; set; }

        public virtual ICollection<MedicoEspecialidade> MedicoEspecialidades { get; set; }

        // CEP (Endereço).

        public int EnderecoId { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!MedicoEspecialidades.Any())
                AdicionarCritica("Deve conter ao mínimo duas Especialidades.");
            
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome deve estar preenchido");

            
            //if (CRM == 0)
            //AdicionarCritica("CRM deve estar preenchido");
           
            

        }
    }
}
