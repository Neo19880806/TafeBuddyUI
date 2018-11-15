using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeBuddyUI.Model
{
    public class Student
    {
        public String Name { set; get; }
        public String ID { set; get; }
        public String Phone { set; get; }
        public String Email { set; get; }

        public Student(String name, String id, string phone, String email)
        {
            Name = name;
            ID = id;
            Phone = phone;
            Email = email;
        }
        public Student()
        {
        }

        public override String ToString()

        {
            return String.Format("Name=: {0}, ID: {1}, Phone: {2}, Email: {3}", Name, ID, Phone, Email);
        }
    }
}
