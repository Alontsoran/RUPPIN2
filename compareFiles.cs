using HW2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    static class compareFiles
    {
        //mission 2-a  
        public static bool EqualFiles(DataFile file1, DataFile file2)
        {
            if (file1.Getfilename()==file2.Getfilename())
            {
                return true;
            }
            return false;
        }
        //mission 2-b//changed getsize to public 
        public static int compareSizeFiles(DataFile file1, DataFile file2)
        {
                    if (file1.Getsize() == file2.Getsize())
            {
                return 0;
            }
            else if (file1.Getsize() > file2.Getsize())
            {
                return 1;
            }
            return 2;
        } 

    }
}
