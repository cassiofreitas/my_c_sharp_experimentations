using System.Collections;

namespace ConversorMoedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ChoiceExit = 'N';
            double ValorMoedaConverterDe = 0;
            double ValorMoedaConvertida = 0;
            string? MoedaConverterDe;
            string? MoedaConverterPara;
            //
            // This routine simulates an externa DataSource initialiation
            // For awhile, it is hard coded at DataSources.cs
            DataSource DataSourceNow = new DataSource();
            DataSourceNow.InitialDataLoad();
            //
            do
            {
                Console.Clear();
                //Console.Beep();
                Console.ForegroundColor = ConsoleColor.Yellow;
                //
                Console.WriteLine("Últimas 5 conversões:\n");
                Console.WriteLine("de N,NN MOEDADE para N,NN MOEDAPARA"); // tem uma classe ou método que só faz isso
                Console.WriteLine("de N,NN MOEDADE para N,NN MOEDAPARA");
                Console.WriteLine("de N,NN MOEDADE para N,NN MOEDAPARA");
                Console.WriteLine("de N,NN MOEDADE para N,NN MOEDAPARA");
                Console.WriteLine("de N,NN MOEDADE para N,NN MOEDAPARA");
                Console.WriteLine("".PadRight(40, '-'));
                //
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Moedas disponíveis para conversão:");
                Console.Write(DataSourceNow.ListSupportedCoins());
                //
                Console.WriteLine("".PadRight(40, '-'));
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Converter");
                Console.Write("DE   (Símbolo): ");
                MoedaConverterDe = Console.ReadLine().ToUpper();
                Console.Write("PARA (Símbolo): ");
                MoedaConverterPara = Console.ReadLine().ToUpper();
                Console.WriteLine("".PadRight(40, '-'));
                //
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[ 0,0000 {MoedaConverterDe} ] = [ 0,0000 {MoedaConverterPara} ]");
                Console.WriteLine("".PadRight(40, '-'));
                Console.ForegroundColor = ConsoleColor.Yellow;
                //
                Console.WriteLine("\nPor favor, leia os resultados da conversão.");
                Console.Write($"[ S ] para SAIR >");
                char.TryParse(Console.ReadLine(), out ChoiceExit);
            } while (char.ToUpper(ChoiceExit) is not 'S');
        }
    }
}