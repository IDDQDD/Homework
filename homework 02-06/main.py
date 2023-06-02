import phonebook



if __name__ == "__main__":
    pbook = phonebook.phonesbook(phonebook.data.myrecords);
    pbook.add_contact('Danik','+3752939403493094');
    pbook.delete_contact('Nikita');
    pbook.change_phonenumber('Olga', '+3757777777');
    del pbook;