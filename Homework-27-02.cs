/*double POW(Tuple<double, double> p){

    return Math.Pow(p.Item1, p.Item2);
}

Tuple<double, double> ParseString(string? str){

    if( string.IsNullOrEmpty(str)) throw new Exception("String is empty, try again!");
    char[] delimiterChars = {'.', ' ', ','};
    string [] digits = str.Split(delimiterChars);
    if(digits.Length >= 3) throw new Exception("You need to enter 2 numbers, try again");


    return Tuple.Create<double, double>(Convert.ToDouble(digits[0]), 
                                        Convert.ToDouble(digits[1]));
}

while(true){
   Console.WriteLine("Enter two numbers(separated by a space or a comma): ");
   var str = Console.ReadLine();
   try{

   Console.WriteLine(POW(ParseString(str)));

   }catch(Exception err){
     Console.WriteLine(err.Message);
   }
}

*/

/*int SumDigits(string str){
   
   int sum = 0;
   foreach(var dig in str){
    sum += dig - '0';
   }
   return sum;
}

 Console.WriteLine(SumDigits("567")); */


 void PrintArray(int []arr){

   foreach(var i in arr){
    Console.Write("{0} ", i);
   }
 }


 int[] FillArray(int size){
  
  int[] arr = new int[size];
  Random rnd = new Random();
  for(uint i = 0; i < size; ++i){
    arr[i] = rnd.Next(size);
 }
    return arr;
 }

 PrintArray(FillArray(8));