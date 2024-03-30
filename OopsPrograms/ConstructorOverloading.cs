using System;

namespace OopsPrograms
{
    class Student
    {
        string name;
        int id;
        int age;
        public Student(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public Student(int id, int age)
        {
            this.id = id;
            this.age = age;
        }
        public Student(string name, int id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }
    }
}
