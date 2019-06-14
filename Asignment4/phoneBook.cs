using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Xml;

namespace Asignment4
{
    class User
    {
        private string name;
        private string phone;

        void viewInfo()
        {
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Phone: "+phone);
        }
    }
    public class PhoneBook : Phone
    {
        ArrayList<User> PhoneList = new ArrayList();
        public void insertPhone(string name, string phone)
        {
            User user = new User();
            Boolean had = false;
            Boolean find = false;
            if (PhoneList > 0)
            {
                for (User us : PhoneList)
                {
                    if (!us.phone.contains(phone))
                    {
                        us.phone = us.phone + ":" + phone;
                        had = true;
                        find = true;
                        break;
                    }
                }
            }

            if (find == false)
            {
                
                user.name=name;
                user.phone = phone;
                PhoneList.Add(user);
                had = true;
            }
            else
            {
                user.name = name;
                user.phone = phone;
                PhoneList.Add(user);
                had = true
            }
                
            if (had)
            {
                Console.WriteLine("Them thanh cong.");
            }
            
            else
            {
                Console.WriteLine("ten nguoi dung da co san");
            }

        }

        public void removePhone(string name)
        {
            boolean had=false;
            for(User us:PhoneList)
            {
                if (us.name.equals(name))
                {
                    PhoneList.remove(us);
                    had=true;
                    
                }
            }
            if (had)
            {
                Console.WriteLine("Xoa thanh cong.");
            }
            else
            {
                Console.WriteLine("Khong tim thay");
            }
        }

        public void updatePhone(string name, string newPhone)
        {
            Boolean had = false;
            for (User us:PhoneList)
            {
                if (us.name.equal(name))
                {
                    us.phone = newPhone;
                    had = true;
                }           
            }

            if (had)
            {
                Console.WriteLine("Sua thanh cong");
            }
            else
            {
                Console.WriteLine("khong tim thay");
            }
        }

        public void searchPhone(string name)
        {
            Boolean had = false;
            for (User us : PhoneList)
            {
                if (us.name.equal(name)
                {
                    Console.WriteLine("So dien thoai nguoi dung :"+us.name+"la: "+us.phone);
                    had = true;
                    break;
                }
            }
            if (!had)
                Console.WriteLine("Khong tim thay");
        }

        public void sortPhone()
        {
            Collection.sort(PhoneList, new NameTable());
            PhoneList.foreach((us)->
            {
                us.viewInfo();
            });
        }

        class ManagerPhoneBook
        {
            static  PhoneBook phoneBook = new PhoneBook();

            private static void searchPhone()
            {
                Console.WriteLine("Moi ban nhap ten nguoi dung: ");
                
                phoneBook.searchPhone(name, phone);
            }

            private static void updatePhone()
            {
                Console.WriteLine("Moi ban nhap ten nguoi dung: ");
                Console.WriteLine("Moi ban nhap so dien thoai: ");
                
                phoneBook.updatePhone(name,phone);
            }

            private static void sort()
            {
                phoneBook.sortPhone();
            }

            private static void removePhone()
            {
                Console.WriteLine("Moi ban nhap ten nguoi muon xoa: ");
                
                phoneBook.removePhone(name);
            }
            
            private static void insertPhone()
            {
                Console.WriteLine("Moi ban nhap ten nguoi dung: ");
                Console.WriteLine("Moi nhap so dien thoai: ");
                phoneBook.insertPhone(name, phone);
            }

            static void menu()
            {
                Console.WriteLine("1.Insert phone");
                Console.WriteLine("2.Remove phone");
                Console.WriteLine("3.Update phone");
                Console.WriteLine("4.Search phone");
                Console.WriteLine("5.Sort");
                Console.WriteLine("6.Exit");
            }

            public static void Main(string[] args)
            {
                int choice;
                menu();
                while (true)
                {
                    Console.WriteLine("Moi ban chon 1 muc: "+choice);
                    switch (choice)
                    {
                        case 1:
                            insertPhone();
                            break;
                        case 2:
                            removePhone();
                            break;
                        case 3:
                            updatePhone();
                            break;
                        case 4:
                            searchPhone();
                            break;
                        case 5:
                            sort();
                            break;
                        case 6: return;
                    }
                }
            }
        }
    }
}
   
