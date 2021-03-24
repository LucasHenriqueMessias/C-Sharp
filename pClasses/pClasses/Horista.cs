using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pClasses
{
    class Horista : empregado
    {
        public double SalarioHora { get; set; }
        public double NumeroHora { get; set; }
        public double DiasFalta { get; set; }

        public override double SalarioBruto()
        {
            return (SalarioHora * NumeroHora);
        }
        public override int TempoTrabalho()
        {
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return ((int)(Convert.ToInt32(span.Days) - DiasFalta));
        }
    }
}
