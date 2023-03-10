// zadacha 1
List<List<int>> CreateArray(int m, int n){
 List<List<int>> arr = new List<List<int>>(m);
 Random rnd = new Random();
 for(var i = 0; i < m; ++i){
    arr.Add(new List<int>());

    for(var j = 0; j < n; ++j){
        arr[i].Add(rnd.Next(10));
    }
 }
 return arr;
}

CreateArray(3, 4);

// zadacha 2

int FindElement(int m, int n, List<List<int>> arr){
    
   return arr.ElementAt(m).ElementAt(n);
}

var array = CreateArray(3,4);

try
{
    Console.WriteLine(FindElement(2, 2, array));
}
catch (ArgumentOutOfRangeException argumentOutOfRangeException)
        {
            Console.WriteLine($"Error: {argumentOutOfRangeException.Message}");
        }


// zadacha 3



foreach(var column in array){
    Console.Write(column.Average() +  "; ");   
}
Console.WriteLine();