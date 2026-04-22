using System.Diagnostics;
using System.IO;
    namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (FileStream fs = File.Create("test1.txt")) ;
            //string[] lines1 = { "Ebtisam", "Hayat" };
            //File.WriteAllLines("test1.txt", lines1);
            //File.AppendAllText("test1.txt", "\n hello all");
            //string myfile=File.ReadAllText("test1.txt");
            //Console.WriteLine(myfile);


            Console.WriteLine("please choose Exam1 or Exam2 or Exam3");
            string user = Console.ReadLine();

            string fileName = "";

            if (user == "1")
            {
                fileName = "Exam1.txt";
            }
            else if (user == "2")
            {
                fileName = "Exam2.txt";
            }
            else
            {
                fileName = "Exam3.txt";
            }

            Process.Start(new ProcessStartInfo
            {
                FileName = fileName,
                UseShellExecute = true
            });



        }
    }
}
