int[] vetor = new int[10] { 3,1,5,7,3,9,8,2,0,4};
int temp = 0;

for  (int i = 0; i < vetor.Length - 1; i++)
{
    for (int j = 0; j < vetor.Length- 1; j++)
    {
        if (vetor[j] > vetor[j + 1])
        {
            temp = vetor[j];
            vetor[j] = vetor[j + 1];
            vetor[j + 1] = temp;
        }

    }
}
    
foreach (int i in vetor)
{
    Console.WriteLine(i);
}