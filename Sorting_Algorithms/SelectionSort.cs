using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    
    int[] arr = {4,3,5,6,2,0,8,9};
    
    
    foreach(var x in arr){
        Console.Write(x + " ");
    }
    
    Console.WriteLine("Hello World");
    
    for(int i=0;i<arr.Length - 1;i++){
        int min = i;
        int j = i+1;
        while(j < arr.Length){
            if(arr[j] < arr[min])
                min = j;
            j++;
        }
        
        int temp = arr[min];
        arr[min] = arr[i];
        arr[i] = temp;
    }
    
    foreach(var x in arr){
        Console.Write(x + " ");
    }
  }
}
