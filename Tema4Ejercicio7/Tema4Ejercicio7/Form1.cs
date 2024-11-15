using Ejercicio2Tema3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4Ejercicio7
{
    public partial class Form1 : Form
    {
        ClassRoom classRoom22;
        string[] students;
        string[] subjects = new string[Enum.GetNames(typeof(ClassRoom.Subjects)).Length];
        int[,] notes;
        ToolTip toolTip;
        public Form1()
        {
            InitializeComponent();
            FillStudents();
            FillSubjects();
            classRoom22 = new ClassRoom(students);
            notes = classRoom22.Notas;
            toolTip = new ToolTip();
            CreateTable();
            labelInfoMedia.Text = $"Class Media : {classRoom22.MediaGrades():F2}";

        }



        public void FillStudents()
        {

            string path = Environment.GetEnvironmentVariable("USERPROFILE");
            path = path + "\\Desktop\\students.txt";
            Console.Write(path);
            using (StreamReader reader = new StreamReader(path))
            {
                string listStudents = reader.ReadToEnd();
                students = listStudents.Split(',');


            }

            foreach (string studentName in students)
            {
                comboBoxStudents.Items.Add(studentName);
            }

        }
        public void CreateTable()
        {
            int labelPositionX = 100;
            int labelPositionY = 120;
            int labelStudentPositionX = 15;
            int labelStudentPositionY = 140;
            //cabecera de la tabla
            for (int i = 0; i < subjects.Length; i++)
            {
                Label lblSubject = new Label();
                lblSubject.Size = new Size(84, 15);
                lblSubject.Location = new Point(labelPositionX, labelPositionY);
                lblSubject.Text = subjects[i];
                lblSubject.BackColor = Color.LightGray  ;
                lblSubject.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelPositionX += 80;
                Controls.Add(lblSubject);

            }
            //students

            for (int i = 0; i < students.Length; i++)
            {
                Label lblStudents = new Label();
                lblStudents.Size = new Size(75, 15);
                lblStudents.Location = new Point(labelStudentPositionX, labelStudentPositionY);
                lblStudents.Text = students[i];
                lblStudents.BackColor = Color.LightGray;
                lblStudents.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelStudentPositionY += 30;
                Controls.Add(lblStudents);
            }

            int labelNotePositionX = 100;
            int labelNotePositionY = 110;

            //notes [students,subject]
            for (int i = 0; i < notes.GetLength(0); i++)
            {
                for (int j = 0; j < notes.GetLength(1); j++)
                {
                    Label labelNote = new Label();
                    labelNote.Size = new Size(83, 15);
                    labelNote.Text = notes[i, j].ToString();
                    labelNote.BackColor = GetColorForGrade(notes[i, j]);
                    if (j % subjects.Length == 0)
                    {

                        labelNotePositionX = 100;
                        labelNotePositionY += 30;

                    }
                    else
                    {
                        labelNotePositionX += 80;

                    }
                    labelNote.Location = new Point(labelNotePositionX, labelNotePositionY);
                    labelNote.MouseEnter += new System.EventHandler(this.ChangeColor);
                    labelNote.MouseLeave += new System.EventHandler(this.ResetColorChange);

                    toolTip.SetToolTip(labelNote, $"Subject: {subjects[j]} \n Student: {students[i]}");
                    Controls.Add(labelNote);

                }
            }

        }


        private Color GetColorForGrade(int grade)
        {
            if (grade >= 9) return Color.GreenYellow;
            else if (grade >= 7) return Color.LightGreen;
            else if (grade >= 5) return Color.Orange;
            else return Color.Red;
        }
        public void FillSubjects()
        {
            for (int i = 0; i < Enum.GetNames(typeof(ClassRoom.Subjects)).Length; i++)
            {
                comboBoxSubject.Items.Add((ClassRoom.Subjects)i);
                subjects[i] = ((ClassRoom.Subjects)i).ToString();
            }
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.BackColor = Color.Yellow;

        }
        private void ResetColorChange(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.BackColor = GetColorForGrade(int.Parse(lbl.Text));


        }

        private void SelectCb(object sender, EventArgs e)
        {
            string classMediaInfo = $"Class Media: {classRoom22.MediaGrades():F2}";
            string studentMediaInfo = "";
            string subjectMediaInfo = "";
            string minMaxInfo = "";

            //es decir si no esta seleccionado 
            if (comboBoxStudents.SelectedIndex != -1)
            {

                studentMediaInfo = $"\nStudent Media: {classRoom22.MediaStudent(comboBoxStudents.SelectedIndex):F2}";

                int maxGrade;
                int minGrade;

                classRoom22.MaxMinStudent(comboBoxStudents.SelectedIndex, out maxGrade, out minGrade);
                minMaxInfo = $"Max grade: {maxGrade} \nMin grade: {minGrade}";
            }

            if (comboBoxSubject.SelectedIndex != -1)
            {
                subjectMediaInfo = $"\nSubject Media: {classRoom22.MediaSubject(comboBoxSubject.SelectedIndex):F2}";
            }


            labelInfoMedia.Text = classMediaInfo + studentMediaInfo + subjectMediaInfo;


            labelNoteMinMax.Text = minMaxInfo;


        }

    }
}
