using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOPSConsoleDemo
{
    public class FileHand
    {
        public void WriteFile()
        {
            FileStream fileStreamObj = new FileStream(@"D:\CSprogram\User.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);
            streamWriterObj.Close();
            fileStreamObj.Close();
            Console.WriteLine("File write operation completed");

        }

        public void ReadFile()
        {
            FileStream File = new FileStream(@"D:\CSprogram\User.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader Stream = new StreamReader(File);
            StreamWriter Stream2 = new StreamWriter(File);

            Console.WriteLine("StudId\tName\tMarks\tAge");
            int i,StudId,Marks,Age;
            string name;
            Console.WriteLine("How Many records You Want to Enter");
            int n = Console.Read();
            for(i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Stud ID");
                int value = Console.Read();
                int Id = Convert.ToInt32(value);
                Console.Write("\t");

            }

            Stream.ReadLine();
            
            while (Stream.Peek() > 0)
            {
                Console.ReadLine();
            }
        }
    }
}
