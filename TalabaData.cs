namespace StudentData
{
    public class TalabaData
    {
        public static void studetnDataListTest(List<Tuple<int, string, int, string, string>> studetnDataList)
        {
            Console.WriteLine("Enter Student Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Student Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Gender:");
            string gender = Console.ReadLine();

            Console.WriteLine("Student Location:");
            string location = Console.ReadLine();

            int studetnID = studetnDataList.Select(s => s.Item1).DefaultIfEmpty(0).Max() + 1;
            
            studetnDataList.Add(new Tuple<int, string, int, string, string>(studetnID, name, age, gender, location));
            Console.WriteLine("The student is added to the list!\n");
        }

        public static void ShowStudents(List<Tuple<int, string, int, string, string>> studetnDataList)
        {
            if (studetnDataList.Count == 0)
            {
                Console.WriteLine("There are no students listed.");
            }
            else
            {
                Console.WriteLine("Talabalar ro'yxati:");
                foreach (var student in studetnDataList)
                {
                    Console.WriteLine($"ID: {student.Item1}, Name: {student.Item2}, Age: {student.Item3}, Gender: {student.Item4}, Location: {student.Item5}");
                }
            }
            Console.WriteLine();
        }

        public static void studentTableDeleteTest(List<Tuple<int, string, int, string, string>> studetnDataList)
        {
            Console.WriteLine("Enter student ID: ");
            int studentID = Convert.ToInt32(Console.ReadLine());
            
            studetnDataList.RemoveAll(s => s.Item1 == studentID);
            
            var student = studetnDataList.Where(s => s.Item1 == studentID).FirstOrDefault();

            if (student != null)
            {
                studetnDataList.Remove(student);
                Console.WriteLine($"Student ID: {studentID} has been deleted.");
            }
            else
            {
                Console.WriteLine($"Student ID: {studentID} no such student exists.");
            }
        }
    }
}