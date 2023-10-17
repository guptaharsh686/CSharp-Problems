Console.WriteLine("Hello, World!");

var arr = new int[] {2,3,1,7,8,5,4,6,9,0};

for(int i=0;i < arr.Length; i++)
{
    for(int j = 0; j < arr.Length - 1 - i; j++)
    {
        if (arr[j] > arr[j+1])
        {
            swap(arr, j, j+1);
        }
    }
}

for(int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"{arr[i]} ");
}

void swap(int[] arr, int i, int j)
{
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}
