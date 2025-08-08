var employee = new Employee("Alice", "Developer");
var manager = new Manager();
var repository = new EmployeeRepository();

manager.Promote(employee);
repository.Save(employee);