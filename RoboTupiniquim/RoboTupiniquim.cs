namespace RoboTupiniquim
{
    internal class RoboTupiniquim
    {
        public static int posicaoX;
        public static int posicaoY;
        public static char direcao;

        public static void DefinirPosicaoInicial(string[] coordenadasIniciais)
        {
            RoboTupiniquim.posicaoX = ObterPosicaoX(coordenadasIniciais);
            RoboTupiniquim.posicaoY = ObterPosicaoY(coordenadasIniciais);
            RoboTupiniquim.direcao = ObterDirecao(coordenadasIniciais);
        }

        public static string[] Movimentar(char[] movimentos)
        {
            for (int elemento = 0; elemento < movimentos.Length; elemento++)
            {
                char movimento = movimentos[elemento];

                // movimentação do robô
                switch (movimento)
                {
                    case 'D':
                        direcao = RotacionarDireita(direcao);
                        break;
                    case 'E':
                        direcao = RotacionarEsquerda(direcao);
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

            string[] coordenadasFinais = $"{posicaoX} {posicaoY} {direcao}".Split(" ");
            return coordenadasFinais;
        }

        static int ObterPosicaoX(string[] coordenadas)
        {
            int posicaoX = Convert.ToInt32(coordenadas[0]);
            return posicaoX;
        }

        static int ObterPosicaoY(string[] coordenadas)
        {
            int posicaoY = Convert.ToInt32(coordenadas[1]);
            return posicaoY;
        }

        static char ObterDirecao(string[] coordenadas)
        {
            char direcao = Convert.ToChar(coordenadas[2]);
            return direcao;
        }

        private static int MovimentarVerticalmente(int posicaoY, int direcao)
        {
            switch (direcao)
            {
                case 'N':
                    posicaoY += 1;
                    break;
                case 'S':
                    posicaoY -= 1;
                    break;
            }
            return posicaoY;
        }

        private static int MovimentarHorizontalmente(int posicaoX, int direcao)
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

        private static char RotacionarDireita(char direcao)
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

        private static char RotacionarEsquerda(char direcao)
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
