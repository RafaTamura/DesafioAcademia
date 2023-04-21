using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace JogoDaVelha
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int jogador, linha, coluna,i,j, valor=1;
            int[,] jogo = new int[3,3];

            // Como vai rolar
            // Recebeu a informação do usuário
            Console.WriteLine("Jogo da Velha!");
            Console.WriteLine("Escolha qual jogador você quer ser, 1 = O e 2 = X ");
            jogador = int.Parse(Console.ReadLine());
            //Escolheu a posição
            Console.WriteLine("Escolha a linha: ");
            linha = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha a coluna: ");
            coluna = int.Parse(Console.ReadLine());
            
            ValidJogador(jogador);
            MostrarTabuleiro(jogo);
            Posicao(linha, coluna);


            // Validando a posição
            static void Posicao(int linha, int coluna){
                if (linha<=2 && linha >= 0 && coluna <=2 && linha >=0)
                    {
                    Console.WriteLine("Você selecionou a linha " + linha + " coluna " + coluna);
                    } else {
                    Console.WriteLine("Você digitou um valor inválido, por favor insira algum valor entre 0 a 2! ");
                }
            }

            // Criando a matriz/Jogo Da velha
            for (i=0;i<3;i++){
                for(j=0;j<3;j++){
                }
            }
            }
            //Validar o usuário 
            static int ValidJogador(int jogador){
                if (jogador == 1) {
                    Console.WriteLine("Você escolheu a O");
                    return 1;
                } else if (jogador == 2)
                {
                    Console.WriteLine("Você escolheu o X");
                    return 2;
                } else {
                    Console.WriteLine("Insira um valor válido, 1 ou 2");
                    return 3;
                }
            }

static void MostrarTabuleiro(int[,] jogo){ 
    Console.WriteLine("   0  1  2");
    for (int i = 0; i < 3; i++) {
        Console.Write(i + " ");
        for (int j = 0; j < 3; j++) {
            Console.Write("|" + jogo[i, j] + "|");
        }
        Console.WriteLine();
        Console.WriteLine("  ---------");
    }
}

static int[,] CriarTabuleiro() {
    int[,] jogo = new int[3, 3];
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            jogo[i, j] = '-';
        }
    }
    return jogo;
}


            // // Alternar Jogador
            // if (usuario == )
            // static void MostrarTabuleiro(int [,] jogo){ 
            //         Console.WriteLine("------0-----1-----2");                  
            //        Console.WriteLine("0 ->| " + jogo[0,0] + "| " + jogo[0,1] + " | " + jogo[0,2]+ " | ");
            //        Console.WriteLine(" -------------");
            //        Console.WriteLine("1-> | " + jogo[1,0] + "| " + jogo[1,1] + " | " + jogo[1,2]+ " | ");
            //        Console.WriteLine(" -------------");
            //        Console.WriteLine("2-> | " + jogo[2,0] + "| " + jogo[2,1] + " | " + jogo[2,2]+ " | ");

            //  // Tabuleiro do Jogo
            //  static int[,] TabuleiroContador()
            //  {
            //      int[,] jogo= new int[3, 3];
            //      int cont = 0, i, j;
            //  for (i = 0; i < 3; i++)
            //  {
            //      for (j = 0; j<3; j++)
            //      {
            //          cont++;
            //          jogo[i,j] = cont;
            //      }
            //  }
            //      return jogo;
            //  }


            // }
            // static void Exemplo(){

            //         Console.WriteLine(" | 1 | 2 | 3 | ");
            //         Console.WriteLine(" -------------");
            //         Console.WriteLine(" | 4 | 5 | 6 | ");
            //         Console.WriteLine(" -------------");
            //         Console.WriteLine(" | 7 | 8 | 9 | ");

            // }

            // // Transformar o valor inteiro em uma matriz
            //    linha = (posicao-1) / 3;
            //    coluna = (posicao-1) % 3;
            //    MostrarTabuleiro(jogo);

            // // Colocando a jogada do usuário
            // if (usuario == 1){
            //     jogo[linha,coluna] = 1;
            // } else if (usuario == 2){
            //     jogo[linha,coluna] = 2;
            // }
                        
            // // Para alternar os jogadores
            // static int MudarJogador(){
            //     if (usuario == 1){
            //         System.Console.WriteLine("É a vez do jogador O");
            //         return 1;
            //     }else {
            //         System.Console.WriteLine("É a vez do jogador X");
            //         return 2;
            //     }
            // }
    }
}