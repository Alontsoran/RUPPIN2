using HW2;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace HW3
{
    internal class QueueFiles
    {

        DataFile[] Files;
        int freeindex = 0;
        public QueueFiles()
        {
            Files = new DataFile[0];
            this.freeindex = -1;
        }
        public bool isEmpty()
        {
            if (freeindex == -1)
            {
                return true;
            }
            return false;
        }
        public DataFile[] GetFiles()
        {
            DataFile[] temp = new DataFile[Files.Length];
            for (int i = 0; i < Files.Length; i++)
            {
                temp[i] = Files[i];//מעתיק את כל איברי המערך 
            }
            return temp;//עכשיו אני יכול לגשת למערך אבל להעתק שלו 
        }
        public void printFiles()
        {
            if (freeindex == -1)
            {
                Console.WriteLine("no Data");
            }
            else
            {
                for (int i = 0; i < Files.Length; i++)
                {
                    Files[i].Dir();
                    

                }
            }
        }
        public void Enqueue(DataFile file)
        {
            bool exists = false;
            for (int i = 0; i < Files.Length; i++)
            {
                if (compareFiles.EqualFiles(this.Files[i], file))
                {
                    exists = true;
                    Console.WriteLine("The file is already in Data");
                    break;
                }
            }
            if (!exists)
            {
                DataFile[] temp = new DataFile[Files.Length + 1];
                for (int i = 0; i < Files.Length; i++)
                {
                    temp[i] = Files[i];
                }
                temp[++freeindex] = file;
                Files = temp;
            }
        }

        public DataFile Dequeue()
        {
            DataFile[] temp =new DataFile[Files.Length-1];
            DataFile removed = null;
            removed = Files[0];
            for (int i = Files.Length-1; i>0; i--)
            {
                temp[i-1] = Files[i];

            }
            Files = temp;
            freeindex--;
            return removed;
        }
        public DataFile Bigfile()
        {
            QueueFiles temp = new QueueFiles();
            while (Files.Length != 0)
            {
                temp.Enqueue(Dequeue());
            }
            DataFile biggest = temp.Files[0];
            while (!temp.isEmpty())
            {
                DataFile file1 = temp.Dequeue();
                Enqueue(file1);
                if ( compareFiles.compareSizeFiles(file1, biggest) == 2 || compareFiles.compareSizeFiles(file1, biggest) == 1)
                {
                    biggest = file1;
                }
            }
            return biggest;
        }
        public void PrintQueue()
        {
            QueueFiles temp = new QueueFiles();
            int arratsize = Files.Length;
            while (Files.Length!=0)
            {
                temp.Enqueue(Dequeue());
            }
            arratsize = temp.Files.Length;
            while ( temp.Files.Length!=0)
            {
                DataFile file = temp.Dequeue();
                file.Dir();
                string a = file.Dir();
                Enqueue(file);
            }
        }
        public DataFile[] SearchFileByType(int type)
        {
            
            int counter1= 0;
            QueueFiles temp = new QueueFiles();
           
            while (Files.Length != 0)
            {
                temp.Enqueue(Dequeue());
            }
            while (temp.Files.Length!= 0)
            {
                DataFile file = temp.Dequeue();
                Enqueue(file);
                if ((int)file.Getfiletype() == type)
                {
                    counter1++;
                }
            }
            DataFile[] newtemp = new DataFile[counter1];
            int counter = 0;
            while (Files.Length != 0)
            {
                DataFile file = Dequeue();
               
                    if ((int)file.Getfiletype() == type)
                    {
                        newtemp[counter] = file;
                        counter++;
                    }
                
                temp.Enqueue(file);
            }
            while (temp.Files.Length != 0)
            {
                DataFile file = temp.Dequeue();
                Enqueue(file);
            }
            return newtemp;
        }
    }

}
