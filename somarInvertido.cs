int[] vetorA = { 15, 5, 8, 100, 41, -2 }; // Primeira Lista
int[] vetorB = { 5, 15, 18, 10, 4, 132 }; // Segunda Lista
int[] vetorR = new int [6]; // Lista aonde ficara os valores somados
 
for (int i = 0; i < vetorR.Length; i++) // pegara a quantidade de espaços que tem na lista
{
    vetorR[i] = vetorA[i] + vetorB[5 - i]; // irá adicionar no vetorR o valor que dá a soma do vetorA com o VetorB (o 5 - i está diminuindo os indices deixando invertido)
}
for (int i = 0; i < vetorR.Length; i++)
{
    Console.WriteLine(vetorR [i]); // depois irá contar os valores e adicionar no vetorR
}
