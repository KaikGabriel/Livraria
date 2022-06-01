using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Livraria
{
    class ClienteBD
    {
        public MySqlConnection conexao;
        public string dados;
        public string comando;
        public string resultado;
        public int i;
        public string mensagem;
        public int contador;
        public int[] codigo;
        public string[] nome;
        public DateTime[] data;
        public string[] telefone;
        public string[] usuario;
        public string[] senha;
        public string[] endereco;
        public ClienteBD()
        {
            //Script para conexão do banco de dados
            conexao = new MySqlConnection("server=localhost;DataBase=livraria;Uid=root;Password=;Convert Zero DateTime=True");
            try
            {
                conexao.Open();//Tentando conectar ao BD
                Console.WriteLine("Conectado com sucesso!");
              
            }catch(Exception e)
            {
                Console.WriteLine("Algo deu errado!\n\n" +e);//Mostrar o erro em tela
               
                conexao.Close();//Fechar a conexão com o banco de dados
            }

        }//Fim do método construtor

        //Método para inserir dados no BD
        public void Inserir(string nome, DateTime dataDN, string telefone, string usuario, string senha, string endereco)
        {
            try
            {
                //Modificar a estrutura de data

                MySqlParameter parameter = new MySqlParameter();
                parameter.ParameterName = "@Date";
                parameter.MySqlDbType = MySqlDbType.Date;
                parameter.Value = dataDN.Year + "-" + dataDN.Month + "-" + dataDN.Day;
                
                //Preparo o código para inserção no banco

//             --
                dados = "('', '" + nome + "','" + parameter.Value + "','" + telefone + "','" + usuario + "','" + senha + "','" + endereco + "')";
                comando = "Insert into cliente(codigo, nome, dataDeNascimento, telefone, usuario, senha, endereco) values" + dados;
                //Executar o comando de inserção no bando de dados
                MySqlCommand sql = new MySqlCommand(comando, conexao);
                resultado = "" + sql.ExecuteNonQuery();//Executa o insert no BD
                Console.WriteLine(resultado + " Linhas afetadas");
            }catch(Exception e)
            {
                Console.WriteLine("Algo deu errado!\n\n" + e);
                Console.ReadLine(); //Manter o programa aberto
            }

        }//Fim do Método inserir

        public DateTime Converter(object bancoDeDados)
        {
            string texto = bancoDeDados +"";
            texto.Replace("-", "/");
            DateTime dt = Convert.ToDateTime(texto);
            return dt;
        }

        public void PreencherVetor()
        {
            string query = "select*from cliente";//Coletar os dados do BD

            //Instanciar
            codigo = new int[100];
            nome = new string[100];
            data = new DateTime[100];
            telefone = new string[100];
            usuario = new string[100];
            senha = new string[100];
            endereco = new string[100];

            //Preencher com valores iniciais

            for (i = 0; i < 100; i++)
            {
                codigo[i] = 0;
                nome[i] = "";
                data[i] = new DateTime();
                telefone[i] = "";
                usuario[i] = "";
                senha[i] = "";
                endereco[i] = "";
            }//Fim do for

            //Criando o comando para consultar no BD
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Leitura dos dados do banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = leitura["nome"] +"";



                data[i] = Convert.ToDateTime(leitura["dataDeNascimento"]);
                telefone[i] = leitura["telefone"] + "";
                usuario[i] = leitura["usuario"] + "";
                senha[i] = leitura["senha"] + "";
                endereco[i] = leitura["endereco"] + "";

                i++;
                contador++;
            }//Fim do while

            //Fechar a leitura de dados no banco
            leitura.Close();
        }//Fim do método de preenchimento do vetor

        //Método que consulta todos os dados no banco de dados

        public string ConsultarTudo()
        {
            

            //Preencher os vetores
            PreencherVetor();
            mensagem = "";

            for (i = 0; i < contador; i++)
            {
               
                mensagem += "Código: " + codigo[i] +
                      ", Nome: " + nome[i] +
                      ", Data de Nascimento: " + data[i] +
                      ", Telefone: " + telefone[i] +
                      ", Usuário: " + usuario[i] +
                      ", Senha: " + senha[i] +
                      ", Endereço: " + endereco[i] +
                      "\n\n";
            }//Fim do for

            return mensagem;

        }//Fim do método consultarTudo

   

        public string Logar(string usuario1, string senha1)
        {
           

            PreencherVetor();

            mensagem = "";
            i++;
            contador++;
            for (i = 0; i < contador; i++) 
            { 
                if (usuario1 == usuario[i] & senha1 == senha[i])
                {
                     return mensagem = "Logado com sucesso";
                }
                else
                {
                     mensagem = "Erro ao logar";
                }
            }

            return mensagem;


        }//Fim login
        
         


       

    }//Fim da classe
}//Fim do projeto
