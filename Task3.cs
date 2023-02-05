Console.Clear(); 
Console.Write("Please enter the size array: ");
int arraySize = int.Parse(Console.ReadLine());
int[] numbersArray = new int[arraySize]; 
int[] shiftedArray = new int[arraySize];
    
Console.WriteLine("Please enter the number for array: ");
for(int i=0; i<arraySize; i++){
    int numberForArray = int.Parse(Console.ReadLine());
    numbersArray[i] = numberForArray;
}
    
Console.Write("Enter the number by which you want to shift the array: ");
int numberToOffsetTheArray = int.Parse(Console.ReadLine());
int y=0;
int z=-arraySize+1;
int v=1;
int i2=-1;
    
if(numberToOffsetTheArray<0){
   numberToOffsetTheArray= -numberToOffsetTheArray;
   y=-z;
   z=0;
   i2=v;
   v=-i2;
}
for(int j = 0; j<numberToOffsetTheArray; j++){
   for(int i = y; z<=i; i--){
      if(i==z){
         shiftedArray[y] = numbersArray[i*i2];
         shiftedArray.CopyTo(numbersArray, 0);
      } else {
         shiftedArray[i*i2+v] = numbersArray[i*i2];
      }
   }
}
Console.Write(String.Join(", ", shiftedArray));
