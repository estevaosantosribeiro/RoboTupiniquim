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
            string comandos = "MMM";
            char[] arrayComandos = comandos.ToCharArray();

            Console.WriteLine($"posição inicial: {posicaoX} {posicaoY} {direcao}");
            
            for(int elemento = 0; elemento < arrayComandos.Length; elemento++)
            {
                char comando = arrayComandos[elemento];
                
                if(comando == 'M' && direcao == 'N')
                {
                    posicaoY += 1;
                } else if (comando == 'M' && direcao == 'L')
                {
                    posicaoX += 1;
                } else if (comando == 'M' && direcao == 'S')
                {
                    posicaoY -= 1;
                } else if (comando == 'M' && direcao == 'O')
                {
                    posicaoX -= 1;
                }
            }

            Console.WriteLine($"posição final: {posicaoX} {posicaoY} {direcao}");

            Console.ReadLine();
        }
    }
}
