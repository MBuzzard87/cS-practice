using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace practice
{
    class Members
    {
        // member - private field 
        private string memberName;

        // member - pubilc field
        public int age;
        private int salary;

        // member - propery - exposes memberName - properties start with a capital letter
        public string MemberName {
            get
            {
                return memberName;
            }
            set 
            {
                memberName = value;
            } 
        }

        // public member Method - can be called from other classes
        public void Introduce(bool isFriend)
        {
            if(isFriend)
            {
                SharePrivateInfo();
            } else
            {
                Console.WriteLine("Nahhhh");
            }

        }

        private void SharePrivateInfo()
        {
            Console.WriteLine("Hi, my salary is {0}", salary);
        }

        //member default constructor
        public Members() { }

        //member constructor 
        public Members(string name, int age, int salary)
        {
            memberName = name;
            this.age = age;
            this.salary = salary;
        }


        // member - finalizer = deconstructor
        ~Members()
        {
            //cleanup statements
            Console.WriteLine("Deconstruction of Members object");
            Debug.WriteLine("Destruction of Members object");
        }




    }
}
