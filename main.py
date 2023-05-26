
#zadacha 1
'''chant1 = 'пара-ра-рам рам-пам-папам па-ра-па-да';

def check_rythm(chant):
    chant = chant.split();
    count_vouwels = lambda x: sum(map(x.count, 'аоиыеуёэюя'));
    if len(set(map(count_vouwels, chant))) == 1:
        print('Парам пам-пам');
    esle: print('Пам парам');

check_rythm(chant1);'''

#zadacha 2
def operation_table(operation, num_columns=6, num_rows=6):
    table = [[operation(i, j) for i in range(1, num_columns + 1)]
                              for j in range(1, num_rows + 1)]
    for i in table:
        print(*i)
operation_table(lambda x, y: x * y)