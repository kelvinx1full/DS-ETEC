using System;
using System.Collections.Generic;
using System.Text;

namespace Consultorio2
{
    class Consulta
    {
        public int CodigoConsulta { get; set; }
        public DateTime DataConsulta { get; set; }
        public DateTime DataDoCadastro { get; set; }
        public int CodigoDoPaciente { get; set; }
        public int CodigoMedico { get; set; }
        public string MotivoDaConsulta { get; set; }
        private string Diagnostico { get; set; }

        public void Atender(string Motivo, string Diagnostico)
        {

        }
    }
}
