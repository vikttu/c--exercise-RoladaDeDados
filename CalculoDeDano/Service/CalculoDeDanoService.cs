using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculoDeDano.Enum;

namespace CalculoDeDano.Service
{
    class CalculoDeDanoService
    {
        public void CalculoDeDano()
        {
            string valorEntrada = ObterOValorDeEntrada();

            string[] entradaSeparada = valorEntrada.Split(":");
            string tipoAtaque = entradaSeparada[0];
            string valorDados = entradaSeparada[1];


            TiposDeAtaque tipoDeAtaque = ObterTiposDeAtaque(tipoAtaque);

            List<int> listaDeValoresDeDados = ExtrairValoresDosDados(valorDados);

            int resultado = CalcularDanoTomado(listaDeValoresDeDados, tipoDeAtaque);

            Console.WriteLine(resultado);
        }

        private static TiposDeAtaque ObterTiposDeAtaque(string tipoAtaque)
        {
            TiposDeAtaque tipoDeAtaque = TiposDeAtaque.CorpoACorpo;

            if (tipoAtaque == "corpo-a-corpo")
            {
                tipoDeAtaque = TiposDeAtaque.CorpoACorpo;
            }
            else if (tipoAtaque == "direto")
            {
                tipoDeAtaque = TiposDeAtaque.Direto;
            }

            return tipoDeAtaque;
        }

        private static List<int> ExtrairValoresDosDados(string valorDados)
        {
            string[] valoresDosDadosSeparados = valorDados.Split(" ");
            List<string> listaDeValoresDeDadosString = valoresDosDadosSeparados.ToList();
            List<int> listaDeValoresDeDadosInt = new List<int>();
            foreach (string valorDado in listaDeValoresDeDadosString)
            {
                if (valorDado != "")
                {
                    int valorDadoNovo = Convert.ToInt32(valorDado);
                    listaDeValoresDeDadosInt.Add(valorDadoNovo);

                }

            }

            return listaDeValoresDeDadosInt;
        }

        private static int CalcularDanoTomado(List<int> listaDeValoresDeDados, TiposDeAtaque tipoDeAtaque)
        {

            int resultado = 0;

            if (tipoDeAtaque == TiposDeAtaque.CorpoACorpo){

                foreach (int coisa in listaDeValoresDeDados)
                {
                    if (coisa >= 4)
                    {
                        resultado++;
                    }
                }
            
            }

            if (tipoDeAtaque == TiposDeAtaque.Direto)
            {

                foreach (int coisa in listaDeValoresDeDados)
                {
                    if (coisa >= 5)
                    {
                        resultado++;
                    }
                }

            }

            return resultado;
        }


        private static string ObterOValorDeEntrada()
        {
            Console.WriteLine("Insira o tipo de ataque e o valor dos dados rolados: ");
            string valorEntrada = Console.ReadLine();
            return valorEntrada;
        }
    }
}
