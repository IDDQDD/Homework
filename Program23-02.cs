 //Zadacha 1
/*void IsPalindrom(string? str)
{
    if (str[0] == str[4] && str[1] == str[3]){
      Console.WriteLine("Yes");
    }else
    Console.WriteLine("No");
}
string? result = Console.ReadLine();
IsPalindrom(result);*/

    //Zadacha 2
    double Distance(Point p1, Point p2){
       return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) +
                        Math.Pow(p2.y - p1.y, 2) +
                        Math.Pow(p2.z - p1.z, 2)); 
    }
     var p1 = new Point(3, 6, 8);
     var p2 = new Point(2, 1, -7);
     Console.WriteLine("{0:0.00}",Distance(p1, p2));

     struct Point{
        public Point(int x1, int y1, int z1){
            x = x1;
            y = y1;
            z = z1;
        }
         public int x;
         public int y;
         public int z;
     }
    
   
    
    
 /*   //Zadacha 3
int i = 1;
double sum = 0;
    void POW(double number){
     while(i < number)
     {        
        Console.Write(Math.Pow(i, 3) + ", ");
        ++i;
     }
        Console.Write(Math.Pow(number, 3));
    }
double N = Convert.ToDouble(Console.ReadLine());
POW(N);*/
