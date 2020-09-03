using System;
using System.Collections.Generic;
using System.Text;

namespace Consultorio2
{
    class Paciente : Pessoa
    {
        public string Convenio { get; set; }
        public DateTime Validade { get; set; }
        public DateTime DataPrimeiraConsulta { get; set; }

    }
}
