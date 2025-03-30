namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int tamanhoGrid = 5;
            char[] movimentos;
            string[] coordenadasIniciais;

            coordenadasIniciais = ObterCoordenadas();

            RoboTupiniquim.DefinirPosicaoInicial(coordenadasIniciais);

            movimentos = ObterMovimentos();

            ExibirPosicaoInicial(RoboTupiniquim.posicaoX, RoboTupiniquim.posicaoY, RoboTupiniquim.direcao);

            RoboTupiniquim.Movimentar(movimentos);

            ExibirPosicaoFinal(RoboTupiniquim.posicaoX, RoboTupiniquim.posicaoY, RoboTupiniquim.direcao);

            Console.ReadLine();
        }

        static string[] ObterCoordenadas()
        {
            Console.Write("Digite a posição e direção inicial: ");
            string coordenadasIniciais = Console.ReadLine()!;
            string[] coordenadas = coordenadasIniciais.Split(" ");
            return coordenadas;
        }

        static char[] ObterMovimentos()
        {
            Console.Write("Digite a sequência de movimentos: ");
            char[] movimentos = Console.ReadLine()!.ToCharArray();
            return movimentos;
        }

        static void ExibirPosicaoInicial(int posicaoX, int posicaoY, char direcao)
        {
            Console.WriteLine($"posição inicial: {posicaoX} {posicaoY} {direcao}");
        }

        static void ExibirPosicaoFinal(int posicaoX, int posicaoY, char direcao)
        {
            Console.WriteLine($"posição final: {posicaoX} {posicaoY} {direcao}");
        }
    }
}
