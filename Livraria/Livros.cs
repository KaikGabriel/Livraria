using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Livros
    {
        private int codigocategoria;
        private int codigoautor;
        private string livro1 = "\n\nTítulo: Mindset: A nova psicologia do sucesso\nAno de lançamento: 2017\nEditora: Objetiva\nNúmero de páginas: 180\nValor: R$37,60\nDisponíveis: 10\n";
        private string livro2 = "\n\nTítulo: O poder do hábito\nAno de lançamento: 2012\nEditora: Editora Objetiva\nNúmero de páginas: 408\nValor: R$35,10\nDisponíveis: 2\n";
        private string livro3 = "\n\nTítulo: Do Mil ao Milhão. Sem Cortar o Cafezinho\nAno de Lançamento: 2018\nEditora: HarperCollins\nNúmero de páginas: 192\nValor: R$25,40\nDisponíveis: 15\n";
        private string livro4 = "\n\nTítulo: As armas da persuasão: Como influenciar e não se deixar influenciar\nAno de Lançamento: 2012\nEditora: Sextante\nNúmero de Páginas: 304\nValor: R$39,92\nDisponíveis: 7\n";
        private string livro5 = "\n\nTítulo: Pai rico, pai pobre: Edição de 20 anos atualizada e ampliada\nAno de Lançamento: 2017\nEditora: Alta Books\nNúmero de páginas: 336\nValor: R$34,90\nDisponíveis: 12\n";
        private string livro6 = "\n\nTítulo: Quem pensa enriquece\nAno de lançamento: 2018\nEditora: Citadel\nNúmero de páginas: 364\nValor: R$19,60\nDisponíveis: 40\n";
        private string historia;
        private string comedia;
        private string quadrinhos;


       public int AcessarCodigoAutor
        {
            get
            {

                return codigoautor;

            }
            set
            {

                this.codigoautor = value;

            }
        }// Fim método AcessarCodigoAutor

       public string AcessarQuadrinhos
        {
            get
            {

                return quadrinhos;

            }
            set
            {

                this.quadrinhos = "";

            }
        }// Fim método AcessarQuadrinhos 
        
        public string AcessarComedia
        {
            get
            {

                return comedia;

            }
            set
            {

                this.comedia = "";

            }
        }// Fim método AcessarComedia

        public int AcessarCodigoCategoria
        {
            get
            {

                return codigocategoria;

            }
            set
            {

                this.codigocategoria = value;

            }

        }// Fim método AcessarCodigoCategoria

        public string AcessarHistoria
        {
            get
            {

                return historia;

            }
            set
            {

                this.historia = "";

            }

        }// Fim método AcessarHistoria


        public string AcessarLivro1
        {
            get
            {

                return livro1;

            }

            set
            {

                this.livro1 = "";

            }

        }// Fim método AcessarLivros1

        public string AcessarLivro2
        {
            get
            {

                return livro2;

            }

            set
            {

                this.livro2 = "";

            }

        }// Fim método AcessarLivros2

        public string AcessarLivro3
        {
            get
            {

                return livro3;

            }

            set
            {

                this.livro3 = "";

            }

        }// Fim método AcessarLivros3

        public string AcessarLivro4
        {
            get
            {

                return livro4;

            }
            set
            {

                this.livro4 = "";

            }
        }// Fim método AcessarLivros4

        public string AcessarLivro5
        {
            get
            {

                return livro5;

            }
            set
            {

                this.livro5 = "";

            }
        }// Fim método AcessarLivros5

        public string AcessarLivro6
        {
            get
            {

                return livro6;

            }
            set
            {

                this.livro6 = "";

;           }
        }// Fim método AcessarLivros6

        public string ConsultarLivros()
        {
           



            return "Livro1: "       + AcessarLivro1  +
                   "\nLivro2: "     + AcessarLivro2  +
                   "\nLivro3: "     + AcessarLivro3  +
                   "\nLivro4:"      + AcessarLivro4  +
                   "\nLivro5:"      + AcessarLivro5  +
                   "\nLivro6:"      + AcessarLivro6;


        }// Fim método ConsultarLivros 

        public string Categorias(int codigocategoria)
        {
           
            historia = livro1 +livro4;
            comedia = livro2 +livro5;
            quadrinhos = livro3 +livro6;
            AcessarCodigoCategoria = codigocategoria;
            if(AcessarCodigoCategoria == 1)
            {
                return historia;
            }
            if(AcessarCodigoCategoria == 2)
            {
                return comedia;
            }
            if (AcessarCodigoCategoria == 3)
            {
                return quadrinhos;
            }
            else
            {
                return "Código inválido";
            }

        }// Fim método Categorias
        
        public string Autor(int codigoautor)
        {   
            AcessarCodigoAutor = codigoautor;
            if(AcessarCodigoAutor == 0)
            {
                return "";
            }
            if(AcessarCodigoAutor == 1)
            {
                return "\nLivros disponíveis desse(a) autor(a):\n"+livro1;
            }
            if(AcessarCodigoAutor == 2)
            {
                return "\nLivros disponíveis desse(a) autor(a):\n"+livro2;
            }
            if(AcessarCodigoAutor == 3)
            {
                return "\nLivros disponíveis desse(a) autor(a):\n"+livro3;
            }
            else
            {
                return "Autor inválido";
            }
        }// Fim método Autor




    }// fim class

}// fim projeto
