using StudentData;

public class Program
{
  public static void Main(string[] args)
  {
    List<Tuple<int, string, int, string, string>> studetnDataList =
        new List<Tuple<int, string, int, string, string>>();

    bool yesorNO = true;

    while (yesorNO)
    {
      Console.WriteLine("1.Registration");
      Console.WriteLine("2.View the list");
      Console.WriteLine("3.Delete the list student");
      Console.WriteLine("4.Exit the program");
      int choose = Convert.ToInt32(Console.ReadLine());

      Console.Clear();

      switch (choose)
      {
      case 1:
        TalabaData.studetnDataListTest(studetnDataList);
        break;
      case 2:
        TalabaData.ShowStudents(studetnDataList);
        break;
      case 3:
        TalabaData.studentTableDeleteTest(studetnDataList);
        break;
      case 4:
        yesorNO = false;
        break;
      default:
        Console.WriteLine("Wrong choice. Please select again.");
        break;
      }
    }
  }
}