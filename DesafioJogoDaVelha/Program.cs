namespace DesafioJogoDaVelha
{
    internal class Program

    {
        static void Main(string[] args)
        {
            int[,] jogo = CriarTabuleiro();
            int jogador = 1, linha, coluna;
            bool jogando = true;

            while (jogando)
            {
                MostrarTabuleiro(jogo);
                jogador = MudarJogador(jogador);
                Console.WriteLine($"Jogador {jogador}, insira a linha: ");
                linha = int.Parse(Console.ReadLine());
                Console.WriteLine($"Jogador {jogador}, insira a coluna: ");
                coluna = int.Parse(Console.ReadLine());
                if (jogo[linha, coluna] == 0)
                {
                    jogo[linha, coluna] = jogador;
                    if (Vencedor(jogo))
                    {
                        jogando = false;
                        Console.WriteLine($"O jogador {jogador} venceu!");
                    }
                    else if (Empate(jogo))
                    {
                        jogando = false;
                        Console.WriteLine("Deu Velha!!");
                    }
                }
                else
                {
                    Console.WriteLine("Aqui já foi hein, escolha outra posição. ");
                }
            }
            MostrarTabuleiro(jogo);
            //Empate
            static bool Empate(int[,] jogo)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (jogo[i, j] == 0)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

            // Para alternar os jogadores
            static int MudarJogador(int jogador)
            {
                if (jogador == 1)
                {
                    Console.WriteLine("É a vez do jogador X");
                    return 2;
                }
                else
                {
                    Console.WriteLine("É a vez do jogador O");
                    return 1;
                }
            }
            // Parte visual do Jogo da velha, foi mais dificíl do que imaginava
            static void MostrarTabuleiro(int[,] jogo)
            {
                Console.WriteLine("   0   1   2");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(i + "->");
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
                //for (int i = 0; i < 3; i++)
                //{
                //    for (int j = 0; j < 3; j++)
                //    {
                //        (jogo[i, j] = ' ');
                //    }
                //}
                return jogo;
            }

            //Vencedor!!

            static bool Vencedor(int[,] jogo)
            {
                //verifica linhas
                for (int i = 0; i < 3; i++)
                {
                    if (jogo[i, 0] == jogo[i, 1] && jogo[i, 1] == jogo[i, 2] && jogo[i, 0] != 0)
                    {
                        return true;
                    }
                }
                //verifica colunas
                for (int j = 0; j < 3; j++)
                {
                    if (jogo[0, j] == jogo[1, j] && jogo[1, j] == jogo[2, j] && jogo[0, j] != 0)
                    {
                        return true;
                    }
                }
                // Verifica diagonal principal
                if (jogo[0, 0] == jogo[1, 1] && jogo[1, 1] == jogo[2, 2] && jogo[0, 0] != 0)
                {
                    return true;
                }

                // Verifica diagonal secundária
                if (jogo[0, 2] == jogo[1, 1] && jogo[1, 1] == jogo[2, 0] && jogo[0, 2] != 0)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
            //---------------------------------------------------------------------------------------------------------------------------------------------
        //Partes que quero implementar porém estou com problemas       



//            // Validando a posição
//            static void Posicao(out int linha, out int coluna, int[,] jogo, int jogador)
//            {
//                do
//                {
//                    Console.WriteLine("Digite a linha: ");
//                    linha = int.Parse(Console.ReadLine());
//                    Console.WriteLine("Digite a coluna: ");
//                    coluna = int.Parse(Console.ReadLine());

//                    if (jogo[linha, coluna] != ' ')
//                    {
//                        Console.WriteLine("Opa! Você já escolheu aqui! Digite outra posição. ");
//                    }
//                } while (jogo[linha, coluna] != ' ');
//                {
//                    jogo[linha, coluna] = jogador;

//                    MostrarTabuleiro(jogo);
//                }
//            }

//            MostrarTabuleiro(jogo);

//            if (Vencedor(jogo, out igual))
//            {
//                if (igual == 222)
//                {
//                    Console.WriteLine("O vencedor é o X!");

//                }
//                else if (igual == 111)
//                {
//                    Console.WriteLine("O vencedor é a O!");

//                }


//            }
//        }
//        //Validar o usuário 
//        static int ValidJogador(int jogador)
//        {
//            if (jogador == 1)
//            {
//                Console.WriteLine("É a vez da O");
//                return 1;
//            }
//            else if (jogador == 2)
//            {
//                Console.WriteLine("É a vez do X");
//                return 2;
//            }
//            else
//            {
//                Console.WriteLine("Insira um valor válido, 1 ou 2");
//                return 3;
//            }
//        }



//    }
//}