using Ex13.Entity;
using Ex13.ExceptionSystem;
using Ex13.ExceptionSytem;
using System.Runtime.ConstrainedExecution;
namespace Ex13.Service
{
    internal class EmployeeManager
    {
        Employee emp;
        List<Employee> employees = new List<Employee>();
        List<Certificate> certificates = new List<Certificate>();
        // Main program menu
        public void ProgramMenu()
        {
            int n;
            do
            {
                Console.WriteLine("Welcome to the employment hiring system of Amazon, please choose a number to continue");
                Console.WriteLine("1. Add the employee");
                Console.WriteLine("2. Modify the employee information");
                Console.WriteLine("3. Delete the employee ");
                Console.WriteLine("4. Search the employee information");
                Console.WriteLine("5. Exit the program");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    // Add employee information
                    case 1:
                        Console.WriteLine("You have chosen to add the employee");
                        AddInformation();
                        break;
                    // Modify employee information 
                    case 2:
                        Console.WriteLine("You have chosen to modify the employee information");
                        ModifyEmployeeInfo();
                        break;
                    // Delete employee information
                    case 3:
                        Console.WriteLine("You have chosen to delete the employee information");
                        DeleteEmployee();
                        break;
                    // Search employee information
                    case 4:
                        Console.WriteLine("You have chosen to look for employee information");
                        SearchEmployee();
                        break;
                    // Exit the program
                    case 5:
                        Console.WriteLine("You have chosen to exit the program, Au revoir");
                        break;
                    default:
                        Console.WriteLine("Invalid number, please try again");
                        return;
                }
            } while (n != 5);
        }

        // 1.Add employee information
        public void AddInformation()
        {
            int n;
            do
            {
                Console.WriteLine("Enter the type information of the employee you want to add: ");
                Console.WriteLine("1. Enter Employee personal information");
                Console.WriteLine("2. Enter Employee Certificates information");
                Console.WriteLine("3. Exit");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Add Personal information");
                        AddPersonalInformation();
                        break;
                    case 2:
                        Console.WriteLine("Add Employee certificate");
                        AddCertificate();
                        break;
                    case 3:
                        Console.WriteLine("Sayonara");
                        break;
                    default:
                        Console.WriteLine("Invalid number, please try again");
                        return;
                }
            } while (n != 3);

        }

        //1.1 Add Personal information - OK
        public void AddPersonalInformation()
        {
            int n;
            Console.WriteLine("Choose the type of employee you want to add");
            Console.WriteLine("0. Experience");
            Console.WriteLine("1. Fresher");
            Console.WriteLine("2. Intern");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 0:
                    Console.WriteLine("Experience employee");
                    emp = new Experience();
                    break;
                case 1:
                    Console.WriteLine("Fresher employee");
                    emp = new Fresher();
                    break;
                case 2:
                    Console.WriteLine("Intern employee");
                    emp = new Intern();
                    break;
                default:
                    Console.WriteLine("Invalid number, please try again");
                    return;
            }
            Console.WriteLine("Enter the Id");
            emp.Id = IdException.IdInput(employees);
            Console.WriteLine("Enter the FullName");
            emp.FullName = FullNameException.NameInput();
            Console.WriteLine("Enter the BirthDay, Example: 12/03/2001 - 12032001");
            string dobInput = Console.ReadLine();
            DateTime dateTime;
            if (DateTimeException.TryParseNonStandardDate(dobInput, out dateTime))
            {
                Console.WriteLine("Successfully parsed: " + dobInput.ToString());
            }
            else
            {
                Console.WriteLine("Invalid date format.");
            }
            emp.BirthDay = dateTime;
            Console.WriteLine("Enter the phone number");
            emp.Phone = PhoneException.PhoneInput();
            Console.WriteLine("Enter the email address");
            emp.Email = EmailException.EmailInput();
            // Additonal Experience Employee
            if (emp is Experience)
            {
                Console.WriteLine("Enter the year experience:");
                ((Experience)emp).ExpInYear = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the professional skill:");
                ((Experience)emp).ProSkill = Console.ReadLine();
            }
            // Additional Fresher Employee
            if (emp is Fresher)
            {
                Console.WriteLine("Enter the graduation date: ");
                string dobInput1 = Console.ReadLine();
                DateTime dateTime1;
                if (DateTimeException.TryParseNonStandardDate(dobInput1, out dateTime1))
                {
                    Console.WriteLine("Successfully parsed: " + dobInput1.ToString());
                }
                else
                {
                    Console.WriteLine("Invalid date format.");
                }
                ((Fresher)emp).Graduation_date = dateTime1;
                Console.WriteLine("Enter the graduation rank: ");
                ((Fresher)emp).Graduation_rank = Console.ReadLine();
                Console.WriteLine("Enter the education");
                ((Fresher)emp).Education = Console.ReadLine();
            }
            // Additional Intern Employee
            if (emp is Intern)
            {
                Console.WriteLine("Enter the Majors");
                ((Intern)emp).Majors = Console.ReadLine();
                Console.WriteLine("Enter the Semester");
                ((Intern)emp).Semester = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the University name");
                ((Intern)emp).University_name = Console.ReadLine();

            }
            // Add to the list
            employees.Add(emp);
            // Increase the number of employees if successful

        }


        //1.2 Add employee certificate
        public void AddCertificate()
        {
            Console.WriteLine("Enter the id of the employee you want to add certificate");
            string eId = Console.ReadLine();

            Employee emp = employees.Find(emp => emp.Id == eId);

            if (emp != null)
            {
                Console.WriteLine("Employee found, please enter the employee certificates information ");
                Console.WriteLine("Enter the number of certificates you want to add");
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Certificate cer = new Certificate();
                    Console.WriteLine("Enter the certificate name");
                    cer.CertificateName = Console.ReadLine();
                    Console.WriteLine("Enter the certificate id");
                    cer.CertificateId = Console.ReadLine();
                    Console.WriteLine("Enter the certificate rank");
                    cer.CertificateRank = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the certificate date");
                    var dobInput = Console.ReadLine();
                    DateTime dateTime;
                    if (DateTimeException.TryParseNonStandardDate(dobInput, out dateTime))
                    {
                        Console.WriteLine("Successfully parsed: " + dobInput.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format.");
                    }
                    cer.CertifcatedDate = dateTime;
                    emp.CertificateList.Add(cer); // Add certificate to the employee's certificate list
                }

                // Add the employee back to the list after adding certificates
                employees.Add(emp);
            }
            else
            {
                Console.WriteLine("No employee found with the provided ID.");
            }
        }


        // 2. Modify employee information
        public void ModifyEmployeeInfo()
        {
            Console.WriteLine("Enter the employee Id");
            var empId = Console.ReadLine();
            foreach (var e in employees)
            {
                if (empId == e.Id)
                {
                    int n;
                    do
                    {
                        Console.WriteLine("Choose the information you want to change");
                        Console.WriteLine("1. Fullname");
                        Console.WriteLine("2. BirthDay");
                        Console.WriteLine("3. Phone");
                        Console.WriteLine("4. Email");
                        Console.WriteLine("5. Job role");
                        Console.WriteLine("6. Update specific job role info");
                        Console.WriteLine("7. Exit");
                        n = Convert.ToInt32(Console.ReadLine());
                        switch (n)
                        {
                            case 1:
                                Console.WriteLine("Change the fullname, enter the new fullname");
                                e.FullName = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Change the BirthDay");
                                Console.WriteLine("Enter the certificate date");
                                var dobInput = Console.ReadLine();
                                DateTime dateTime;
                                if (DateTimeException.TryParseNonStandardDate(dobInput, out dateTime))
                                {
                                    Console.WriteLine("Successfully parsed: " + dobInput.ToString());
                                }
                                else
                                {
                                    Console.WriteLine("Invalid date format.");
                                }
                                e.BirthDay = dateTime;
                                break;
                            case 3:
                                Console.WriteLine("Change the Phone");
                                e.Phone = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 4:
                                Console.WriteLine("Change the Email");
                                e.Email = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Change the job role, select (0 - Experience, 1 - Fresher, 2 - Intern)");
                                Employee.Employee_type = Convert.ToInt32(Console.ReadLine());
                                if (Employee.Employee_type == 0)
                                {
                                    emp = new Experience();
                                }
                                if (Employee.Employee_type == 1)
                                {
                                    emp = new Fresher();
                                }
                                if (Employee.Employee_type == 2)
                                {
                                    emp = new Intern();
                                }
                                break;
                            case 6:
                                // Additional Fresher Employee
                                if (emp is Fresher)
                                {
                                    Console.WriteLine("Enter the graduation date: ");
                                    string dobInput1 = Console.ReadLine();
                                    DateTime dateTime1;
                                    if (DateTimeException.TryParseNonStandardDate(dobInput1, out dateTime1))
                                    {
                                        Console.WriteLine("Successfully parsed: " + dobInput1.ToString());
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid date format.");
                                    }
                                    ((Fresher)emp).Graduation_date = dateTime1;
                                    Console.WriteLine("Enter the graduation rank: ");
                                    ((Fresher)emp).Graduation_rank = Console.ReadLine();
                                    Console.WriteLine("Enter the education");
                                    ((Fresher)emp).Education = Console.ReadLine();
                                }
                                // Additional Intern Employee
                                if (emp is Intern)
                                {
                                    Console.WriteLine("Enter the Majors");
                                    ((Intern)emp).Majors = Console.ReadLine();
                                    Console.WriteLine("Enter the Semester");
                                    ((Intern)emp).Semester = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter the University name");
                                    ((Intern)emp).University_name = Console.ReadLine();

                                }
                                break;
                            case 7:
                                Console.WriteLine("Goodbye");
                                break;
                            default:
                                return;
                        }
                    } while (n != 7);
                }
                else
                {
                    Console.WriteLine("No employee found, please try again");
                }
            }
        }

        // 3. Delete employee - Ok
        public void DeleteEmployee()
        {
            Console.WriteLine("Enter the employee Id");
            var empId = Console.ReadLine();
            foreach (var e in employees)
            {
                if (empId == e.Id)
                {
                    employees.Remove(e);
                    Employee.Employee_count--;
                    Console.WriteLine("Delete successfully");
                    return;
                }
                else
                {
                    Console.WriteLine("No employee found");
                }
            }
        }
        // 4. Search employee - Ok
        public void SearchEmployee()
        {
            int n;
            do
            {
                Console.WriteLine("Which type of employee do you want to search:");
                Console.WriteLine("0. Experience");
                Console.WriteLine("1. Fresher");
                Console.WriteLine("2. Intern");
                Console.WriteLine("3. Exit");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 0:
                        Console.WriteLine("The list of experience:");
                        // If show Directly then Boxing/Unboxing occures
                        //emp = new Experience();
                        //Console.WriteLine(emp.ShowMe()); => Boxing/ Unboxing
                        foreach (var emp in employees)
                        {
                            if (emp is Experience)
                            {
                                Console.WriteLine(emp.ShowMe());
                            }
                        }
                        break;
                    case 1:
                        Console.WriteLine("The list of fresher:");
                        foreach (var emp in employees)
                        {
                            if (emp is Fresher)
                            {
                                Console.WriteLine(emp.ShowMe());
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("The list of intern:");
                        foreach (var emp in employees)
                        {
                            if (emp is Intern)
                            {
                                Console.WriteLine(emp.ShowMe());
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("Invalid value, please try again");
                        return;
                }
            } while (n != 3);
        }
    }
}
