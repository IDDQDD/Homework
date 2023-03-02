using System.Collections.Generic;

//   Zadacha 1

/*List<int> CreateArray(int size){

 List<int> arr = new List<int>();
 Random rnd = new Random();

 for(var i = 0; i < size; ++i){
    arr.Add(rnd.Next(100, 1000));
 }
 return arr;
}*/
/*
bool IfNegative(int num){
     
    return num % 2 != 0;
}
Predicate<int> predicate = IfNegative;

int RemoveNegativeValue(List<int> arr){

    arr.RemoveAll(predicate);

    return arr.Count;
   }


Console.Write(RemoveNegativeValue(CreateArray(100)));


//Zadacha2

int Sum(List<int> arr){
    int sum = 0;
    for(var i = 1; i < arr.Count; i += 2){
        sum += arr[i];
    }
    return sum;
}
Console.Write(Sum(CreateArray(11)));
*/

// Zadacha3


List<double> CreateDoubleArray(int size){

 List<double> arr = new List<double>();
 Random rnd = new Random();

 for(var i = 0; i < size; ++i){
    arr.Add(rnd.Next(-100, 100) + Math.Round(rnd.NextDouble(), 2));
 }
 return arr;
}

double FindDIstance(List<double> arr){

    return arr.Max() - arr.Min();
}

Console.WriteLine(FindDIstance(CreateDoubleArray(10)));