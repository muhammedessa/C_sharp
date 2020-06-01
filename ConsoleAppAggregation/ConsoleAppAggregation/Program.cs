using System;

namespace ConsoleAppAggregation
{

    class Address
    {
        public string streetName;
        public string city;
        public int streetNo;
        public string email;
        public Address(string streetName,string city ,
            int streetNo, string email)
        {
            this.streetName = streetName;
            this.city = city;
            this.streetNo = streetNo;
            this.email = email;
        }
    }

    class Student
    {
        public string name;
        public int age;
        public string country;
        public Address address;
       public Student(string name, string country,
            int age, Address address)
        {
            this.name = name;
            this.age = age;
            this.country = country;
            this.address = address;
        }

        public void PrintInfo()
        {
            Console.WriteLine("name: " + name + " - "+
                "age: " + age + " - " +
                "country: " + country + " - " +
                "city: " + address.city + " - " +
                 "streetName: " + address.streetName +
                 "street Number: " + address.streetNo);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Address add1 = new Address("Salim", "Sulaymaniyah",
            3123213, "muhammed.essa@gmail.com");

            Student stu = new Student("Muhammed", "Iraq",
            36 , add1);

            stu.PrintInfo();
        }
    }
}
