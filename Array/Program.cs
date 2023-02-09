
 var numbers= new int[20];
 var rnd = new Random();
 
 for (var i = 0; i < 20 ; ++i)
 {
     numbers[i] = rnd.Next(-20, 40);
     Console.Write(numbers[i]+"   ");
 }
 Console.Write("\n");
 for (var i = 0; i < 20; ++i)
 {
     for (var j = i + 1; j < 20; j++)
     {
         if (numbers[i] < numbers[j])
         {
             (numbers[i], numbers[j]) = (numbers[j], numbers[i]);
         } 

     }Console.Write("  " + numbers[i]);
 }
 