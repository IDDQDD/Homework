
import os;
import data
from accessify import private;




class phonesbook:
    __filename = str();
    __records = list(str());
    __phonesbook = dict();
    def __init__(self, records = data.myrecords, filename = data.path):

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

    def add_contact(self, name: str, phonenumber: str):
        self.__phonesbook[name] = phonenumber;

    def delete_contact(self, name: str):
        del self.__phonesbook[name];

    def change_phonenumber(self, name: str, phonenumber: str):
        self.__phonesbook[name] = phonenumber;

    def __del__(self):
       self.save();
