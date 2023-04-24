using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Xml;

namespace JogoDaVelha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogo();
            static void Jogo()
            {

            string[,] jogo = new string[3, 3]
            {
                {"1","2","3"}, {"4","5","6"}, {"7","8","9"}
            };
            Inicio();
            Tabuleiro(jogo);
            int pvp = PvpOuPc();
            if (pvp == 1)
            {
                Pvp(jogo);
            }
            else
            {
                Pc(jogo);
            }

//************************************************************************************************************************************
            static void Inicio()
            {
                Console.WriteLine("Jogo da Velha # !");
            }
            //Reiniciar o jogo, com validação 
            Console.WriteLine("Oba! Tu quer jogar de novo?");
            Console.WriteLine("Y -> Sim ");
            Console.WriteLine("N -> Não ");
                string reiniciar;
                do
                {
                    reiniciar = Console.ReadLine();
                    if (reiniciar.Length != 1 || !Char.IsLetter(reiniciar[0]))
                    {
                        Console.WriteLine("Valor inválido amigo, digite Y para sim ou N para não");
                    }
                } while (reiniciar.Length != 1 || !Char.IsLetter(reiniciar[0]));
            if (reiniciar.ToUpper() == "Y")
            {
                    Jogo();
            } else if (reiniciar == "N")
                {
                    Console.WriteLine("Fim do Jogo");
                }
                
            // Escolha do usuário, em qual tipo de jogo ele irá jogar
            static int PvpOuPc()
            {
                while (true)
                {
                    Console.WriteLine("Escolha se você quer jogar Player vs Player ou contra o Computador: ");
                    Console.WriteLine("1 -> Player vs Player e 2 -> PC : ");
                    int pvpoupcescolha = int.Parse(Console.ReadLine());
                    if (pvpoupcescolha == 1 || pvpoupcescolha == 2)
                    {
                        return pvpoupcescolha;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("O valor estava incorreto, digite 1 ou 2");
                    }
                }
            }
            //Jogada contra o Pc porém é a vez do usuário
        static void JogadaPlayer(string[,] jogo)
        {
            int posicaoJogador;
            bool posicaoValida;
            do
            {
                Console.WriteLine("A rodada é sua!");
                Tabuleiro(jogo);
                Console.WriteLine("Digite a posição: ");
                posicaoJogador = int.Parse(Console.ReadLine());
                posicaoValida = ValidarPosicao(jogo,posicaoJogador);
            } while (!posicaoValida);

            //é uma fórmula para transformar números inteiros em posições de matriz
            //Porém a matriz precisa ser uma "perfeita"

            int linha = (posicaoJogador - 1) / 3;
            int coluna = (posicaoJogador - 1) % 3;

            jogo[linha, coluna] = "X";
            Console.Clear();
        }


            //Validar a posição
            static bool ValidarPosicao(string[,] jogo, int posicaoJogador)
            {
                int linha = (posicaoJogador - 1) / 3;
                int coluna = (posicaoJogador - 1) % 3;

                if (posicaoJogador > 0 && posicaoJogador <= 9)
                {
                    if (jogo[linha, coluna] == "X" || jogo[linha, coluna] == "O")
                    {
                        Console.WriteLine("Hey! Aqui já foi escolhido.");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    Console.WriteLine("Insira um valor válido, de 1 a 9");
                    return false;
                }
            }

            //Player vs Player
            static void Pvp(string[,] jogo, int cont = 0, string jogador = "X", bool vitoria = false)
            {
                int posicaoJogador;
                while (cont < 9 && !vitoria)
                {
                    do
                    {
                        Console.WriteLine($"Agora é a vez do {jogador}!");

                        Tabuleiro(jogo);

                        Console.Write("Digite um dos números da tabela: ");
                        posicaoJogador = int.Parse(Console.ReadLine());

                        Console.Clear();

                    } while (!ValidarPosicao(jogo, posicaoJogador));

                    int linha = (posicaoJogador - 1) / 3;
                    int coluna = (posicaoJogador - 1) % 3;
                    jogo[linha, coluna] = jogador;
                    vitoria = JogoAcabou(jogo);

                    if (vitoria)
                    {
                        if (jogador == "X")
                        {
                            Console.WriteLine("O jogador X ganhou!");
                        }
                        else if (jogador == "O")
                        {
                            Console.WriteLine("O jogador O ganhou!");
                        }
                    }
                  

                    jogador = MudaJogador(jogador);
                        cont++;

                    }
                  if (cont == 9 && !vitoria)
                    {
                        Tabuleiro(jogo);
                        Console.WriteLine("Xiii deu velha");
                    }
                }

            // PC vs Player
            static void Pc(string[,] jogo, int cont = 0, string jogador = "O", bool vitoria = false)
            {
                while (cont < 9 && !vitoria)
                {
                    if (jogador == "X")
                    {
                        JogadaPlayer(jogo);
                    }
                    else
                    {
                        Computador(jogo);
                    }

                    vitoria = JogoAcabou(jogo);

                    if (vitoria)
                    {
                        if (jogador == "X")
                        {
                            Console.WriteLine("O jogador X ganhou!");

                        }
                        else if (jogador == "O")
                        {
                            Console.WriteLine("A máquina ganhou de você, o mundo das máquinas está cada vez mais próximo");
                        }
                    }
                  
                        jogador = MudaJogador(jogador);
                        cont++;
                }
                  if (cont == 9 && !vitoria)
                    {
                        Console.WriteLine("Xiii deu velha");
                    }
                }
        }
         //Alterna os jogadores a cada jogada
           static string MudaJogador(string jogador)
            {
                if (jogador == "X")
                {
                return "O";
                }
                else
                {
                    return "X";
                }
            }
        // Jogada vez do Computador
        static void Computador(string[,] jogo)
        {
            Console.WriteLine("Modo assistido");
            Random gerador = new Random();

            while (true)
            {
                int posicaoCOmputador = gerador.Next(1, 10);
                int linha = (posicaoCOmputador - 1) / 3;
                int coluna = (posicaoCOmputador - 1) % 3;

                if (jogo[linha, coluna] == "X" || jogo[linha, coluna] == "O")
                {
                    continue;
                }
                else
                {
                    jogo[linha, coluna] = "O";
                    break;
                }
            }
            Tabuleiro(jogo);
            Console.Clear();
        }

        
        // O fim do jogo acontece quando todas as casa forem preenchidas, ou se temos um vencedor
        static bool JogoAcabou(string[,] jogo)
        {
            if (jogo[0, 0] == jogo[0, 1] && jogo[0, 1] == jogo[0, 2] ||
                jogo[1, 0] == jogo[1, 1] && jogo[1, 1] == jogo[1, 2] ||
                jogo[2, 0] == jogo[2, 1] && jogo[2, 1] == jogo[2, 2])
            {
                return true;
            }
            // Vitória nas colunas
            if (jogo[0, 0] == jogo[1, 0] && jogo[1, 0] == jogo[2, 0] ||
                jogo[0, 1] == jogo[1, 1] && jogo[1, 1] == jogo[2, 1] ||
                jogo[0, 2] == jogo[1, 2] && jogo[1, 2] == jogo[2, 2])
            {
                return true;
            }
            // Vitória nas diagonais
            if (jogo[0, 0] == jogo[1, 1] && jogo[1, 1] == jogo[2, 2] ||
                jogo[0, 2] == jogo[1, 1] && jogo[1, 1] == jogo[2, 0])
            {
                return true;
            }

            return false;
        }

        // Tabuleiro do Jogo
        static void Tabuleiro(string[,] jogo)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{jogo[i, 0]} | {jogo[i, 1]} | {jogo[i, 2]}");
                if ((i + 1) < 3)
                {
                    Console.WriteLine("----------");
                }
            }
        }
    }
}
            }
