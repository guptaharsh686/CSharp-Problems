var arr = new int[] {2,3,1,7,8,8,8,5,4,6,9,0};


mergeSort(arr, 0, arr.Length - 1);

void mergeSort(int[] arr, int start, int end)
{
    if(start < end)
    {
        int mid = (start + end) / 2;
        mergeSort(arr, start, mid);
        mergeSort(arr, mid+1, end);
        merge(arr, start, mid, end);
    }
}

void merge(int[] arr, int start, int mid, int end)
{
    int i = start;
    int j = mid + 1;
    int k = 0;
    var temp = new int[end - start + 1];

    while(i <= mid && j <= end)
    {
        if (arr[i] <= arr[j])
        {
            temp[k++] = arr[i++];
        }
        else if (arr[i] > arr[j])
        {
            temp[k++] = arr[j++];
        }
    }

    while(i <= mid)
    {
        temp[k++] = arr[i++];
    }

    while(j <= end)
    {
        temp[k++] = arr[j++];
    }

    for(int x=0; x<temp.Length; x++)
    {
        arr[x + start] = temp[x];
    }
}

for(int i=0;i<arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}
