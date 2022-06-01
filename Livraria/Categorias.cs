using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Categorias
    {
        Livros livros;
        public Categorias()
        {

            livros = new Livros();
        }
        private int codigoCategorias;
        private string biografia;
        private string saude;
        private string manga;

        public int AcessarCodigoCategorias
        {
            get
            {
                return codigoCategorias;
            }
            set
            {
                this.codigoCategorias = value;
            }

        }
        public string AcessarBiografia
        {
            get
            {
                return biografia;
            }
            set
            {
                this.biografia = "";
            }

        }
        public string AcessarSaude
        {
            get
            {
                return saude;
            }
            set
            {
                this.saude = "";
            }

        }
        public string AcessarManga
        {
            get
            {
                return manga;
            }
            set
            {
                this.manga = "";
            }

        }

        public string CategoriasBiografia(int codigo)
        {
            do
            {


            } while (codigo = 1);

        }


    }

 
}
