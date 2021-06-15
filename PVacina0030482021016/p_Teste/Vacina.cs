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
    class Vacina
    {
        //Propriedades
        private int idVacina;
        private string nomeVacina;
        private DateTime dataNascVacina;
        private string endVacina;
        private int cidadeIdCidade; //Vem da tabela Cidade
        private string cpfVacina;
        private string rgVacina;
        private DateTime dataVacina;
        private char tipoVacina; //s ou n
        private char comorbidade; //s ou n
        private char grupoPriorVacina; //s ou n
        private int enfermeiroIdEnfermeiro; //Vem da tabela Enfermeiro

        //Propriedades
        public int IdVacina
        {
            get
            {
                return idVacina;
            }
            set
            {
                idVacina = value;
            }
        }

        public string NomeVacina
        {
            get
            {
                return nomeVacina;
            }
            set
            {
                nomeVacina = value;
            }
        }
        public DateTime DataNascVacina
        {
            get
            {
                return dataNascVacina;
            }
            set
            {
                dataNascVacina = value;
            }
        }
        public string EndVacina
        {
            get
            {
                return endVacina;
            }
            set
            {
                endVacina = value;
            }
        }
        public int CidadeIdCidade
        {
            get
            {
                return cidadeIdCidade;
            }
            set
            {
                cidadeIdCidade = value;
            }
        }
        public string CpfVacina
        {
            get
            {
                return cpfVacina;
            }
            set
            {
                cpfVacina = value;
            }
        }
        public string RgVacina
        {
            get
            {
                return rgVacina;
            }
            set
            {
                rgVacina = value;
            }
        }
        public DateTime DataVacina
        {
            get
            {
                return dataVacina;
            }
            set
            {
                dataVacina = value;
            }
        }
        public char TipoVacina
        {
            get
            {
                return tipoVacina;
            }
            set
            {
                tipoVacina = value;
            }
        }
        public char Comorbidade
        {
            get
            {
                return comorbidade;
            }
            set
            {
                comorbidade = value;
            }
        }
        public char GrupoPriorVacina
        {
            get
            {
                return grupoPriorVacina;
            }
            set
            {
                grupoPriorVacina = value;
            }
        }
        public int EnfermeiroIdEnfermeiro
        {
            get
            {
                return enfermeiroIdEnfermeiro;
            }
            set
            {
                enfermeiroIdEnfermeiro = value;
            }
        }

        //Métodos
        public DataTable Listar()
        {
            SqlDataAdapter daVacina;
            DataTable dtVacina = new DataTable();

            try
            {
                daVacina = new SqlDataAdapter("Select * FROM Vacina", frmPrincipal.conexao);
                daVacina.Fill(dtVacina);
                daVacina.FillSchema(dtVacina, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtVacina;
        }

        public int Salvar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                int nReg;

                mycommand = new SqlCommand("INSERT INTO VACINA VALUES(@nomeVacina, @dataNascVacina, @endVacina, @cidadeIdCidade, @cpfVacina, @rgVacina, @dataVacina, @tipoVacina, @comorbidade, @grupoPriorVacina, @enfermeiroIdEnfermeiro)", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nomeVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dataNascVacina", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@endVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@cidadeIdCidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@cpfVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@rgVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dataVacina", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@tipoVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@comorbidade", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@grupoPriorVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@enfermeiroIdEnfermeiro", SqlDbType.Int));

                mycommand.Parameters["@nomeVacina"].Value = nomeVacina;
                mycommand.Parameters["@dataNascVacina"].Value = dataNascVacina;
                mycommand.Parameters["@endVacina"].Value = endVacina;
                mycommand.Parameters["@cidadeIdCidade"].Value = cidadeIdCidade;
                mycommand.Parameters["@cpfVacina"].Value = cpfVacina;
                mycommand.Parameters["@rgVacina"].Value = rgVacina;
                mycommand.Parameters["@dataVacina"].Value = dataVacina;
                mycommand.Parameters["@tipoVacina"].Value = tipoVacina;
                mycommand.Parameters["@comorbidade"].Value = comorbidade;
                mycommand.Parameters["@grupoPriorVacina"].Value = grupoPriorVacina;
                mycommand.Parameters["@enfermeiroIdEnfermeiro"].Value = enfermeiroIdEnfermeiro;

                nReg = mycommand.ExecuteNonQuery();

                if(nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;
            try
            { 
                SqlCommand mycommand;
                int nReg;

                mycommand = new SqlCommand("UPDATE VACINA SET nome_vacina=@nomeVacina, datanasc_vacina=@dataNascVacina, end_vacina=@endVacina, cidade_Id_Cidade=@cidadeIdCidade, cpf_vacina=@cpfVacina, rg_vacina=@rgVacina, data_vacina=@dataVacina, tipo_vacina=@tipoVacina, comorbidade_vacina=@comorbidade, grupopriori_vacina=@grupoPriorVacina, enfermeiro_id_enfermeiro=@enfermeiroIdEnfermeiro" +
                    " WHERE id_Vacina=@idvacina", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@idVacina", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nomeVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dataNascVacina", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@endVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@cidadeIdCidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@cpfVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@rgVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dataVacina", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@tipoVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@comorbidade", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@grupoPriorVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@enfermeiroIdEnfermeiro", SqlDbType.Int));

                mycommand.Parameters["@idVacina"].Value = idVacina;
                mycommand.Parameters["@nomeVacina"].Value = nomeVacina;
                mycommand.Parameters["@dataNascVacina"].Value = dataNascVacina;
                mycommand.Parameters["@endVacina"].Value = endVacina;
                mycommand.Parameters["@cidadeIdCidade"].Value = CidadeIdCidade;
                mycommand.Parameters["@cpfVacina"].Value = cpfVacina;
                mycommand.Parameters["@rgVacina"].Value = rgVacina;
                mycommand.Parameters["@dataVacina"].Value = dataVacina;
                mycommand.Parameters["@tipoVacina"].Value = tipoVacina;
                mycommand.Parameters["@comorbidade"].Value = comorbidade;
                mycommand.Parameters["@grupoPriorVacina"].Value = grupoPriorVacina;
                mycommand.Parameters["@enfermeiroIdEnfermeiro"].Value = enfermeiroIdEnfermeiro;

                nReg = mycommand.ExecuteNonQuery();

                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public int Excluir()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                int nReg;

                mycommand = new SqlCommand("DELETE FROM VACINA WHERE id_Vacina=@idvacina", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@idVacina", SqlDbType.Int));
                mycommand.Parameters["@idVacina"].Value = idVacina;
               
                nReg = mycommand.ExecuteNonQuery();

                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }
    } 
}
