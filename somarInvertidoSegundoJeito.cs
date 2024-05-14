int[] vetorA = { 15, 5, 8, 100, 41, -2 }; // Primeira Lista
int[] vetorB = { 5, 15, 18, 10, 4, 132 }; // Segunda Lista
int[] vetorR = new int [6]; // Lista aonde ficara os valores somados
 
for (int i = 0; i < vetorR.Length; i++)
{
    vetorR[i] = vetorA[i] + vetorB[vetorA.Length - 1 - i] ;
    Console.WriteLine(vetorR[i]);
}
