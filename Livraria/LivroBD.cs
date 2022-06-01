using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Livraria
{
    class LivroBD
    {

        public MySqlConnection conexaoLivros;
        public string dados;
        public string comando;
        public string resultado;
        public int i;
        public string mensagem;
        public int contador;
        public string misterio;
        public int[] codigoLivro;
        public string[] titulo;
        public string[] anoDeLancamento;
        public string[] editora;
        public int[] numeroDePaginas;
        public decimal[] valor;
        public int[] disponiveis;
        public string[] autor;
        public string[] categoria;




        public LivroBD()
        {
            //Script para conexão do banco de dados
            conexaoLivros = new MySqlConnection("server=localhost;DataBase=livraria;Uid=root;Password=;Convert Zero DateTime=True");
            try
            {
                conexaoLivros.Open();//Tentando conectar ao BD
                Console.WriteLine("Conectado com sucesso!");

            }
            catch (Exception e)
            {
                Console.WriteLine("Algo deu errado!\n\n" + e);//Mostrar o erro em tela

                conexaoLivros.Close();//Fechar a conexão com o banco de dados
            }

        }//Fim do método construtor
        //Método para inserir dados no BD
        public void InserirLivros(string titulo, string anoDeLancamento, string editora, int numeroDePaginas, decimal valor, int disponiveis, string autor, string categoria)
        {
            try
            {
                //Preparo o código para inserção no banco

                dados = "('', '" + titulo + "','" + anoDeLancamento + "','" + editora + "','" + numeroDePaginas + "','" + valor + "','" + disponiveis + "','" + autor + "','" + categoria + "')";
                comando = "Insert into livros(codigoLivro, titulo, anoDeLancamento, editora, numeroDePaginas, valor, disponiveis, autor, categoria) values" + dados;
                //Executar o comando de inserção no bando de dados
                MySqlCommand sql = new MySqlCommand(comando, conexaoLivros);
                resultado = "" + sql.ExecuteNonQuery();//Executa o insert no BD
                Console.WriteLine(resultado + " Linhas afetadas");
            }
            catch (Exception e)
            {
                Console.WriteLine("Algo deu errado!\n\n" + e);
                Console.ReadLine(); //Manter o programa aberto
            }

        }//Fim do método Inserir

        public void PreencherVetorLivros()
        {
            string query = "select*from livros";//Coletar os dados do BD

            //Instanciar
            codigoLivro = new int[100];
            titulo = new string[100];
            anoDeLancamento = new string[100];
            editora = new string[100];
            numeroDePaginas = new int[100];
            valor = new decimal[100];
            disponiveis = new int[100];
            autor = new string[100];
            categoria = new string[100];

            //Preencher com valores iniciais

            for (i = 0; i < 100; i++)
            {
                codigoLivro[i] = 0;
                titulo[i] = "";
                anoDeLancamento[i] = "";
                editora[i] = "";
                numeroDePaginas[i] = 0;
                valor[i] = 0;
                disponiveis[i] = 0;
                autor[i] = "";
                categoria[i] = "";
            }//Fim do for

            //Criando o comando para consultar no BD
            MySqlCommand coletar = new MySqlCommand(query, conexaoLivros);
            //Leitura dos dados do banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                codigoLivro[i] = Convert.ToInt32(leitura["codigoLivro"]);
                titulo[i] = leitura["titulo"] + "";



                anoDeLancamento[i] = leitura["anoDeLancamento"] +"";
                editora[i] = leitura["editora"] + "";
                numeroDePaginas[i] = Convert.ToInt32(leitura["numeroDePaginas"]);
                valor[i] = Convert.ToDecimal(leitura["valor"]);
                disponiveis[i] = Convert.ToInt32(leitura["disponiveis"]);
                autor[i] = leitura["autor"] + "";
                categoria[i] = leitura["categoria"] + "";

                i++;
                contador++;
            }//Fim do while

            //Fechar a leitura de dados no banco
            leitura.Close();
        }//Fim do método de preenchimento do vetor
        public string ConsultarTudoLivros()
        {


            //Preencher os vetores
            PreencherVetorLivros();
            mensagem = "";

            for (i = 0; i < contador; i++)
            {

                mensagem += "Código: " + codigoLivro[i] +
                      ", Título: " + titulo[i] +
                      ", Ano de lançamento: " + anoDeLancamento[i] +
                      ", Editora: " + editora[i] +
                      ", Número de páginas: " + numeroDePaginas[i] +
                      ", Valor: " + valor[i] +
                      ", Disponíveis: " + disponiveis[i] +
                      ", Autor: " + autor[i] +
                      ", categoria: " + categoria[i]+
                      "\n\n";
            }//Fim do for

            return mensagem;

        }//Fim do método consultarTudo

        public string AcessarCategoriaMistério
        {
            get{
                return categoria[i];
            }
            set
            {
                this.categoria[i] =  "select*from livros where categoria like 'Mistério'";
            }
        }

        public string ConsultarPorCategoria(int codigocategoriabd)
        {
            PreencherVetorLivros();
            for (i = 0; i < contador; i++) { 
                if (codigocategoriabd == 1){
                return categoria[i] = "";
            }
            else 
            {
                return "inválido";
            }
            }
            return "";

        }
    }


}
