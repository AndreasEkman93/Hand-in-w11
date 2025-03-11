using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hand_in_w11
{
    internal class Terminal
    {
        private StudentService studentService;
        public Terminal(StudentService studentService)
        {
            this.studentService = studentService;
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("0. Avsluta programmet.");
                Console.WriteLine("1. Registrera ny student.");
                Console.WriteLine("2. Ändra befintlig student.");
                Console.WriteLine("3. Lista alla studenter.");
                Console.WriteLine("4. Ta bort en student.");
                Console.WriteLine("-----------------------------------------");
                MenuChoiceHandler();
            }
        }
        public void MenuChoiceHandler()
        {
            Console.Write("Välj vad du vill göra:");
            if (int.TryParse(Console.ReadLine(), out var choice))
            {
                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        ChangeStudentValues();
                        break;
                    case 3:
                        ListAllStudents();
                        break;
                    case 4:
                        RemoveStudent();
                        break;
                    default:
                        Console.WriteLine("Du har givit en siffra utanför menyvalet.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Inmatning är inte en siffra.");
                MenuChoiceHandler();
            }
        }
        public void AddStudent()
        {
            Console.WriteLine("Du har valt att registrera en ny student, tryck bara enter om du vill återgå till tidigare meny.");
            Console.Write("Skriv Förnamn:");
            string firstName = Console.ReadLine() ?? "";
            Console.Write("Skriv Efternamn:");
            string lastName = Console.ReadLine() ?? "";
            Console.Write("Skriv stad studenten kommer från:");
            string city = Console.ReadLine() ?? "";
            if (firstName != "" && lastName != "" && city != "")
            {
                studentService.AddStudent(firstName, lastName, city);
                Console.WriteLine($"Studenten {firstName} {lastName} är tillagd.");
            }
            else
            {
                Console.WriteLine("Du har tryckt enter utan att mata in värde, återgår till huvudmeny.");
            }
        }
        public void ChangeStudentValues()
        {
            
        }
        public void ListAllStudents()
        {

        }
        public void RemoveStudent()
        {

        }
    }
}
