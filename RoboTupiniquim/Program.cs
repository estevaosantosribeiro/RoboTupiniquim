namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DefinirArea();
            GuiarRobos();
            while (DesejaGuiarNovamente())
            {
                GuiarRobos();
            }

            Console.ReadLine();
        }

        static void DefinirArea()
        {
            Console.Write("Digite o tamanho da área em que os robôs se movimentarão: ");
            string areaInformada = Console.ReadLine()!;
            Console.WriteLine();
            string[] area = areaInformada.Split(" ");
            int areaX = Convert.ToInt32(area[0]);
            int areaY = Convert.ToInt32(area[1]);
            RoboTupiniquim.DefinirArea(areaX, areaY);
        }

        static void GuiarRobos()
        {
            Console.WriteLine("Movimente o primeiro robô!\n");
            MovimentarRobo();
            Console.WriteLine("\nMovimente o segundo robô!\n");
            MovimentarRobo();
        }

        static void MovimentarRobo()
        {
            bool posicaoValida = false;

            while (!posicaoValida)
            {
                string[] coordenadasIniciais = ObterCoordenadas();

                RoboTupiniquim.DefinirPosicaoInicial(coordenadasIniciais);

                int posicaoInicialX = RoboTupiniquim.posicaoX;
                int posicaoInicialY = RoboTupiniquim.posicaoY;
                char direcaoInicial = RoboTupiniquim.direcao;

                char[] movimentos = ObterMovimentos();

                RoboTupiniquim.Movimentar(movimentos);

                posicaoValida = ValidarPosicao();

                if (!posicaoValida)
                {
                    Console.WriteLine("Erro, O robô colidiu com a borda!\n\nTente novamente.\n");
                }
                else
                {
                    ExibirPosicaoInicial(posicaoInicialX, posicaoInicialY, direcaoInicial);
                    ExibirPosicaoFinal(RoboTupiniquim.posicaoX, RoboTupiniquim.posicaoY, RoboTupiniquim.direcao);
                }
            }
        }

        static bool DesejaGuiarNovamente()
        {
            Console.Write("\nDeseja mover os robôs novamente? (S/N) ");
            char resposta = Convert.ToChar(Console.ReadLine()!.ToUpper());
            Console.WriteLine();
            if (resposta != 'S')
            {
                return false;
            }
            Console.Clear();
            return true;
        }

        static bool ValidarPosicao()
        {
            if (RoboTupiniquim.posicaoX < 0 ||
                RoboTupiniquim.posicaoY < 0 ||
                RoboTupiniquim.posicaoY > RoboTupiniquim.areaY ||
                RoboTupiniquim.posicaoX > RoboTupiniquim.areaX)
            {
                return false;
            }

            return true;
        }

        static string[] ObterCoordenadas()
        {
            Console.Write("Digite a posição e direção inicial do robô: ");
            string coordenadasIniciais = Console.ReadLine()!.ToUpper();
            string[] coordenadas = coordenadasIniciais.Split(" ");
            return coordenadas;
        }

        static char[] ObterMovimentos()
        {
            Console.Write("Digite a sequência de movimentos: ");
            char[] movimentos = Console.ReadLine()!.ToUpper().ToCharArray();
            Console.WriteLine();
            return movimentos;
        }

        static void ExibirPosicaoInicial(int posicaoX, int posicaoY, char direcao)
        {
            Console.WriteLine($"Posição inicial: {posicaoX} {posicaoY} {direcao}");
        }

        static void ExibirPosicaoFinal(int posicaoX, int posicaoY, char direcao)
        {
            Console.WriteLine($"Posição final: {posicaoX} {posicaoY} {direcao}");
        }
    }
}
