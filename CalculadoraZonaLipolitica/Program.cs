using System;

namespace CalculadoraZonaLipolitica {
    class Program {
        static void Main(string[] args) {
            //declaração de variaveis
            int idade = 0, cod = 0;
            float intensidade = 0, freqMax = 0, freqMin = 0, freqRepouso = 0;
            char sexo;
            //inserção dos dados solicitados
            do {
                Console.WriteLine("Digite a sua idade: ");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a sua frequência cardiaca em repouso: ");
                freqRepouso = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite a intensidade do treino (em %): ");
                intensidade = float.Parse(Console.ReadLine());
                intensidade /= 100;

                Console.WriteLine("Digite seu sexo. Sendo 'M' para Masculino e 'F' para feminino: ");
                sexo = char.Parse(Console.ReadLine());

                //calculo das frequencias cardiacas maxima e minima
                if (sexo == 'f' || sexo == 'F') {
                    if (idade >= 25) {
                        freqMax = ((200 - idade + 12) - freqRepouso) * intensidade + freqRepouso;
                        freqMin = ((200 - idade - 12) - freqRepouso) * intensidade + freqRepouso;
                    }
                    else {
                        freqMax = ((200 - idade + 10) - freqRepouso) * intensidade + freqRepouso;
                        freqMin = ((200 - idade - 10) - freqRepouso) * intensidade + freqRepouso;
                    }
                    Console.WriteLine("A zona alvo de frequência cárdiaca é entre: {0:F2} e {1:F2}", freqMin, freqMax);
                }
                else if (sexo == 'M' || sexo == 'm') {
                    if (idade >= 25) {
                        freqMax = ((220 - idade + 12) - freqRepouso) * intensidade + freqRepouso;
                        freqMin = ((220 - idade - 12) - freqRepouso) * intensidade + freqRepouso;
                    }
                    else {
                        freqMax = ((220 - idade + 10) - freqRepouso) * intensidade + freqRepouso;
                        freqMin = ((220 - idade - 10) - freqRepouso) * intensidade + freqRepouso;
                    }
                    Console.WriteLine("A zona alvo de frequência cárdiaca é entre: {0:F2} e {1:F2}", freqMin, freqMax);
                }
                else {
                    Console.WriteLine("Caractere Inválido");
                }

                Console.WriteLine("Digite qualquer número para continuar ou 1 para sair: ");
                cod = int.Parse(Console.ReadLine());

            } while (cod != 1);



        }
    }
}
