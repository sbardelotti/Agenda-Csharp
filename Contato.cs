using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contato
    {
        public Contato()
        {
            this.Id = 0;
            this.Nome = "";
            this.Email = "";
            this.Telefone = "";
            this.Rua = "";
            this.Cidade = "";
            this.Estado = "";
            this.Cep = "";
        }

        public Contato(int id, string nome, string email, string telefone, string rua, string cidade, string estado, string cep)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
            this.Rua = rua;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Cep = cep;
        }
        
        private int N_ID;
        public int Id
        {
            get
            {
                return this.N_ID;
            }
            set
            {
                this.N_ID = value;
            }
        }
        private string T_NOME;
        public string Nome
        {
            get
            {
                return this.T_NOME;
            }
            set
            {
                this.T_NOME = value;
            }
        }
        private string T_EMAIL;
        public string Email
        {
            get
            {
                return this.T_EMAIL;
            }
            set
            {
                this.T_EMAIL = value;
            }
        }
        private string T_TELEFONE;
        public string Telefone
        {
            get
            {
                return this.T_TELEFONE;
            }
            set
            {
                this.T_TELEFONE = value;
            }
        }
        private string T_RUA;
        public string Rua
        {
            get
            {
                return this.T_RUA;
            }
            set
            {
                this.T_RUA = value;
            }
        }
        private string T_BAIRRO;
        public string Bairro
        {
            get
            {
                return this.T_BAIRRO;
            }
            set
            {
                this.T_BAIRRO = value;
            }
        }
        private string T_CIDADE;
        public string Cidade
        {
            get
            {
                return this.T_CIDADE;
            }
            set
            {
                this.T_CIDADE = value;
            }
        }
        private string T_ESTADO;
        public string Estado
        {
            get
            {
                return this.T_ESTADO;
            }
            set
            {
                this.T_ESTADO = value;
            }
        }
        private string T_CEP;
        public string Cep
        {
            get
            {
                return this.T_CEP;
            }
            set
            {
                this.T_CEP = value;
            }
        }
    }
}
