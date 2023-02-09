
 var numbers=new[] {2,10,-3,3,24,53,12};
 var count = numbers.Length;
 
 for (var i = 0; i <count ; ++i)
 {
     Console.Write(numbers[i]+"   ");
 }
 Console.Write("\n");
 for (var i = 0; i < count; ++i)
 {
     for (var j = i + 1; j < count; j++)
     {
         if (numbers[i] < numbers[j])
         {
             (numbers[i], numbers[j]) = (numbers[j], numbers[i]);
         } 

     }Console.Write("  " + numbers[i]);
 }
 