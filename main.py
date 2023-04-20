
#zadacha 1
import random;
import bisect;

def FillArray(n, arr):
        for i in range(n):
            arr.append(random.randint(1, 10))

def CountSameValue(num, arr):
    return arr.count(num);
    
arr = [];
num = 5;

FillArray(10, arr);
print(CountSameValue(num, arr));

#zadacha 2
def FindLowerBoundValue(num, arr):
    arr.sort();
    i = bisect.bisect_left(arr, num)
    return arr[i - 1];

print(FindLowerBoundValue(5, arr));


#zadacha 3

def GetValue(key):
     for k in dictionary:
          if key in k:
            return dictionary.get(k);
dictionary = {
    'AEIOULNSTRАВЕИНОРСТ' : 1, 'DGДКЛМПУ' : 2, 'BCMPБГЁЬЯ' : 3,
    'FHVWYЙЫ' : 4, 'KЖЗХЦЧ' : 5, 'JXШЭЮ' : 8, 'QZФЩЪ' :10
    }

str = "PYTHON";
print(sum(map(GetValue, str)));