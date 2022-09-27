namespace _015_运算符重载
{
    class Student
    {
        private int id;
        private string name;
        private int age;

        public Student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public static bool operator ==(Student s1, Student s2)
        {
            if (s1.id == s2.id && s1.name == s2.name && s1.age == s2.age)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Student s1, Student s2)
        {
            //if (s1.id != s2.id || s1.name != s2.name || s1.age != s2.age)
            //{
            //    return false;
            //}
            //return true;
            bool result = s1 == s2;
            return !result;
        }
    }
}
