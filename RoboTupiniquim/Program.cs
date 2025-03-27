namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoGrid = 5;
            int posicaoX = 1;
            int posicaoY = 1;
            char direcao = 'N';
            string comandos = "MMMD";
            char[] arrayComandos = comandos.ToCharArray();

            Console.WriteLine($"posição inicial: {posicaoX} {posicaoY} {direcao}");

            for (int elemento = 0; elemento < arrayComandos.Length; elemento++)
            {
                char comando = arrayComandos[elemento];

                // rotação do robô
                switch (comando)
                {
                    case 'D':
                        direcao = MudarDirecaoDireita(direcao);
                        break;
                    case 'E':
                        direcao = MudarDirecaoEsquerda(direcao);
                        break;
                }

                // movimentação para frente
                if (comando == 'M' && direcao == 'N')
                {
                    posicaoY += 1;
                }
                else if (comando == 'M' && direcao == 'L')
                {
                    posicaoX += 1;
                }
                else if (comando == 'M' && direcao == 'S')
                {
                    posicaoY -= 1;
                }
                else if (comando == 'M' && direcao == 'O')
                {
                    posicaoX -= 1;
                }
            }

            Console.WriteLine($"posição final: {posicaoX} {posicaoY} {direcao}");

            Console.ReadLine();
        }

        static char MudarDirecaoDireita(char direcao)
        {
            switch (direcao)
            {
                case 'N':
                    direcao = 'L';
                    break;
                case 'L':
                    direcao = 'S';
                    break;
                case 'S':
                    direcao = 'O';
                    break;
                case 'O':
                    direcao = 'N';
                    break;
            }
            return direcao;
        }

        static char MudarDirecaoEsquerda(char direcao)
        {
            switch (direcao)
            {
                case 'N':
                    direcao = 'O';
                    break;
                case 'L':
                    direcao = 'N';
                    break;
                case 'S':
                    direcao = 'L';
                    break;
                case 'O':
                    direcao = 'S';
                    break;
            }
            return direcao;
        }
    }
}
