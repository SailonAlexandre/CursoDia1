using System;
using System.Text;

namespace projetoCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            // int first = 2;
            // string second = "4";
            // int result = first + Int32.Parse(second);
            // Console.WriteLine(result);
            // System.Console.WriteLine($"size of int16 = {sizeof(Int16)}");
            // System.Console.WriteLine($"int16.MinValue ={Int16.MinValue}");
            // System.Console.WriteLine($"Int16.MaxValue = {Int16.MaxValue}");
            // System.Console.WriteLine($"size of Int32 = {sizeof(Int32)}");
            // System.Console.WriteLine($"Int32.MinValue = {Int32.MinValue}");
            // System.Console.WriteLine($"Int32.MaxValue ={Int32.MaxValue}");
            // System.Console.WriteLine("Informe um nome");
            // string nome = Console.ReadLine(); 
            // System.Console.WriteLine("Informe o endereço");
            // string endereço = Console.ReadLine();
            // System.Console.WriteLine("Informe o numero do endereço");
            // int numero = Int32.Parse(Console.ReadLine());
            // System.Console.WriteLine("Informe o bairro");
            // string bairro = Console.ReadLine();
            // System.Console.WriteLine("Informe a cidade");
            // string cidade = Console.ReadLine();
            // System.Console.WriteLine("Informe o estado");
            // string estado = Console.ReadLine();
            // System.Console.WriteLine("Informe o cep");
            // int cep = Int32.Parse(Console.ReadLine());
            // System.Console.WriteLine("Informe o cpf");
            // int cpf = Int32.Parse(Console.ReadLine());
            

            // System.Console.WriteLine("Digite o valor: ");
            // // int valor = Int32.Parse(Console.ReadLine());
            // var valorCompraTemp = Console.ReadLine();
            // double valorCompra;
            // if(!double.TryParse(valorCompraTemp, out valorCompra))
            // {
            //     Console.WriteLine("Valor incorreto!");
            // }
            // else
            // { 
            //     System.Console.WriteLine("OK!");
            // }       
            // int somaNotas = 0;
            // for (int i = 0; i <= 2; i++)
            // {
            //     System.Console.WriteLine("Informe a nota");
            //     int nota = Int32.Parse(Console.ReadLine());
                
            //     somaNotas = somaNotas + nota; 
            // }
            // int media = somaNotas / 3;

            // if ( media >= 7)
            // {
            //     System.Console.WriteLine("Aluno aprovado!");
            // }
            // else if (media <= 5)
            // {
            //     System.Console.WriteLine("Aluno reprovado");
            // }
            // else
            // {
            //     System.Console.WriteLine("Em exame");
            // }
            int valor = (int)1.5; // cast explícito
            System.Console.WriteLine(valor);
            object val = new StringBuilder();

            if (val is StringBuilder) // verificaçao do cast com IS
            {
                StringBuilder builder = val as StringBuilder; // cast com operador AS
                System.Console.WriteLine(builder.Length == 0);
            } 
            
            
        }
    }
}
