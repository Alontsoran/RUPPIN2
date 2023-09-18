using HW2;
using HW3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static int numbertochoose2;
        static int numbertochoose;
        QueueFiles files = new QueueFiles();
        public Form1()
        {

            InitializeComponent();
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(button_add_defult, " Add File with defult data");
            toolTip1.SetToolTip(button_add_a_file, "Add File with your own data");
            toolTip1.SetToolTip(button_remove_file, "Remove first file in data ");
            toolTip1.SetToolTip(button_print_all, "print all files ");
            toolTip1.SetToolTip(press5, "print the file with the biggest size ");
            listoftable.Items.Clear();
            if (numbertochoose2 < 0 && numbertochoose2 > 5)
            {
                MessageBox.Show("PLEASE CHOOSE TYPE");
            }
            TXT2.Enabled = true;
            DOC2.Enabled = true;
            DOCX2.Enabled = true;
            PDF2.Enabled = true;
            PPTX2.Enabled = true;
        }
        private bool EMPTydata()
        {
            if (files.GetFiles().Length > 0)
            {
               return true;
            }
            else
            {
                return false;
            }
        }
        private void EMPTYLIST()
        {
            if (files.GetFiles().Length >= 0)
            {
                labelemptylist.Visible = false;
            }
            else
            {
                labelemptylist.Visible = true;
            }
        }

        private void add_defult_file_press1(object sender, EventArgs e)
        {
            listoftable.Items.Clear();
            EMPTYLIST();
            DataFile[] d1 = new DataFile[10];
            int structercounter = 0;//1
            structercounter++;
            for (int i = structercounter - 1; i < structercounter; i++)
            {
                d1[i] = new DataFile();

                files.Enqueue(d1[i]);
                if (structercounter == d1.Length)
                {
                    DataFile[] temp = new DataFile[d1.Length * 2];
                    for (int j = 0; j < d1.Length; j++)
                    {
                        temp[j] = d1[j];
                    }
                    d1 = temp;
                    
                    break;

                }

            }
        }
        private void add_a_file_press2(object sender, EventArgs e)
        {
            EMPTYLIST();
            bool a=false, b=false, c = false;
            DataFile d = null;
            string datafile = textBox2.Text;
            if (datafile==""|| datafile==null)
            {
                MessageBox.Show("please enter data to the file");
                datafile = "";
            }
            else
            {
               a = true;
            }
            int typeoffile;
            typeoffile = numbertochoose;
            if (typeoffile <=0|| typeoffile>5)
            {
                MessageBox.Show("please choose filetype");
            }
            else
            {
                b= true;
            }
            string filename = textBox1.Text;
            if (filename == "" || filename == null)
            {
                MessageBox.Show("please enter name to the file");
                filename = "";
            }
            else
            {
                c = true;
            }
            DataFile y = new DataFile();
            if (y.SetFile(filename)==false)
            {
                MessageBox.Show("please enter name without '>'  '?'  '*'  ':'  '/' ||  '|' '>'");
                filename = "";

            }
            Console.WriteLine("-------------------------------------------------------------------------------------");
            if (a==true&&b==true&&c==true)
            {
                d = new DataFile(datafile, filename, typeoffile);
            }
            else
            {
                MessageBox.Show("File didnt crated");
            }
            
            textBox1.Text = "";
            textBox2.Text = "";
            numbertochoose = 0;
            files.Enqueue(d);
            groupBox1.Visible = Enabled;
            listoftable.Items.Clear();
          
        }
        private void remove_a_file_press3(object sender, EventArgs e)
        {
            listoftable.Items.Clear();
            try
            {
                files.Dequeue();
            }
            catch (Exception b)
            {
                Console.WriteLine("over flow:{0}",b.Message);
                MessageBox.Show("NO FILES TO REMOVE ");
            }
            EMPTYLIST();
        }

        private void print_all_files_press4(object sender, EventArgs e)
        {
            printtolist();

            
        }
        public void printtolist()
        {
            if (EMPTydata()==false)
            {
                MessageBox.Show("no data to print");
            }
            listoftable.Items.Clear();
            
            DataFile[] array =files.GetFiles();
            for (int i = 0; i < array.Length; i++)
            {
                listoftable.Items.Add(array[i].Dir());
            }
        }

        private void print_a_spec_type_of_filepress5(object sender, EventArgs e)
        {

            if (EMPTydata() == false)
            {
                MessageBox.Show("no data to print");
            }
            DataFile[] array = files.SearchFileByType(numbertochoose2);
            if (array.Length==0)
            {
                MessageBox.Show("no data to print");
            }
            for (int i = 0; i < array.Length; i++)
            {
                listoftable.Items.Add(array[i].Dir());
            }

            if (numbertochoose2 < 0 && numbertochoose2 > 5)
            {
                PRINTBYTYPE.Enabled = false;
            }
            
        }
        private void print_the_largest_file_press6(object sender, EventArgs e)
        {
            listoftable.Items.Clear();
            listoftable.Items.Add(files.Bigfile().Dir());

        }
        private void TXT2_Click(object sender, EventArgs e)
        {
            listoftable.Items.Clear();
            numbertochoose2 = 1;
            listoftable.Items.Clear();
        }
        private void DOC2_Click_1(object sender, EventArgs e)
        {
            listoftable.Items.Clear();
            numbertochoose2 = 2;
            listoftable.Items.Clear();
        }

        private void DOCX2_Click_1(object sender, EventArgs e)
        {
          listoftable.Items.Clear();
          numbertochoose2 = 3;
          listoftable.Items.Clear();
         
        }

        private void PDF2_Click_1(object sender, EventArgs e)
        {
        listoftable.Items.Clear();
        numbertochoose2 = 4;
        listoftable.Items.Clear();
         }

        private void PPTX2_Click_1(object sender, EventArgs e)
        {
            listoftable.Items.Clear();
            numbertochoose2 = 5;
            listoftable.Items.Clear();
        }
        
        private void visible_add_file_buttton(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void TXT_Click(object sender, EventArgs e)
        {
            numbertochoose = 1;
        }

        private void DOC_Click(object sender, EventArgs e)
        {
            numbertochoose = 2;
        }

        private void docx_Click(object sender, EventArgs e)
        {
            numbertochoose = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numbertochoose = 4;
        }

        private void pptx_Click(object sender, EventArgs e)
        {
            numbertochoose = 5;
        }
    }
}
