using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace HW2
{
    enum filetypeExtrension { TXT=1,DOC=2,DOCX=3,PDF=4,PPTX=5};
    internal class DataFile
    {
        
        public static int filecounter = 0;
        static readonly Array arr2 = Enum.GetValues(typeof(filetypeExtrension));
        string Filename;
        string Data;
        filetypeExtrension Type=(filetypeExtrension)1;
         DateTime lastUpadateTime;
        public void SetTime()
        {
            this.lastUpadateTime = DateTime.Now;
        }
        public DateTime GetTime()
        {
            return lastUpadateTime;
        }
       public bool SetFile(string Filename)
       {
            foreach (char c in Filename)
            {
                if (c == '>' || c == '?' || c == '*' || c == ':' || c == '/' || c == '|' || c == '>')
                {
                    Console.WriteLine("TRY AGAIN ");
                    return false;
                }
            }
            this.Filename = Filename;
            return true;
       }
        public void Setfiletype (int typeoffile)
        {
            this.Type = (filetypeExtrension)typeoffile;
        }
        public object Getfiletype()
        {
            return this.Type;
        }
        public string Getfilename ()
        {
           return this.Filename;
        }
        public string Getdata()
        {
            return this.Data;
        }
        public void SeData(string Data)
        {
            this.Data = Data;
        }
        
        //mission 2 - b changed the get size to public 
        public double Getsize()
        {
            return this.Data.Length;
        }
        public  string Dir()
        {
            string str = this.lastUpadateTime.ToString() + " " + (this.Getsize() / 1024) + " KB " + (this.Filename);
            Console.WriteLine(str);
            return str;
        }
        public DataFile(string Filename, string Data, int typeoffile)
        {
            object add;
            string point = ".";
            string filetype=null;
            filecounter++;
            foreach (var i in arr2)
            {
                if (typeoffile==(int)i)
                {
                    filetype = i.ToString();
                   Setfiletype((int)i);
                }
            }
            Filename += point+filetype;
            while (!SetFile(Filename))
            {
                Console.WriteLine("error! you cant write this chachaters ,'>' ,'?' ,'*' ,':' ,'/' '\' ,'|' ,'<' ");
                Filename = Console.ReadLine();
            }
           
            SeData(Data);
            this.SetTime();
        }
        public DataFile()
        {
            filecounter++;
            this.Filename = "SameFile" + filecounter + "." + Type.ToString();
            this.Data = "";
            this.SetTime();
        }
        public DataFile(DataFile Other)///no need to use that assagiment in this mathod
        {
            this.Filename = Other.Filename; 
            this.Data = Other.Data;
        }
       
      
        
    }

}
