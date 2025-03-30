namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoGrid = 5;
            int posicaoX, posicaoY;
            char direcao;
            string comandos;
            char[] arrayComandos;
            string[] arrayCoordenadas;

            // entradas
            Console.Write("Digite a posição e direção inicial: ");
            string coordenadasIniciais = Console.ReadLine()!;
            arrayCoordenadas = coordenadasIniciais.Split(" ");

            posicaoX = Convert.ToInt32(arrayCoordenadas[0]);
            posicaoY = Convert.ToInt32(arrayCoordenadas[1]);
            direcao = Convert.ToChar(arrayCoordenadas[2]);

            Console.Write("Digite a sequência de movimentos: ");
            comandos = Console.ReadLine()!;

            arrayComandos = comandos.ToCharArray();

            Console.WriteLine($"posição inicial: {posicaoX} {posicaoY} {direcao}");

            for (int elemento = 0; elemento < arrayComandos.Length; elemento++)
            {
                char comando = arrayComandos[elemento];

                // movimentação do robô
                switch (comando)
                {
                    case 'D':
                        direcao = MudarDirecaoDireita(direcao);
                        break;
                    case 'E':
                        direcao = MudarDirecaoEsquerda(direcao);
                        break;
                    case 'M':
                        if (direcao == 'N' || direcao == 'S')
                        {
                            posicaoY = MovimentarVerticalmente(posicaoY, direcao);
                        }
                        else if (direcao == 'L' || direcao == 'O')
                        {
                            posicaoX = MovimentarHorizontalmente(posicaoX, direcao);
                        }
                        break;
                }
            }

            Console.WriteLine($"posição final: {posicaoX} {posicaoY} {direcao}");

            Console.ReadLine();
        }

        static int MovimentarVerticalmente(int posicaoY, int direcao)
        {
            switch (direcao){
                case 'N':
                    posicaoY += 1;
                    break;
                case 'S':
                    posicaoY -= 1;
                    break;
            }
            return posicaoY;
        }

        static int MovimentarHorizontalmente(int posicaoX, int direcao)
        {
            switch (direcao)
            {
                case 'L':
                    posicaoX += 1;
                    break;
                case 'O':
                    posicaoX -= 1;
                    break;
            }
            return posicaoX;
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
