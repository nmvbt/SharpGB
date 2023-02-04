int[] array = {1, 22, 13, 210, 34, 25, 63, 67, 28 ,90 ,210};

int n = array.Length;
int find = 210;
int index = 0;
while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}