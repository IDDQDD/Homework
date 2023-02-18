  // Zadacha1
//int num1 = Convert.ToInt32(Console.ReadLine());
//int num2 = Convert.ToInt32(Console.ReadLine());
//if(num1 > num2){Console.WriteLine(num1);}
//else Console.WriteLine(num2);
  //Vtoroy variant
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());   
//int num3 = num1 > num2 ? (num1) : (num2);
// Console.WriteLine(num3);
  //Zadacha2
//int num1 = Convert.ToInt32(Console.ReadLine());
//int num2 = Convert.ToInt32(Console.ReadLine());
//int num3 = Convert.ToInt32(Console.ReadLine());
//if (num1 > num2 && num1 >num3) {Console.WriteLine(num1);}
//else if (num2 > num1 && num2 > num3) {Console.WriteLine(num2);}
//else {Console.WriteLine(num3);}
  //Zadacha3
//int num = Convert.ToInt32(Console.ReadLine());
//if (num % 2 == 0) {Console.WriteLine("Yes");}
//else {Console.WriteLine("No");}
  //Zadacha4
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= num; i++){
    if ((i == num || i + 1 == num) && i % 2 == 0){
        Console.Write(i);
    }
    else if (i % 2 == 0){
        Console.Write(i + ", ");
    }
}
