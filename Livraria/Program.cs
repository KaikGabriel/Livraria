using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteBD con = new ClienteBD();
            ControlLivraria control = new ControlLivraria();
            control.Executar();
            Console.ReadLine();

        }// fim método main

    }// fim class

}// fim projeto
