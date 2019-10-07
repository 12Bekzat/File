using System;
using System.IO;

namespace Homework
{
  class Program
  {
    // Создаю константные названия файл.
    const string numberFibonachchiFileName = "NumberFibonachchi.txt";

    static void Demo_Number_Fibonachchi()
    {
      using (var streamReader = new StreamReader(numberFibonachchiFileName))
      {
        string line;
        while((line = streamReader.ReadLine()) != null)
        {
          Console.WriteLine(line);
          line += ' ' + line; 
          Console.WriteLine(line);
        }
      }
    }


    // Создаю константные названия файл.
    const string inputFileName = "input.txt";
    const string outputFileName = "output.txt";

    static void Demo_Sum_AB()
    {
      using (var streamReader = new StreamReader(inputFileName))
      {
        using (var streamWriter = new StreamWriter(outputFileName))
        {
          string line;
          int number_First, number_Second;
          while ((line = streamReader.ReadLine()) != null)
          {
            string[] tokens = line.Split(' ');

            int.TryParse(tokens[0], out number_First);
            int.TryParse(tokens[1], out number_Second);

            streamWriter.WriteLine(number_First + number_Second);
          }
        }
      }
      Console.WriteLine("Done!\nEnd");
    }

    static void Main(string[] args)
    {
      // первый пример домашней работы
      Demo_Number_Fibonachchi();  
      Console.WriteLine("End\n\n");

      // второй пример домашней работы
      Demo_Sum_AB();
      Console.ReadLine();
    }
  }
}
