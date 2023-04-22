namespace DesafioJogoDaVelha
{
    internal class Program

    {
        static void Main(string[] args)
        {
            int jogador, linha, coluna, igual;
            int i, j;
            int[,] jogo = CriarTabuleiro();


            // Como vai rolar
            // Recebeu a informação do usuário
            Console.WriteLine("Jogo da Velha!");
            Console.WriteLine("Escolha qual jogador você quer ser, 1 = O e 2 = X ");
            jogador = int.Parse(Console.ReadLine());

            //Escolher a posição
                for (int cont=0; cont<18; cont++)
            {
                cont++;
                ValidJogador(jogador);
                MostrarTabuleiro(jogo);
                Posicao( out linha,out coluna, jogo, jogador);
                jogador = MudarJogador(jogador);
                Vencedor(jogo,out igual);
                Console.Clear();
            }



            // Validando a posição
            static void Posicao(out int linha, out int coluna, int[,]jogo, int jogador)
            {
                do
                { 
                    Console.WriteLine("Digite a linha: ");
                    linha = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a coluna: ");
                    coluna = int.Parse(Console.ReadLine());

                    if (jogo[linha, coluna] != ' ')
                    {
                        Console.WriteLine("Opa! Você já escolheu aqui! Digite outra posição. ");
                    }
                } while (jogo[linha, coluna] != ' ');
                {
                    jogo[linha, coluna] = jogador;

                    MostrarTabuleiro(jogo);
                }
            }

                MostrarTabuleiro(jogo);

                if (Vencedor(jogo, out igual)){
                if (igual == 222)
                {
                    Console.WriteLine("O vencedor é o X!");

                } else if (igual == 111)
                {
                    Console.WriteLine("O vencedor é a O!");

                }

         
            }
            // Criando a matriz/Jogo Da velha
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                }
            }
        }
         // Para alternar os jogadores
         static int MudarJogador(int jogador){
             if (jogador == 1){
                 Console.WriteLine("É a vez do jogador X");
                 return 2;
             }else {
                 Console.WriteLine("É a vez do jogador O");
                return 1;
             }
        }
        //Validar o usuário 
        static int ValidJogador(int jogador)
        {
            if (jogador == 1)
            {
                Console.WriteLine("É a vez da O");
                return 1;
            }
            else if (jogador == 2)
            {
                Console.WriteLine("É a vez do X");
                return 2;
            }
            else
            {
                Console.WriteLine("Insira um valor válido, 1 ou 2");
                return 3;
            }
        }

        // Parte visual do Jogo da velha, foi mais dificíl do que imaginava
        static void MostrarTabuleiro(int[,] jogo)
        {
            Console.WriteLine("   0   1   2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i+ "->");
                for (int j = 0; j < 3; j++)
                {
                    if (jogo[i, j] == 1)
                    {
                        Console.Write("[O]");
                    }
                    else if (jogo[i, j] == 2)
                    {

                        Console.Write("[X]");
                    }
                    else
                    {
                        Console.Write("[ ]");
                    }
                }
                    Console.WriteLine();
            }
        }

        //Contador para a montagem do Jogo da velha
        static int[,] CriarTabuleiro()
        {
            int[,] jogo = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Convert.ToChar(jogo[i, j] = ' ');
                }
            }
            return jogo;
        }

        //Vencedor!!
        static bool Vencedor(int[,] jogo, out int igual)
        {
                igual = 0;
            for (int venc = 0; venc < 8; venc++)
            {
                switch (venc)
                {
                    case 0:
                        igual = jogo[0, 0] + jogo[1, 0] + jogo[2, 0];
                        break;
                    case 1:
                        igual = jogo[0, 0] + jogo[1, 1] + jogo[2, 2];
                        break;
                    case 2:
                        igual = jogo[0, 0] + jogo[0, 1] + jogo[0, 2];
                        break;
                    case 3:
                        igual = jogo[1, 0] + jogo[1, 1] + jogo[1, 2];
                        break;
                    case 4:
                        igual = jogo[2, 0] + jogo[2, 1] + jogo[2, 2];
                        break;
                    case 5:
                        igual = jogo[0, 2] + jogo[1, 2] + jogo[2, 2];
                        break;
                    case 6:
                        igual = jogo[0, 2] + jogo[1, 1] + jogo[2, 0];
                        break;
                    case 7:
                        igual = jogo[0, 1] + jogo[1, 1] + jogo[2, 1];
                        break;
                }
                if (igual == 222 || igual == 111)
                {
                    return true;
                }
            }
            return false;
        }
        }

    }
