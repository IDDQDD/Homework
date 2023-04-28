
#zadacha 1
import math
def exp(a, b):
    if b == 0 : return 1;
    return a *exp(a, b - 1);

print(exp(2, 3));

#zadacha 2

def sum(a, b):
    if a == 0:
        return b;
    return sum(a - 1, b + 1);

print(sum(2, 1));
