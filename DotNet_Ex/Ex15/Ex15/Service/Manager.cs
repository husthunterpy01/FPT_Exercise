using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Ex15.Entity;
using Ex15.Exception;
namespace Ex15
{
    internal class Manager
    {
        List<Student> studentList = new List<Student>();
        List<Result> resultlist = new List<Result>();
        // Program Menu
        public void ProgramMenu()
        {
            int n;
            do
            {
                Console.WriteLine("Welcome to our system, choose a number to continue: ");
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Student information"); // Also show the total number of students and number of students by years
                Console.WriteLine("3. Student study result");
                Console.WriteLine("4. Exit");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("You have chosen to add students");
                        AddStudent();
                        break;
                    case 2:
                        Console.WriteLine("Please choose the type of information you want to see");
                        ShowInformation();
                        break;
                    case 3:
                        Console.WriteLine("Choose the type of result you want to see");
                        ShowResult();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        return;
                }
            } while (n != 4);
        }

        //1. Add Student
        public void AddStudent()
        {
            List<Result> studentResults = new List<Result>();
            int studentType;
            do
            {
                Console.WriteLine("Choose the type of student you want to add 1-Formal Student 2-Office Student");
                studentType = Convert.ToInt32(Console.ReadLine());
                if (studentType != 1 && studentType != 2)
                {
                    Console.WriteLine("Invalid number, please try again");
                }
            } while (studentType != 1 && studentType != 2);

            Console.WriteLine("Enter the student Id");
            string id = IdException.ValidateId(studentList);
            Console.WriteLine("Enter the student name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the student birthday - Example 03/02/2001 - 03022001");
            string dob = Console.ReadLine();
            DateTime dateTime;
            if (DateException.TryParseNonStandardDate(dob, out dateTime))
            {
                Console.WriteLine("Successfully parsed: " + dob.ToString());
            }
            else
            {
                Console.WriteLine("Invalid date format.");
            }
            var dobVerified = dateTime;
            Console.WriteLine("Enter the year of enrollment");
            int enrolledYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the entry point");
            float entryPoint = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the result of the student by semester");
            Console.WriteLine("Enter the semester name");
            int semesterName = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the semester average score");
            float avgScore = Convert.ToSingle(Console.ReadLine());
            Result result = new Result(semesterName, avgScore);
            studentResults.Add(result);
            // Formal student
            if (studentType == 1)
            {
                Student formalstu = new FormalStudent(id, name, dobVerified, enrolledYear, entryPoint, studentResults, ((StudentType.StudentEduType)studentType).ToString());
                studentList.Add(formalstu);
            }
            // Office student
            if (studentType == 2)
            {
                Console.WriteLine("Enter the office address");
                var officeAddr = Console.ReadLine();
                Student officestu = new OfficeStudent(id, name, dobVerified, enrolledYear, entryPoint, studentResults, ((StudentType.StudentEduType)studentType).ToString(), officeAddr);
                studentList.Add(officestu);
            }
        }

        //2. Show the list of student by demand
        public void ShowInformation()
        {
            int n;
            do
            {
                Console.WriteLine("Choose the type of information you want to see");
                Console.WriteLine("1. The total number of students");
                Console.WriteLine("2. Search for Office Address of Office student");
                Console.WriteLine("3. Search for the list of students by enrolled years");
                Console.WriteLine("4. Search for the number of students by enrolled years");
                Console.WriteLine("5. Exit");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("The total number of students in the university is:");
                        ShowNoStudents();
                        break;
                    case 2:
                        Console.WriteLine("You have chosen to search the Office address");
                        ShowAddress();
                        break;
                    case 3:
                        Console.WriteLine("You have chosen to see the list of students by enrolled years");
                        ShowListEnrolled();
                        break;
                    case 4:
                        Console.WriteLine("You have chosen to see the number of students by enrolled years");
                        ShowListByYears();
                        break;
                    case 5:
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        return;
                }
            } while (n != 5);
        }

        // 2.1 Show the total number of student in the university
        public void ShowNoStudents()
        {
            Console.WriteLine(Student.studentNum);
        }

        // 2.2 Search for the office address of the Office student
        public void ShowAddress()
        {
            Console.WriteLine("Enter the student Id");
            var id = Console.ReadLine();
            foreach (var stu in studentList)
            {
                if (id == stu.Id)
                {
                    if (stu is OfficeStudent officestudent)
                    {
                        Console.WriteLine("The address of the office for this student is: " + officestudent.OfficeLinkDest);
                    }
                    else
                    {
                        Console.WriteLine("No office student with this id");
                    }
                }
                else
                {
                    Console.WriteLine("No student in the list");
                }
            }
        }

        // 2.3 Show the list of Student by enrolled years and type
        public void ShowListEnrolled()
        {
            Console.WriteLine("The list of student based on years and type is: ");
            studentList.Sort(new ListCompare());
            foreach (var stu in studentList)
            {
                Console.WriteLine(stu.ToString());
            }
        }

        //2.4 Show the list of Student by years
        public void ShowListByYears()
        {
            Console.WriteLine("The numbers of students enrolling by year is: ");
            // LINQ => Count the key as the # of students
            var enrollmentCount = studentList.GroupBy(stu => stu.YearIn).Select(group => new { YearIn = group.Key, Count = group.Count() }).ToList();
            foreach (var enrollment in enrollmentCount)
            {
                Console.WriteLine($"Year: {enrollment.YearIn} Count: {enrollment.Count}");
            }
        }

        //3. Show results
        public void ShowResult()
        {
            int n;
            do
            {
                Console.WriteLine("Choose the type of result you want to see");
                Console.WriteLine("1. Average score by semester");
                Console.WriteLine("2. Average score equals or larger than 8.0 in the nearest semester");
                Console.WriteLine("3. Highest enrolled score");
                Console.WriteLine("4. Highest average score");
                Console.WriteLine("5. Exit");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        HasAvgScore();
                        break;
                    case 2:
                        HasAvgScore8();
                        break;
                    case 3:
                        HasHighestEnrollScore();
                        break;
                    case 4:
                        HasHighestAvgScore();
                        break;
                    case 5:
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        return;
                }
            } while (n != 5);
        }


        // 3.1 Search Avg Score by semester
        public void HasAvgScore()
        {
            Console.WriteLine("Enter the student Id:");
            var stuId = Console.ReadLine();
            Console.WriteLine("Enter the semester:");
            var semester = Convert.ToInt32(Console.ReadLine());

            var student = studentList.FirstOrDefault(stu => stu.Id == stuId);

            if (student != null)
            {
                foreach (var result in student.result)
                {
                    if (result.SemesterName == semester)
                    {
                        Console.WriteLine("The average score of student with Id {0} in semester {1} is: {2}", student.Id, semester, result.AvgScore);
                    }
                }
                Console.WriteLine("No result found for student with Id {0} in semester {1}", student.Id, semester);
            }
            else
            {
                Console.WriteLine("No student found with ID {0}", stuId);
            }
        }

        // 3.2 Search avg score >= 8.0 in the nearest semester
        public void HasAvgScore8()
        {
            var nearestSemes = resultlist.Select(s => s.SemesterName).Max();
            var highestscore = studentList.Where(s => s.result.Any(r => r.AvgScore >= 8.0 && r.SemesterName == nearestSemes));
            if (highestscore.Any())
            {
                foreach (var stu in highestscore)
                {
                    Console.WriteLine("Student with Id {0} has the Average score >= 8.0 in semester {1}", stu.Id, nearestSemes);
                    
                }
               
            }
            else
            {
                Console.WriteLine("No students in the list adapts this criteria");
            }
        }

        // 3.3 Search student with highest enroll score
        public void HasHighestEnrollScore()
        {
            var highestscore = studentList.OrderByDescending(stu => stu.InScore).First();
            if (highestscore != null)
            {
                Console.WriteLine("The student with Id {0} has the highest entry score of {1}", highestscore.Id, highestscore.InScore);
                
            }
            else
            {
                Console.WriteLine("No student found");
            }
        }
        // 3.4 Search student with highest average score
        public void HasHighestAvgScore()
        {
            var highestAvg = studentList.Max(s => s.result.Any() ? s.result.Max(r => r.AvgScore) : 0);
            var stuMax = studentList.Where(s => s.result.Any(r => r.AvgScore == highestAvg));
            foreach (var stu in stuMax)
            {
                Console.WriteLine($"Student with Id {stu.Id} has the highest AvgScore of {highestAvg}");
                
            }
            
        }
    }
}

