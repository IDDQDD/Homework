
import os;
from accessify import private;

myrecords = {"Nikita : +37529333489", "Andrey : +375293434395",
              "Olga : +37529343243", "Nastya : +37529092324"};


class phonesbook:
    __filename = str();
    __records = list(str());
    __phonesbook = dict();
    def __init__(self, records = myrecords, filename = "phones.txt"):

        self.__filename = filename;
        self.__records = records;
        self.readfile();
        self.get_phonesbook();

    @private
    def readfile(self):
        if(self.is_file_exists()):
            file = open(self.__filename, 'w+');
            file.close();
        with open(self.__filename) as file:
                rec = file.readlines();
        for i in rec:
            self.__records.add(i);
    
    @private
    def is_file_exists(self):
        if(os.path.isfile(self.__filename) == 0
        or os.stat(self.__filename).st_size == 0):
            return True;
        return False;


    @private
    def save(self):
        with open(self.__filename, 'w') as file:
            for name, phonenumber in self.__phonesbook.items() :
                file.write(name + ' : ' + phonenumber + '\n');

    @private
    def get_phonesbook(self):
        self.__records = [x.rstrip().split(' : ') for x in self.__records];
        for name, phonenumber in self.__records:
            self.__phonesbook[name] = phonenumber;

    def add_contact(self, name, phonenumber):
        self.__phonesbook[name] = phonenumber;

    def delete_contact(self, name):
        del self.__phonesbook[name];

    def change_phonenumber(self, name, phonenumber):
        self.__phonesbook[name] = phonenumber;

    def __del__(self):
       self.save();

        
pbook = phonesbook(myrecords);
pbook.add_contact('Danik','+3752939403493094');
pbook.delete_contact('Nikita');
pbook.change_phonenumber('Olga', '+3757777777')
del pbook;
