using LAB08_1;
Worker w1 = new Worker("Alisa", new DateTime(1990, 5, 7), new DateTime(2010, 5, 5), 25);
Programmer p1 = new Programmer("Petya", new DateTime(2000, 8, 3), new DateTime(2024, 5, 5), Level.SENIOR);
Manager m1 = new Manager("Anna", new DateTime(1991, 12, 6), new DateTime(2025, 5, 5), 10, true);

Worker w2 = new Worker("Adamenya", new DateTime(2009, 3, 21), new DateTime(2018, 11, 9), 40);
Programmer p2 = new Programmer("Artur", new DateTime(1998, 3, 1), new DateTime(2005, 1, 1), Level.MIDDLE);


Department department = new Department("IT Department");
department.AddEmployee(w1);
department.AddEmployee(w2);
department.AddEmployee(p1);
department.AddEmployee(p2);
department.AddEmployee(m1);

department.PrintEmployees();
Console.WriteLine($"Total employees:{ department.CountEmployees()}");
Console.WriteLine($"Workers: {department.CountWorkers()}");
Console.WriteLine($"Programmers:{ department.CountProgrammers()}");
Console.WriteLine($"Managers: {department.CountManagers()}");

Console.WriteLine($"Total salary:{ department.CalculateTotalSalary()}");
Console.WriteLine($"Average salary:{ department.CalculateAverageSalary()}");
Console.WriteLine($"Highest paid:{ department.FindHighestPaidEmployee()}");
Console.WriteLine($"Lowest paid: { department.FindLowestPaidEmployee()}");

department.RemoveEmployee(p1.ID);
Console.WriteLine("After removal:");

department.PrintEmployees();

Console.WriteLine($"Total employees:{ department.CountEmployees()}");
Console.WriteLine($"Average salary:{ department.CalculateAverageSalary()}");