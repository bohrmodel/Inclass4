using System;
using System.Dynamic;

namespace Inclass4
{

    public class Person
    {
        public string name;


    }
    public class Vehicle
    {
        public float registration_number;
        public string color;
        public Person person =  new Person();

        public void Change_of_Owner(string input_name)
        {
            this.person.name = input_name;
        }


        public Vehicle() //Default Constructor
        {
            registration_number = 0;
            color = "Default";
        }

        public void GetVehicleMethod(float input_reg_num, string input_color) // Overloaded Constructor
        {
            registration_number = input_reg_num;
            color = input_color;
        }

        //Getter

        public float get_reg_num()
        {
            return registration_number;
        }

        public string get_color()
        {
            return color;
        }
    }


    public class Car : Vehicle
    {
        public string Make;
        public string Type;
        public string Model;
        public int Year;
        public int Number_of_doors;

        public Car()
        {
            Make = "Default";
            Type = "Default";
            Model = "Default";
            Year = 0;
            Number_of_doors = 0;

        }

        public void CarDetailMethod(string input_Make, string input_Type, string input_Model, int input_Year, int input_num_of_doors)
        {
            Make = input_Make;
            Type = input_Type;
            Model = input_Model;
            Year = input_Year;
            Number_of_doors = input_num_of_doors;
        }

        public string get_Make()
        {
            return Make;
        }

        public string get_Type()
        {
            return Type;
        }

        public int get_Year()
        {
            return Year;
        }

        public int get_Number_of_doors()
        {
            return Number_of_doors;
        }
    }


    public class Bike : Vehicle
    {
        public string Make;
        public string Type;
        public int Number_of_gears;

        public Bike()
        {
            Make = "Default";
            Type = "Default";
            Number_of_gears = 0;
        }


        public void BikeDetailMethod(string input_Make, string input_Type, int input_num_of_gears)
        {
            Make = input_Make;
            Type = input_Type;
            Number_of_gears = input_num_of_gears;
        }

        public string get_Make()
        {
            return Make;
        }

        public string get_Type()
        {
            return Type;
        }
        public int get_Number_of_gears()
        {
            return Number_of_gears;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In class work 3!");

            Car myCar = new Car();

            myCar.GetVehicleMethod(0, "Black");
            myCar.CarDetailMethod("Kia","Sedan","Optima",2015,4);

            Console.WriteLine("My car's registration number is " + myCar.registration_number + ". ");
            Console.WriteLine("My car's color is " + myCar.color + ". ");
            Console.WriteLine("My car's Make is " + myCar.Make + ". ");
            Console.WriteLine("My car's type is " + myCar.Type + ". ");
            Console.WriteLine("My car's model is " + myCar.Model + ". ");
            Console.WriteLine("My car's year is " + myCar.Year + ". ");
            Console.WriteLine("My car's number of doors is " + myCar.Number_of_doors + ". ");

            myCar.Change_of_Owner("Han");

            Console.WriteLine("My car's owner person is " + myCar.person.name + ". ");

            myCar.Change_of_Owner("Jake");

            Console.WriteLine("My car's owner person is " + myCar.person.name + ". ");

        }
    }
}
