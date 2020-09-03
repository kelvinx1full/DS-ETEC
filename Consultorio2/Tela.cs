using System;
using System.Collections.Generic;
using System.Text;

namespace Consultorio2
{
    public static class Tela
    {
        public static void Menu()
        {
            Console.Clear();

            Console.WriteLine(" Seja Bem-Vindo" +
                              " \n O que deseja fazer?" +
                              " \n 1- Cadastrar paciente " +
                              "\n 2- Cadastrar medico " +
                              "\n 3- Marcar consulta" +
                              " \n 0-Finalizar");

        }
        public static void CadastrarPaciente()
        {
            string con = " ";

            bool continuar = true;

            do
            {

                Paciente PA = new Paciente();

                Console.Clear();

                Console.WriteLine("Digite o nome do paciente: ");

                PA.Nome = (Console.ReadLine());

                Console.WriteLine("Digite o CPF do paciente: ");

                PA.Cpf = (Console.ReadLine());

                Console.WriteLine("Digite a data de nascimento do paciente: ");

                PA.DataNascimento = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Digite o convênio do paciente: ");

                PA.Convenio = (Console.ReadLine());

                Console.WriteLine("Digite a data da primeira consulta: ");

                PA.DataPrimeiraConsulta = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Você deseja continuar ?");

                con = Console.ReadLine();

                if (con.ToUpper() == "S" || con.ToUpper() == "SIM")
                {
                    continuar = false;

                }

            } while (continuar == true); 
        }

        public static void CadastrarMedico()
        {
            string con = " ";

            bool continuar = true;

            do
            {
                Medico MD = new Medico();

                Console.Clear();

                Console.WriteLine("Digite o nome do médico: ");

                MD.Nome = (Console.ReadLine());

                Console.WriteLine("Digite o CPF do médico: ");

                MD.Cpf = (Console.ReadLine());

                Console.WriteLine("Digite a data de nascimento do médico: ");

                MD.DataNascimento = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Digite o CMR do médico: ");

                MD.Cmr = (Console.ReadLine());

                Console.WriteLine("Digite a especialidade do médico: ");

                MD.Especialidade = (Console.ReadLine());

                Console.WriteLine("Você deseja continuar ?");

                con = Console.ReadLine();

                if (con.ToUpper() == "S" || con.ToUpper() == "SIM")

                {

                    continuar = false;

                }

            } while (continuar == true);
        }

        public static void CadastrarConsulta()
        {
            string con = " ";

            bool continuar = true;

            do
            {
                Consulta CS = new Consulta();

                Console.Clear();

                Console.WriteLine("Digite a data da consulta: ");

                CS.DataConsulta = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Digite a data do seu cadastro: ");

                CS.DataDoCadastro = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Digite o motivo da consulta: ");

                CS.MotivoDaConsulta = (Console.ReadLine());

                Console.WriteLine("Você deseja continuar ? ");

                con = Console.ReadLine();

                if (con.ToUpper() == "S" || con.ToUpper() == "SIM")

                {

                    continuar = false;

                }

            } while (true);
            

            
        }





            
            



        
    }
}
