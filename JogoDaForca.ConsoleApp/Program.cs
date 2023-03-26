using System;
using System.Reflection;

namespace JogoDaForca
{
    class ExercicioJogoDaForca
    {
        static void Main(string[] args)
        {
            //Criando a instância e chamando o método do jogo da forca
            Jogo jogo = new Jogo();
            jogo.chamarJogoDaForca();
        }
    }

    class Jogo
    {
        public void chamarJogoDaForca()
        {
            // Lógica de todo o código do Jogo da Forca
            string[] palavras = { "ABACATE", "ABACAXI", "ACEROLA", "AÇAÍ", "ARAÇÁ", "ABACATE",
                "BACABA", "BACURI", "BANANA", "CAJÁ", "CAJÚ", "CARAMBOLA", "CUPUAÇU", "GRAVIOLA",
                "GOIABA", "JABUTICABA", "JENIPAPO", "MAÇÃ", "MANGABA", "MANGA", "MARACUJÁ", "MURICI",
                "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA"
            };

            Random sortear = new Random();
            string palavraAleatoria = palavras[sortear.Next(0, palavras.Length)];

            int letrasErradas = 0;

            //verificando chute
            while (letrasErradas < 5)
            {
                Console.WriteLine("Digite uma Letra:\n");
                char letra = Console.ReadKey().KeyChar;

                //Converte a letra digitada para maiúscula
                char letraMaiuscula = char.ToUpper(letra);

                if (palavraAleatoria.Contains(letraMaiuscula))
                {
                    Console.WriteLine("A letra " + letraMaiuscula + "  está na palavra.");

                }
                else
                {
                    letrasErradas++;
                    Console.WriteLine("A letra " + letraMaiuscula + "  não está na palavra. TENTATIVA " + letrasErradas + "/5");


                    if (letrasErradas == 1)
                    {
                        Console.WriteLine(" -----------  \n");
                        Console.WriteLine(" |/        |  \n");
                        Console.WriteLine(" |         o  \n");
                        Console.WriteLine(" |            \n");
                        Console.WriteLine(" |            \n");
                        Console.WriteLine(" |            \n");
                        Console.WriteLine(" |            \n");
                        Console.WriteLine(" |            \n");
                        Console.WriteLine("-|-----       \n");
                    }
                    if (letrasErradas == 2)
                    {
                        Console.WriteLine(" -----------  \n");
                        Console.WriteLine(" |/        |  \n");
                        Console.WriteLine(" |         o  \n");
                        Console.WriteLine(" |        /   \n ");
                        Console.WriteLine(" |            \n");
                        Console.WriteLine(" |            \n");
                        Console.WriteLine(" |            \n");
                        Console.WriteLine(" |            \n");
                        Console.WriteLine("-|-----       \n");
                    }
                    if (letrasErradas == 3)
                    {
                        Console.WriteLine(" -----------  \n");
                        Console.WriteLine(" |/        |  \n");
                        Console.WriteLine(" |         o  \n");
                        Console.WriteLine(" |        / \\n ");
                        Console.WriteLine(" |            \n");
                        Console.WriteLine(" |            \n");
                        Console.WriteLine(" |            \n");
                        Console.WriteLine(" |            \n");
                        Console.WriteLine("-|-----       \n");
                    }
                    if (letrasErradas == 4)
                    {
                        Console.WriteLine(" -----------  \n");
                        Console.WriteLine(" |/        |  \n");
                        Console.WriteLine(" |         o  \n");
                        Console.WriteLine(" |        /x\\n ");
                        Console.WriteLine(" |            \n");
                        Console.WriteLine(" |            \n");
                        Console.WriteLine(" |            \n");
                        Console.WriteLine(" |            \n");
                        Console.WriteLine("-|-----       \n");
                    }
                    if (letrasErradas == 5)
                    {
                        Console.WriteLine(" -----------  \n");
                        Console.WriteLine(" |/        |  \n");
                        Console.WriteLine(" |         o  \n");
                        Console.WriteLine(" |        /x\\n ");
                        Console.WriteLine(" |         x  \n");
                        Console.WriteLine(" |            \n");
                        Console.WriteLine(" |            \n");
                        Console.WriteLine(" |            \n");
                        Console.WriteLine("-|-----       \n");
                    } 
                }
            }

            //verificar vitória do jogador
            if (letrasErradas == 5)
            {
                Console.WriteLine("Que pena, você PERDEU! A palavra era  " + palavraAleatoria);
            }
            else
            {
                Console.WriteLine("PARABÉNS, você venceu o jogo! A palavra era  " + palavraAleatoria);
            }
        }
    }

    
}
