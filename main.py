import random;
# zada4a 1;

num = random.randint(100, 999);


def SumDigits(n):
    a = n // 100;
    b = (n // 10) % 10;
    c = n % 10;
    return a + b + c;

print(num, ": ", SumDigits(num));


#zada4a 2

s = 60;

print('%.0f, %.0f, %.0f' % (s/6, s/6*4, s/6));


#zada4a 3
num = 385916;

def LuckyTicket(num):
    a  = num // 1000;
    b = num % 1000;
    half = a // 100 + (a // 10) % 10 + a % 10;
    secondhalf = b // 100 + (b // 10)% 10 + b % 10;
    return half == secondhalf;
print(LuckyTicket(num)); 

#zada4a 4

def BreakChocolate(n, m, k):
    return k < n * m and ((k % n == 0) or (k % m == 0))

print(BreakChocolate(3, 2, 4));
