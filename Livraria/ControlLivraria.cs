using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class ControlLivraria
    {
        ClienteBD conexao;
        Compra compra;
        Cliente cliente;
        Livros livros;
        public DateTime dataDN;
        LivroBD conexaoLivros;
        
       
        private int opcao;
        public ControlLivraria()
        {
            conexaoLivros = new LivroBD();
            conexao = new ClienteBD();
            dataDN = new DateTime();
            compra = new Compra();
            cliente = new Cliente();
            livros = new Livros();

        }// fim método ControlLivraria

        public int AcessarOpcao
        {

            get
            {
                return opcao;
            }

            set
            {
                this.opcao = value;
            }

        }// fim método AcessarOpcao

        public void Menu()
        {

            Console.WriteLine("\n\nEscolha uma das opções abaixo\n\n"+
                                    "1.Cadastrar\n"                  +
                                    "2.Logar\n"                      +
                                    "3.Consultar Cliente\n"          +
                                    "4.Cadastrar Livros\n"           +
                                    "5.Consultar Livros disponíveis\n"+
                                    "6.Categorias\n"                 +
                                    "7.Autores\n"                    +
                                    "8.Cadastro da Compra\n"         +
                                    "9.Consulta de Compra\n"         +
                                    "0.Sair");

            AcessarOpcao = Convert.ToInt32(Console.ReadLine());
            
        }// fim método Menu

        public void Executar()
        {
            do
            {
                Menu();
                switch (AcessarOpcao)
                {
                    
                    case 1:

                        Console.WriteLine("Informe seu nome: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Informe sua data de nascimento: ");
                        dataDN = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Informe seu telefone: ");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("Informe um usuário: ");
                        string usuario = Console.ReadLine();
                        Console.WriteLine("Informe uma senha: ");
                        string senha = Console.ReadLine();
                        Console.WriteLine("Informe um endereço");
                        string endereco = Console.ReadLine();
                        //Utilizando esses dados no método inserir
                        conexao.Inserir(nome, dataDN, telefone, usuario, senha, endereco);
                        break;

                    case 2:

                        Console.WriteLine("Informe seu usuário: ");
                        string usuario1 = Console.ReadLine();
                        Console.WriteLine("Informe sua senha: ");
                        string senha1 = Console.ReadLine();
                        Console.WriteLine(conexao.Logar(usuario1, senha1));
                        break;

                    case 3:
                        Console.WriteLine(conexao.ConsultarTudo());
                        break;

                    case 4:
                        Console.WriteLine("Informe o título do livro:");
                        string titulo = Console.ReadLine();
                        Console.WriteLine("Informe o ano de lançamento do livro:");
                        string anoDeLancamento = Console.ReadLine();
                        Console.WriteLine("Informe a editora do livro:");
                        string editora = Console.ReadLine();
                        Console.WriteLine("Informe o número de páginas do livro:");
                        int numeroDePaginas = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o valor do livro");
                        decimal valor = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Informe a quantidade de livros que deseja adicionar:");
                        int disponiveis = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o autor do livro:");
                        string autor = Console.ReadLine();
                        Console.WriteLine("Informe a categoria do livro:");
                        string categoria = Console.ReadLine();
                        conexaoLivros.InserirLivros(titulo, anoDeLancamento, editora, numeroDePaginas, valor, disponiveis, autor, categoria);
                        break;

                    case 5:

                        Console.WriteLine(conexaoLivros.ConsultarTudoLivros());
                        break;

                    case 6:
                        Console.WriteLine("\nCategorias:\n1.Mistério\n2.Ação");
                        Console.WriteLine("Digite o número referente a categoria");
                        int codigocategoriabd = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(conexaoLivros.ConsultarPorCategoria(codigocategoriabd));
                        break;

                    case 7:
                        Console.WriteLine("\nAutores disponíveis:\n1.João Inacio\n2.Benicio Casa\n3.Manoel Gomes");
                        Console.WriteLine("Digite o número do autor para ver seus livros disponíveis, ou digite 0 para voltar\n");          
                        int codigoautor = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(livros.Autor(codigoautor));
                        break;

                    case 8:

                        Console.WriteLine("Informe o Código de sua compra: ");
                        int codigoCompra = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe a data de sua compra: ");
                        var dataCompra = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Informe a quantidade de livros que irá comprar");
                        int quantidade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe a forma de pagamento: ");
                        string tipoPagamento = Console.ReadLine();
                        Console.WriteLine("Informe o valor total da compra: ");
                        decimal valorTotal = Convert.ToInt32(Console.ReadLine());
                        compra.CadastrarCompra(codigoCompra, dataCompra, quantidade, tipoPagamento, valorTotal);
                        Console.WriteLine("Cadastrado com sucesso!");
                        break;

                    case 9:
                        Console.WriteLine("Informe seu código");
                        codigoCompra = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(compra.ConsultarCompra(codigoCompra));
                        break;

                    case 0:
                        Console.WriteLine("Obirgado!");
                        break;

                    default:
                        Console.WriteLine("Código informado é invalido, digite novamente!");
                            break;

                }// fim do switch

            } while (AcessarOpcao != 0);

        }// fim do método Executar

    }// fim class

}// fim projeto
