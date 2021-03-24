using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pClasses
{
    class mensalista : empregado
    {
        public double SalarioMensal { get; set; }

        public mensalista()
        {

        }
        public mensalista(int matx, string nomex, DateTime datax, double salariox)
        {
            Matricula = matx;
            NomeEmpregado = nomex;
            DataEntradaEmpresa = datax;
            SalarioMensal = salariox;
        }
        public override double SalarioBruto()
        {
            return SalarioMensal;
        } 
    }
}

