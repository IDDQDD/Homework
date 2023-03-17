List<int> FindNaturalValues(int m, int n){
    List<int> arr = new List<int>();
    for( ;m <= n; ++m){
        if(m > 0){
            arr.Add(m);
           
        }
    }
    return arr;
}

FindNaturalValues(4, 8);


int SumNaturalValues(List<int> arr){
    return arr.Sum();
}

int ComputeAxermanValue(int n, int m){
    if( n == 0){

        return m + 1;
    }else if(m == 0){
        return ComputeAxermanValue(n  - 1, 1);
    }
    return ComputeAxermanValue(n -1, ComputeAxermanValue(n, m -1 ));
}

void Print(List<int> arr, int sum, int ack){
    Console.Write("Natural values: ");
    foreach(var n in arr){
        Console.Write(n + " ");
    }
    Console.WriteLine();
    Console.WriteLine("Sum natural values: " + sum);
    Console.WriteLine("Axerman value: " + ack);
}
var array = FindNaturalValues(-5, 10);
Print(array, SumNaturalValues(array), ComputeAxermanValue(3, 2));