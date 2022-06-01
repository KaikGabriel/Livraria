using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Livraria
{
    class Cliente
    {
        private int codigo;
        private string nome;
        private DateTime dataDeNacimento;
        private string telefone;
        private string usuario;
        private string senha;
        private string endereco;

        public Cliente()
        {
            
            AcessarCodigo = 0;
            AcessarNome = "";
            AcessarTelefone = "";
            AcessarUsuario = "";
            AcessarSenha = "";
            dataDeNacimento = new DateTime();

        }// fim método cliente

        public int AcessarCodigo
        {
            get
            {

                return codigo;

            }

            set
            {

                this.codigo = value;

            }
        }// fim método AcessarCodigo

        public DateTime AcessarData
        {
            get
            {

                return dataDeNacimento;

            }

            set
            {

                this.dataDeNacimento = value;

            }


        }// Fim método AcessarData

        public string AcessarNome

        {
            get

            {

                return nome;

            }

            set

            {

                this.nome = value;

            }

        }// fim método AcessarNome

        public string AcessarTelefone

        {

            get

            {

                return telefone;

            }

            set

            {

                this.telefone = value;

            }

        }// fim método AcessarTelefone

        public string AcessarUsuario
        {
            get

            {

                return usuario;

            }

            set

            {

                this.usuario = value;

            }

        }// fim método AcessarUsuario

        public string AcessarSenha
        {

            get

            {

                return senha;

            }

            set
            {

                this.senha = value;

            }
        }// fim método AcessarSenha

        public string AcessarEndereco
        {

            get
            {

                return endereco;

            }

            set

            {

                this.endereco = value;

            }

        }// fim método AcessarEndereco

        public void Cadastrar(int codigo, string nome, DateTime data, string telefone, string endereco, string usuario, string senha)
        {

            AcessarCodigo = codigo;
            AcessarNome = nome;
            AcessarData = data;
            AcessarTelefone = telefone;
            AcessarUsuario = usuario;
            AcessarSenha = senha;
            AcessarEndereco = endereco;

        }// fim do método Cadastrar

        public string Consultar(int codigo) 
        { 

           if (AcessarCodigo == codigo)

            {

                return "Código: "                + AcessarCodigo   + 
                      "\nNome: "                 + AcessarNome     +
                      "\nData de Nascimento: "   + AcessarData     +
                      "\nTelefone: "             + AcessarTelefone +
                      "\nEndereço: "             + AcessarEndereco +
                      "\nUsuário: "              + AcessarUsuario  +
                      "\nSenha: "                + AcessarSenha;

            }
            else
            {

                return "Código inválido";

            }
        
        }// fim método Consultar

        public string Login(string usuario, string senha)
        {
            if (AcessarUsuario == usuario & AcessarSenha == senha)
                
            {

                return "Logado com sucesso";

            }

            else
            {

                return "Usuário e senha inválidos";

            }

        }// fim método Login

    }// fim class

}// fim projeto
