using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Engin";
            int age = 36;

            Course course1 = new Course(); //kurs tipinde c1 değişkeni tanımlandı

            //3 özelliğe değer ataması yapıldı.
            course1.CourseName = "C#";
            course1.Teacher = "Şamil Akpınar";
            course1.ViewRate = 68;

            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.Teacher = "Engin Demiroğ";
            course2.ViewRate = 75;

            //Console.WriteLine(course1.CourseName + " " + course1.Teacher);

            //içinde Course tutulabilir
            //içinde Course objesi tutuyoruz.
            //Course array olduğu için içinde course tipinde veriler olmalı
           
            Course[] courses = new Course[] { course1, course2 };

            foreach (Course course in courses)
            {
                Console.WriteLine(course.CourseName + " : " + course.Teacher);
            }
        }
    }

    //Kurs objesi oluşturuldu
    class Course
    {
        //PascalCase style
        //tanımlanan 3 özelliği beraber tutar
        public string CourseName { get; set; }
        public string Teacher { get; set; }
        public int ViewRate { get; set; }
    }

}
