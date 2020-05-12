using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradesApp1
{ 
    public partial class Student : Form
    {
        protected string[] studentNames = new string[30];
        protected int[] studentGrades = new int[30];
        protected int[] homeRooms = new int[30];
        protected int indexTracker = 0;
       // protected string[] storeForWrite = new string[30];

        public Student()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_addStudent_Click(object sender, EventArgs e)
        {
            bool isNameConfirmed = false;
            bool isGradeConfirmed = false;
            string nameEntry;

            // loops until user enters value for name
            do
            {
                nameEntry = inputStudent();
                // check if input is set to no by user to exit the input box
                if (nameEntry == "n" || nameEntry == "N")
                {
                    break;
                }

                else if (nameEntry != null && nameEntry != "")
                {
                    studentNames[indexTracker] = nameEntry;
                    isNameConfirmed = true;
                }
            } while (isNameConfirmed != true && nameEntry != "n" && nameEntry != "N");

            // loops until user enters value for grade
            do
            {
                int gradeEntry = 1;
                try
                {
                    gradeEntry = inputGrade();
                    // 5/12 - find a way to make it so Enter the grade value doesn't appear when user selects "n"
                }

                catch
                {
                    MessageBox.Show("Enter the grade value.");
                }
                
                finally
                {
                    studentGrades[indexTracker] = gradeEntry;
                    isGradeConfirmed = true;
                }
            } while (isGradeConfirmed != true);

            if (isNameConfirmed == true && isGradeConfirmed == true)
            {
                addToTextBox(indexTracker, studentNames, studentGrades);
                indexTracker++;
            }
        }

        private string inputStudent()
        {
            string name = "";
            try
            {
                name = Microsoft.VisualBasic.Interaction.InputBox("Enter Full Student Name and Type \"n\" to exit", "Enter Name", "");
            }

            catch
            {
                MessageBox.Show("Please enter a First name and Last name.");
            }
            return name;
        }

        private int inputGrade()
        {
            int grade;
            do
            {
                grade = Int32.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter Grade and Type \"n\" to exit", "Enter Grade", ""));
            } while (grade > 100);

            return grade;
        }

        private void addToTextBox(int pos, string[] names, int[] grades)
        {
            // adds value of array position for name and grade to listbox
            string temp_name = names[pos];
            int temp_grade = grades[pos];
            listBoxStudent.Items.Add(temp_name + "\t" + temp_grade.ToString("n"));
        }

        private void btn_average_Click(object sender, EventArgs e)
        {
            if (indexTracker < 2)
            {
                MessageBox.Show("Not enough students to average.");
            }

            else
            {
                int totalStudents = indexTracker;
                int sum = 0;
                for (int i = 0; i <= totalStudents; i++)
                {
                    sum += studentGrades[i];
                }

                int average = sum / totalStudents;
                listBoxStudent.Items.Add("The average grade is: " + average.ToString());
            }
        }

        private void btn_lowest_Click(object sender, EventArgs e)
        {
            int totalStudents = indexTracker;
            string getStudent = "";
            int min = 101;

            for (int i = 0; i <= totalStudents - 1; i++)
            {
                if (studentGrades[i] < min)
                {
                    min = studentGrades[i];
                    getStudent = studentNames[i];
                }
            }
            listBoxStudent.Items.Add(getStudent + " has the lowest grade with a score of: " + min);
        }

        private void btn_highest_Click(object sender, EventArgs e)
        {
            int totalStudents = indexTracker;
            string getStudent = "";
            int max = -1;

            for (int i = 0; i <= totalStudents - 1; i++)
            {
                if (studentGrades[i] > max)
                {
                    max = studentGrades[i];
                    getStudent = studentNames[i];
                }
            }
            listBoxStudent.Items.Add(getStudent + " has the highest grade with a score of: " + max);
        }

        private void btn_writeToFile_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\Students.txt";

            string[] clist = listBoxStudent.Items.OfType<string>().ToArray();
            //string listBoxText = listBoxStudent.Text;

            System.IO.File.WriteAllLines(f, clist);
        }
    }
}
