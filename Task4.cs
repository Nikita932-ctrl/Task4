
// первое 
/*int FullArray (int n)
{
    int[] array = new int[n];

    int length = array.Length;
    int i = 0;

    Random random = new Random();
    int rnd = random.Next(0, 10);


    while (array[i] < length)
    {
        array[i] = rnd;
        i++;   
        
    }
    return array[i];
    
}

Console.WriteLine(FullArray(3));


//второе
int FullArray (int N)
{
    int[] mas = new int[N];
    int i = 0;
    Random rnd = new Random();
    int random = rnd.Next(1, 10);

    while(i < mas.Length)
    {
        mas[i] = random;
        i++;
        
    }
    return mas[i];

}

FullArray(3);
*/

/*void parity (int N)
{
    if (N % 2 == 0)
    {
        
        int i = 0;
        while(i < N)
        {
            Console.WriteLine(N);
            N = N - 2;
            i += 2;
            
        }
    }
    else if (N % 2 != 0){
        int i = 0;
        N = N - 1;
        while (i < N) { 

            Console.WriteLine(N);
            N = N - 2;
            i += 2;
            
        }

    }
}
parity(12);
*/

void parity (int N)
{
    if (N % 2 == 0)
    {

        int i = 0;
        while (i != N)
        {
            
            i = i + 2;
            Console.WriteLine(i);

        }
    }
    else if (N % 2 != 0)
    {
        
        N = N - 1;
        int i = 0;
        while (i != N)
        {

            
            i = i + 2;
            Console.WriteLine(i);
        }

    }
}
parity(100);