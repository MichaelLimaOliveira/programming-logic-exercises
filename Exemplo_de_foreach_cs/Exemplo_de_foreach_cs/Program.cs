using System;

namespace uri1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            // declarando uma variavel com valor zero para dar start no codigo de comparaçao
            int maior = 0;
            // foreach sgnifica para cara  alguma coisa em um vetor ele repetira o loop
            // foi declarado uma variavel com nome 'v' para receber o valor de cada pociçao do vetor declarado de 'vet'
            // foi declarado uma variavel boleana para verificar se este e o primeiro lopp do vetor no foreach para evitar pociveis erros 
            bool primeiraExecucaoDaLista = true;
            foreach (var v in vet)
            {
                //para se comparar numeros e necessario passar o valor do vetor em string para inteiro 
                // foi atribuido uma variavel inteira de nome 'value' para receber a pociçao atual do vetor 'v' em inteiro
                int value = int.Parse(v);
                // na primeira vez que o codigo rodar e ussado esse primeiro if para atribuir o primeiro valor do vetor dentro da variavel 'maior'
                //agora 'maior' vai valer  a primeira pociçao do vetor
                if (primeiraExecucaoDaLista)
                {
                    maior = value;
                    primeiraExecucaoDaLista = false;
                }
                else
                {
                    // apos a primeira vez que o foreach rodar ele ira cair somente no segundo if que ira comparar se o valor dentro de 'maior'
                    // e menor ou igual ao valor da variavel 'value' atual caso 'value' for maior a variavel 'maior' recebe um novo valor  
                    // se nao ele roda mais uma pociçao do vetor ate que no final ele seja comparado com todos os valores dentro da variavel
                    // para determinar qual deles e o maior valor apos o fim das pociçoes do vetor terminar e imprimido o valor dentro da
                    // variavel 'maior' que sera o maior entre os numeros comparados
                    if (maior <= value)
                    {
                        maior = value;
                    }
                }
            }

            Console.WriteLine(maior + " eh o maior");
        }
    }
}