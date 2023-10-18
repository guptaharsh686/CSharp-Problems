var arr = new int[] {2,3,1,7,8,5,4,6,9,0};


for(int i = 0; i < arr.Length; i++)
{
    int min = i;

    for(int j= i+1; j < arr.Length; j++)
    {
        if (arr[j] < arr[i])
        {
            min = j;
        }
    }
    swap(arr, i, min);
}

for (int i=0;i< arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}


void swap(int[] arr, int i, int j)
{
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}
