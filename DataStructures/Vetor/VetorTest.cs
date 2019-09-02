using System;

namespace DataStructures
{
    public static class VetorTest
    {
        public static void PrintActions() 
        {
            var student1 = new Student("Joao");
            var student2 = new Student("Jose");

            var vetor = new Vetor();

            // Get/Add size of student
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Total de Alunos: {vetor.GetSizeStudent()}" );
            vetor.Add(student1);
            Console.WriteLine("-------------------------\r\n");

            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Total de Alunos: {vetor.GetSizeStudent()}");
            vetor.Add(student2);
            Console.WriteLine("-------------------------\r\n");

            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Total de Alunos: {vetor.GetSizeStudent()}");
            Console.WriteLine("-------------------------\r\n");
            Console.WriteLine("-------------------------\r\n");

            // Print array os student
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Array de Alunos:");
            Console.WriteLine("-------------------------\r\n");
            Console.WriteLine($"{vetor.ToString()}");
            Console.WriteLine("-------------------------\r\n");

            // Contains Student
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Aluno Existe? {vetor.Contains(student1)}");
            Console.WriteLine("-------------------------\r\n");
            
            Console.WriteLine("\r\n-------------------------");
            var student3 = new Student("Ricardo");
            Console.WriteLine($"Aluno Existe? {vetor.Contains(student3)}");
            Console.WriteLine("-------------------------\r\n");

            // Get
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Obter Aluno: {vetor.Get(1)}");
            //Console.WriteLine($"Obter Aluno: {vetor.Obter(250)}"); --teste com posição inválida
            Console.WriteLine("-------------------------\r\n");

            // Add in position X
            Console.WriteLine("\r\n-------------------------");
            var student4 = new Student("Zéquinha");
            var position = 1;
            vetor.Add(position, student4);
            Console.WriteLine($"Aluno Adicionado na Posição {position} do Array");
            Console.WriteLine("-------------------------\r\n");

            // Print new array of students
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Novo Array de Alunos - Adicionado:");
            Console.WriteLine("-------------------------\r\n");
            Console.WriteLine($"{vetor.ToString()}");
            Console.WriteLine("-------------------------\r\n");

            // Remove student
            Console.WriteLine("\r\n-------------------------");
            var positionRemove = 1;
            vetor.Remove(positionRemove);
            Console.WriteLine($"Aluno removido na Posição {positionRemove} do Array");
            Console.WriteLine("-------------------------\r\n");

            // Print new array of students
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Novo Array de Alunos - Removido:");
            Console.WriteLine("-------------------------\r\n");
            Console.WriteLine($"{vetor.ToString()}");
            Console.WriteLine("-------------------------\r\n");

            // Adiona o total maximo do array            
            for (int index = 0; index <= 100; index++)
            {
                var student = new Student($" Rafa {index}");
                vetor.Add(student);
            }
            
            // Imprime novo array de alunos
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Novo Array de Alunos - Dobro Array:");
            Console.WriteLine("-------------------------\r\n");
            Console.WriteLine($"{vetor.ToString()}");
            Console.WriteLine("-------------------------\r\n");
        }
    }
}
