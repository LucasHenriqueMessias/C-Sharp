using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace p_Teste
{
    class Cidade
    {
        //Atributos
        private int idCidade;
        private string nomeCidade;
        private string ufCidade;
        
        //propriedades
        public int IdCidade
        {
            get
            {
                return idCidade;
            }
            set
            {
                idCidade = value;
            }
        }
        
        public string NomeCidade
        {
            get
            {
                return nomeCidade;
            }
            set
            {
                nomeCidade = value;
            }
        }
        
        public string UfCidade
        {
            get
            {
                return ufCidade;
            }
            set
            {
                ufCidade = value;
            }
        }

        //Métodos
        public DataTable Listar()
        {
            SqlDataAdapter daCidade;
            DataTable dtCidade = new DataTable();

            try
            {
                daCidade = new SqlDataAdapter("Select * FROM Cidade", frmPrincipal.conexao);
                daCidade.Fill(dtCidade);
                daCidade.FillSchema(dtCidade, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtCidade;
        }
    }
}
