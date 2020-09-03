using System;

namespace Consultorio2
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao = 0;
            do
            {
                Tela.Menu();

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Tela.CadastrarPaciente();
                        break;
                    case 2:
                        Tela.CadastrarMedico();
                        break;
                    case 3:
                        Tela.CadastrarConsulta();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao!=0);                 
        }
    }
}
