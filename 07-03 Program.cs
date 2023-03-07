/* zadacha 1
string[] ParseString(string? input){

    if( string.IsNullOrEmpty(input)) throw new Exception("String is empty!");
    char[] delimiterChars = {'.', ' ', ','};
    string [] digits = input.Split(delimiterChars);
    return digits;
}
int DigitCounter(string[] input){
    List<int> arr = new List<int>();
    foreach(var num in input){
        if(Int32.Parse(num) >= 0) arr.Add(Int32.Parse(num));
    }
    return arr.Count;
}

while(true){
   Console.WriteLine("Enter numbers(separated by a space or a comma): ");
   var str = Console.ReadLine();
   try{
   Console.WriteLine(DigitCounter(ParseString(str)));
   }catch(Exception err){
     Console.WriteLine(err.Message);
     Console.WriteLine("Enter numbers(separated by a space or a comma): ");
   }
}

*/

Point IntersectionPoint(double b1, double k1, double b2, double k2){

    double x = (b2 - b1)/(k1 - k2);
    double y = (k2*b1-k1*b2)/(k2-k1);
    return new Point(x, y);
}

    double b1 = 2;
    double k1 = 5;
    double b2 = 4;
    double k2 = 9;
    if(k1 == k2){
        Console.WriteLine("lines do not intersect!");
    }else {

        Point p = IntersectionPoint(b1,k1,b2,k2);
        Console.WriteLine("Intersection point: ("+ p.x + ", " +p.y +")");
    }

struct Point{
  public  Point(double x1, double y1){
      y = y1;
      x = x1;
    }
    public double x;
    public double y;
};