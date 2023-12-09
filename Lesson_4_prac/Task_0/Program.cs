int N = 100, koef = 4;
int[] simpleNum = new int[N/koef];
for (int i = 0, arrayIndex = 0; i<N; i++)
{
    int count = 0;
    for (int k = 2; k <= i; k++)
    {
        if (i%k == 0)
        {
            count++;
        }
    }
    if (count == 1)
    {
        simpleNum[arrayIndex] = i;
        arrayIndex++;
    }
}
Console.Write("{ ");
for  (int i = 0;i<N/koef-1;i++)
{
    Console.Write(simpleNum[i]+", ");
}
Console.Write(simpleNum[N/koef-1]+" }");

//{ 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 }