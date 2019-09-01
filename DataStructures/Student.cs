using System;

namespace DataStructures
{
    public class Student
    {
        public string Name { get; set; }

        public Student()
        {
        }

        public Student(string name)
        {
            this.Name = name;
        }        
        
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Student student = (Student) obj;
            return student.Name.Equals(Name);
        }
        
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
