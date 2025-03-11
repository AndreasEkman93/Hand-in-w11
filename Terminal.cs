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
