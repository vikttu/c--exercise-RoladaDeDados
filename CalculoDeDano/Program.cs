using CalculoDeDano.Service;
using System;

namespace CalculoDeDano
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoDeDanoService calculoDeDanoService = new CalculoDeDanoService();
            calculoDeDanoService.CalculoDeDano();
        }
    }
}
