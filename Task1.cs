Console.Clear();
Console.WriteLine("Please enter the x: ");
int[] firstDot = new int[3]; 
int[] secondDot = new int[3];
for(int i = 0; i<3; i++){
   int number = int.Parse(Console.ReadLine());
   firstDot[i] = number;
}
Console.WriteLine("Please enter the y: ");
for(int i = 0; i<3; i++){
    int number = int.Parse(Console.ReadLine());
    secondDot[i] = number;
}
double result = Math.Sqrt(Math.Pow((secondDot[0]-firstDot[0]), 2) 
                        + Math.Pow((secondDot[1]-firstDot[1]), 2) 
                        + Math.Pow((secondDot[2]-firstDot[2]), 2));
Console.Write($"Result: {result:f2}");
