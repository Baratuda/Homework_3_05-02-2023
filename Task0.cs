Console.Clear();
    String number="0";
    String result = null;
    String reverseNumber = null;
    int j = 0;
    int x=0;
    while(x==0){
       Console.WriteLine("Please enter the five-digit number to get the result: ");
       number = Console.ReadLine();
       j = number.Length-1;
       result = "The "+number+" isn't a polyndrom.";
       char[] charArray = number.ToCharArray();
       char[] wordArrayInReverse = new char[5];
       if(number.Length == 5){
           for(int i = 0; 0<=j; i++, j--) 
              wordArrayInReverse[i] = charArray[j];
           reverseNumber = String.Join("", wordArrayInReverse);
           if(String.Equals(reverseNumber, number))
               result = "The "+number+" is a polyndrom.";
           Console.WriteLine($"Result: {result}");
           x=1;
       }    
    }

