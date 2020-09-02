using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDotNet.CursoCSharp.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //var nomecorrentista = "ricardo cassiano";
            //console.write("nome do correntista: " + nomecorrentista);
            //console.readline();
            //console.write("digite o nome do próximo correntista: ");
            //nomecorrentista = console.readline();
            //console.write("o nome do correntista digitado foi: " + nomecorrentista);
            //console.readline();

            //datetime datanasc = new datetime(2002, 12, 02);
            //console.write("a data do seu aniversário é: " + datanasc);
            //console.readline();

            ////double type
            //double saldo = 100.0;
            //saldo = saldo - 10.0;
            //console.write("o saldo atual é: " + saldo);
            //console.readline();

            //Arrays
            //String[] nomes = new string[5];
            //nomes[0] = "Ricardo Cassiano";

            //Console.Write(nomes[0]);
            //Console.Write(nomes[1]);
            //Console.ReadLine();

            //int[] idades = new int[] { 1, 2, 20 };
            //Console.Write(idades[0] + "\n");
            //Console.Write(idades[1] + "\n");
            //Console.Write(idades[2] + "\n");
            //Console.ReadLine();

            //Constantes
            //const double Pi = 3.14159;
            //double radius = 5.3;
            //double area = Pi * (radius * radius);

            //Console.Write("O valor da área é: " + area);
            //Console.ReadLine();

            ////Listas
            //List<String> nomes = new List<String>();
            //nomes.Add("Fulano");
            //nomes.Add("Beltrano");

            //Console.Write("O primeiro item da lista é: " + nomes[0]);
            //Console.ReadLine();

            //Trabalhando com Enums
            var dia = DiasDaSemana.QuintaFeira;
            Console.Write("O dia da semana é: " + dia);
            Console.ReadLine();

            //Casting
            int diaDeFeira = (int)DiasUteisDaSemana.SegundaFeira;
            Console.Write("O dia da feira é: " + diaDeFeira);
            Console.ReadLine();
        }

        enum DiasDaSemana
        {
            SegundaFeira,
            TerçaFeira,
            QuartaFeira,
            QuintaFeira,
            SextaFeira,
            Sábado,
            Domingo
        };

        //Enum com valores pré definidos
        enum DiasUteisDaSemana
        {
            SegundaFeira = 0,
            TerçaFeira = 1,
            QuartaFeira = 2,
            QuintaFeira = 3,
            SextaFeira = 4
        };
    }
}
