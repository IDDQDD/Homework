// zadacha 1


/*List<List<int>> CreateArray(int m, int n){
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

void SortArray(List<List<int>> arr){
        foreach(var row in arr){
            row.Sort(new Cmp());
        }
     }

var array = CreateArray(5,5);
SortArray(array);

// Zadacha 2
int TheSmallestSum(List<List<int>> arr){
   List<int> sum = new List<int>();
   foreach(var row in arr){
    sum.Add(row.Sum());
   }
   return sum.IndexOf(sum.Min());
}

Console.WriteLine(TheSmallestSum(array));
public class Cmp : IComparer<int>{

    public int Compare(int a, int b){
      return a < b ? 1 : 0;
    }
}
*/

// Zadacha 3
// for add package to project using:  dotnet add package MathNet.Numerics --version 5.0.0
/*using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

Matrix<double> a =  Matrix<double>.Build.Dense(3, 3,(i,j) => 2*i + j);
Matrix<double> b = Matrix<double>.Build.Dense(3, 3,(i,j) => 3*i + j);

Matrix<double> MatrixMultiplication(Matrix<double> a, Matrix<double> b){

    return a.Multiply(b);
}

try{
    Console.WriteLine(MatrixMultiplication(a, b));
}catch(Exception e){
    Console.WriteLine($"Error: {e.Message}");
}

*/


List<List<List<int>>> Create3DArray(int z, int y, int x){
 List<List<List<int>>> arr = new List<List<List<int>>>(z);
 
 Random rnd = new Random();
 for(var i = 0; i < z; ++i){
    arr.Add(new List<List<int>>(y));
    for(var j = 0; j < y; ++j){
        arr[i].Add(new List<int>());
        for(var k = 0; k < x; ++k){
            var value = rnd.Next(10, 100);
            arr[i][j].Add(rnd.Next(10, 100));
        }
    }
 }
 return arr;
}

void Print(List<List<List<int>>> arr){
    foreach(var z in arr){
        foreach(var row in z){
            foreach(var column in row){
                Console.Write(column + "(" + arr.IndexOf(z)
                                     + "," + z.IndexOf(row)
                                     + ","+ row.IndexOf(column) + ")" + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}


Print(Create3DArray(5, 5, 5));
