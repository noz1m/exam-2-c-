// task 1
// Car car1 = new Car("Toyota", "Corolla", 2020);
// car1.DisplayDetails();

// Car car2 = new Car("Honda", "Civic", 2018);
// car2.DisplayDetails();
// class Car
// {
//     private string make;
//     private string model;
//     private int year;
//     public Car()
//     {

//     }
//     public Car(string make , string model, int year)
//     {
//         this.make = make;
//         this.model = model;
//         this.year = year;
//     }
//     public void DisplayDetails()
//     {
//         System.Console.WriteLine($"{make} {model} {year}");
//     }
// }

// task 2
// Calculator calc = new Calculator();
// Console.WriteLine(calc.Add(10, 5));       
// Console.WriteLine(calc.Subtract(10, 5)); 
// Console.WriteLine(calc.Multiply(10, 5)); 
// Console.WriteLine(calc.Divide(10, 5));  
// class Calculator
// {
//     public int Add(int a, int b)
//     {
//         return a + b;
//     }
//     public int Subtract(int a, int b)
//     {
//         return a - b;
//     }
//     public int Multiply(int a, int b)
//     {
//         return a * b;
//     }
//     public int Divide(int a, int b)
//     {
//         return a / b;
//     }
// }

// task 3


// Student student1 = new Student(101);
// student1.Name = "Ali";
// student1.Grade = 85;
// Console.WriteLine(student1.GetStudentInfo());
// Console.WriteLine($"Passed: {student1.IsPassed()}");
// class Student
// {
//     private string name;
//     public string Name
//     {
//         get { return name; }
//         set {  if (value.Length >= 3)  
//                 name = value; 
//                 else { name = "Unknown"; } 
//             }
//     }
//     private int grade;
//     public int Grade
//     {
//         get { return grade; }
//         set { if(value <= 100 && value >= 0)  
//                 grade = value;   
//                 else { grade = 0; }
//             }
      
//     }
//     public int Id { get; set; }
//     public string GetStudentInfo()
//     {
//         return $"{Name} {Id}";
//     }
//     public bool IsPassed()
//     {
//         if (grade >= 60) return true;
//         else return false;
//     }

//     public Student(int id)
//     {
//         this.Id = id;
//     }
// }

// task 4

// Employee emp1 = new Employee("Ali", 101, 50000);
// Console.WriteLine(emp1);
//     record Employee( string Name, int Id, int Salary)
//     {

//     }

// task 5
// Person per1 = new Person(5); 
// Person per2 = new Person(5);

// System.Console.WriteLine(per1 == per2);
// per2 = new Person(10); 
// System.Console.WriteLine(per1 == per2);
// public record Person(int a)
// {

// }