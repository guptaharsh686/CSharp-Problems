using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    
    int[] arr = {4,3,5,6,2,0,8,9};
    
    
    foreach(var x in arr){
        Console.Write(x + " ");
    }
    
    Console.WriteLine("Hello World");
    
    mergeSort(arr,0,arr.Length - 1);
    
    foreach(var x in arr){
        Console.Write(x + " ");
    }
  }
  
  static void mergeSort(int[] arr,int start,int end){
      if(start != end){
          int mid = (start + end)/2;
          
          mergeSort(arr,start,mid);
          mergeSort(arr,mid+1,end); 
          merge(arr,start,mid,end);
      }
  }
  
  static void merge(int[] arr,int start,int mid,int end){
      int i=start;
      int j=mid+1;
      int k=0;
      int[] temp = new int[end - start + 1];
      
      while((i <= mid) && (j<= end)){
          if(arr[i] < arr[j]){
              temp[k++] = arr[i++];
          }
          else{
              temp[k++] = arr[j++];
          }
      }
      
      while(i <= mid){
          temp[k++] = arr[i++];
      }
      
      while(j <= end){
          temp[k++] = arr[j++];
      }
      
      for(int x=start ;x <= end; x++){
          arr[x] = temp[x - start];
      }
  }
  
  
}
