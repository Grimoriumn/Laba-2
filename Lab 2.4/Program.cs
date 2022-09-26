using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_4 {  
    class User
    {
        string login, name, surname;
        int age;
        public readonly DateTime date;
        public string Login
        {
            set { login = value; }
            get
            {
                if (login == null)
                    return "String is not filled";
                return login;
            }
        }
        public string Name
        {
            set { name = value; }
            get
            {
                if (name == null)
                    return "String is not filled";
                return name;
            }
        }
        public string Surname
        {
            set { surname = value; }
            get
            {
                if (surname == null)
                    return "String is not filled";
                return surname;
            }
        }
        public int Age
        {
            set { age = value; }
            get
            {
                if (age <= 0)
                    return 25;
                return age;
            }
        }
        public User()
        {
            date = DateTime.Now;
        }
        public User(string login, string name, string surname, int age)
        {
            this.Login = login;
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            date = DateTime.Now;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            User user = new User();
            user.Login = "Grimorium";
            user.Name = "Grim";
            user.Surname = "Holy";
            user.Age = 19;

            Console.WriteLine("User information: Login - {0}, Name - {1}, Surname - {2}, Age - {3}, time - {4}", user.Login, user.Name, user.Surname, user.Age, DateTime.Now);

            Console.ReadLine();
        }
    }
}
