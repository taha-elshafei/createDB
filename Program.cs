using createDB;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Employee e1 = new Employee();
System.Console.WriteLine("Enter Employee Name:");
e1.EmpName = System.Console.ReadLine() ;
System.Console.WriteLine("Enter Department:");
e1.Department = System.Console.ReadLine();
System.Console.WriteLine("Enter Active:");
e1.Active = bool.Parse (System.Console.ReadLine() );

MyAppContext db = new MyAppContext();
db.Employees.Add(e1);
db.SaveChanges();

