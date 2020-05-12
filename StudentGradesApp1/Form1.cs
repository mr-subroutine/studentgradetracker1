using System;
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
    public partial class Studenr : Form
    {
        protected string[] studentNames = new string[30];
        protected int[] studentGrades = new int[30];
        protected int[] homeRooms = new int[30];
        protected int indexTracker = 0;

        public Studenr()
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

            // loops until user enters value for name
            while (isNameConfirmed != true)
            {
                string nameEntry = inputStudent();
                if (nameEntry != null || nameEntry != "")
                {
                    studentNames[indexTracker] = nameEntry;
                    isNameConfirmed = true;
                }
            }

            // loops until user enters value for grade
            while (isGradeConfirmed != true)
            {
                int gradeEntry = 0;
                try
                {
                    gradeEntry = inputGrade();
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
            }
            addToTextBox(indexTracker, studentNames, studentGrades);
            indexTracker++;
        }

        private string inputStudent()
        {
            string name = "";
            try
            {
                name = Microsoft.VisualBasic.Interaction.InputBox("Please Enter Student First and Last Name", "Enter Name", "");
            }

            catch
            {
                MessageBox.Show("Please enter a First name and Last name.");
            }
            return name;
        }

        private int inputGrade()
        {
            int grade = Int32.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter a numeric grade from 0-100", "Enter Grade", ""));
            return grade;
        }

        private void addToTextBox(int pos, string[] names, int[] grades)
        {
            string temp_name = names[pos];
            int temp_grade = grades[pos];
            listBoxStudent.Items.Add(temp_name + "\t" + temp_grade.ToString("n"));
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            listBoxStudent.Items.Clear();
        }
    }
}
