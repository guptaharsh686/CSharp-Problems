using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    
    int[] arr = {9,6,5,4,7,8,3,2,1,0};
    
    quickSort(arr,0,arr.Length - 1);
    
    
    for(int i=0;i< arr.Length; i++){
        Console.Write(arr[i] + " ");
    }
    
    Console.WriteLine("\n");

  }
  
  public static void quickSort(int[] arr,int start,int end){
      int pivot;
      int i;
      int j;
      int temp;
      
      if(start < end){
          pivot = start;
          i = start;
          j = end;
          while(i < j)
          {
              
             while(arr[i] <= arr[pivot] && i < end)
             {
                i++;
              }
              
              while(arr[j] > arr[pivot] && j >= start)
              {
                  j--;
              }
              
              if(i < j){
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
              } 
              
          }
          temp = arr[pivot];
          arr[pivot] = arr[j];
          arr[j] = temp; 
          
          quickSort(arr,start,j-1);
          quickSort(arr,j+1,end);
      }
      
  }
}
