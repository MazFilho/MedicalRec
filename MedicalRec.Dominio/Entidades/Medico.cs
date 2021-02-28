namespace MedicalRec.Dominio.Entidades
{
    public class Medico
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int CRM { get; set; } //somente numeros no formato (00.000.00)
        
        //public String TelFixo { get; set; }
        
        //public string TelCel { get; set; }

        // CEP e Especialidade, minimo duas.

        //Endereco

    }
}
