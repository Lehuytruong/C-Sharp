using System;


namespace T1807M1.Properties
{
    public class Student
    {
        public int ID;
        public int MARK;
        public int AGE;
        public string CLASS;


        public Student()
        {
            
        }

        public Student(int id, int mark, int age, string @class)
        {
            ID = id;
            MARK = mark;
            AGE = age;
            CLASS = @class;
        }

        public int Id
        {
            get { return ID;}
            set {ID = value;} 
        }

        public int Mark
        {
            get { return MARK;}
            set {MARK = value;} 
        }

        public int Age
        {
            get { return AGE;}
            set {AGE = value;} 
        }

        public string Class
        {
            get { return CLASS;}
            set {CLASS = value;} 
        }

        public void InputInfo()
        {
            Console.Write("\n-Nhap id:  ");
            Id = Console.Read();

            Console.Write("\n-Nhap diem tb: ");
            Mark = Console.Read();
            
            Console.WriteLine("\n-Nhap ten lop: ");
            Class = Console.ReadLine();
            
            Console.Write("\n-Nhap tuoi: ");
            Age = Console.Read();
        }

        public void ShowInfo()
        {
            Console.WriteLine("ID:{0}",this.Id);
            Console.WriteLine("Điểm trung bình:{0}", this.Mark);
            Console.WriteLine("Tên lớp:{0}", this.Class);
            Console.WriteLine("Tuổi:{0}", this.Age);
        }

        public  void check()
        {
            if (Age > 8)
            {
                Console.Write("sinh vien dat hoc bong");
                return;
            }
            Console.Write("sinh vien khong dat hoc bong");

        }
    }
}