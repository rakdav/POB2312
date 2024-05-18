
//using System.Collections;

//ArrayList list1 = new ArrayList();
//Console.WriteLine(list1.Count);
//Console.WriteLine(list1.Capacity);
//list1.Add("first");
//Console.WriteLine(list1.Count);
//Console.WriteLine(list1.Capacity);
//list1.Add(1);
//list1.Add(2.1);
//list1.Add('3');
//list1.Add("4");
//Console.WriteLine(list1.Count);
//Console.WriteLine(list1.Capacity);
//list1.Insert(2, "second");
//for (int i = 0; i < list1.Count; i++)
//{
//    Console.Write(list1[i]+" ");
//}
//Console.WriteLine();
//list1[3]=5.1;
//foreach (var item in list1)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();
//list1.Remove('3');
//foreach (var item in list1)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();
//list1.RemoveAt(3);
//foreach (var item in list1)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();
//Console.WriteLine(list1.Contains(1));
//Console.WriteLine(list1.BinarySearch(1));
////list1.Sort();
////Console.WriteLine(list1.BinarySearch(4));
//list1.Clear();

//Задача: Управление контактами.
//Консольно.
//Разработайте программу для управления списком контактов. Каждый
//контакт должен содержать имя и номер телефона.
//Реализуйте следующие функции:
//Добавление нового контакта в список.
//Удаление контакта по имени.
//Поиск контакта по имени или номеру телефона.
//Вывод списка всех контактов.

using System;
using System.ComponentModel;
Note note = new Note();
do
{
    Console.Clear();
    Console.WriteLine("Выберите действие:\n" +
        "1 - Добавление нового контакта в список\n" +
        "2 - Удаление контакта по имени\n" +
        "3 - Поиск контакта по имени или номеру телефона\n" +
        "4 - Выход");
    note.Print();
    Console.Write("Введите действие:");
    int n;
    int.TryParse(Console.ReadLine(), out n);
    switch (n)
    {
        case 1: 
            {
                Console.Write("Введите название контакта:");
                string name = Console.ReadLine()!;
                Console.Write("Введите номер телефона:");
                string phone = Console.ReadLine()!;
                Contact contact = new Contact(name, phone);
                note.Add(contact);
            } 
            break;
        case 2: 
            {
                Console.WriteLine("Выберите способ:\n" +
                    "1 - по индексу\n" +
                    "2 - по имени\n" +
                    "3 - по номеру телефона");
                int m;
                int.TryParse(Console.ReadLine(), out m);
                switch (m)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите номер контакта:");
                            int index;
                            int.TryParse(Console.ReadLine(), out index);
                            note.Remove(index);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Введите имя контакта:");
                            string name = Console.ReadLine()!;
                            Contact contact = note.FindByName(name);
                            note.Remove(contact);
                        }
                        break;
                    case 3: 
                        {
                            Console.WriteLine("Введите телефон контакта:");
                            string phone = Console.ReadLine()!;
                            Contact contact = note.FindByPhone(phone);
                            note.Remove(contact);
                        } 
                        break;
                }
               
            }
            break;
        case 3: 
            {
                Console.WriteLine("Выберите способ:\n" +
                   "1 - по имени\n" +
                   "2 - по номеру телефона");
                int m;
                int.TryParse(Console.ReadLine(), out m);
                switch (m)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите имя контакта:");
                            string name = Console.ReadLine()!;
                            Contact contact = note.FindByName(name);
                            Console.WriteLine(contact.getName()+" "+contact.getPhone());
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Введите телефон контакта:");
                            string phone = Console.ReadLine()!;
                            Contact contact = note.FindByPhone(phone);
                            Console.WriteLine(contact.getName() + " " + contact.getPhone());
                            Console.ReadKey();
                        }
                        break;
                }
            }
            break;
    }

    if (n == 4) break;
}
while (true);
class Note
{
    private List<Contact> contacts;
    public Note() 
    {
        contacts = new List<Contact>();
    }
    public void Add(Contact contact)=>contacts.Add(contact);
    public void Remove(Contact contact)=>contacts.Remove(contact);
    public void Remove(int n) => contacts.RemoveAt(n-1);
    public Contact FindByName(string name)
    {
        foreach(Contact i in contacts)
        {
            if (i.getName() == name)
            {
                return i;
            }
        }
        return null!;
    }
    public Contact FindByPhone(string phone) => contacts.FirstOrDefault(p => p.getPhone() == phone)!;
    public void Print()
    {
        int i = 0;
        foreach (Contact item in contacts)
        {
            Console.WriteLine(++i+"."+item.getName()+", "+item.getPhone());
        }
    }
}
class Contact
{
    private string name;
    private string phone;
    public Contact(string name, string phone)
    {
        this.name = name;
        this.phone = phone;
    }
    public string getName() => name;
    public string getPhone() => phone;
}

