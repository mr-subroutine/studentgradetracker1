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
    public partial class Form1 : Form
    {
        protected string[] studentNames = new string[30];
        protected int[] studentGrades = new int[30];
        protected int indexTracker = 0;

        public Form1()
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

            while (isNameConfirmed != true)
            {
                string nameEntry = inputStudent();
                if (nameEntry != null || nameEntry != "")
                {
                    studentNames[indexTracker] = nameEntry;
                    isNameConfirmed = true;
                }
            }

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
                    indexTracker++;
                    isGradeConfirmed = true;
                }
            }
        }

        private string inputStudent()
        {
            string name = "";
            try
            {
                name = Microsoft.VisualBasic.Interaction.InputBox("Name Entry", "Enter Student First and Last Name", "");
            }

            catch
            {
                MessageBox.Show("Please enter a First name and Last name.");
            }

            finally
            {
                return name;
            }
        }

        private int inputGrade()
        {
            int grade = Int32.Parse(Microsoft.VisualBasic.Interaction.InputBox("Grade Entry", "Enter Grade", ""));
            return grade;
        }
    }
}
