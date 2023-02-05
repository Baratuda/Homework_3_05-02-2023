Console.Clear();
Console.Write("Please enter the number: ");
int x=int.Parse(Console.ReadLine());
int y=1;
int m=x;

if(x<0){ y=x; m=-x;  x=-1;}  
    
double[] nums = new double[m];
for(int i=1; y<=x; y++, i++){
   nums[i-1] = Math.Pow(y, 3); 
} 
Console.Write(String.Join(", ", nums));
  



