using StudentLib.Controllers;
using StudentLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSim
{
    public partial class FrmRegistration : Form
    {
        private StudentController studentController;
        private void ListUpdate()
        {
            studentController.Load();
            lstStudents.Items.Clear();
            foreach (var student in studentController.Students)
            {               
              lstStudents.Items.Add(student.Name);                
               
            }
        }
        public FrmRegistration()
        {
            InitializeComponent();
            studentController = new StudentController();
            ListUpdate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student(txtStudentName.Text);
                studentController.Add(student);               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ListUpdate();
            
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            studentController.Remove(lstStudents.SelectedItem.ToString());
            ListUpdate();
            btnremove.Enabled = false;
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstStudents.SelectedIndex >= 0)
            {
                btnremove.Enabled = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex >=0 )
            {
                Game game = new Game(lstStudents.SelectedItem.ToString());
                game.Show();
                this.Hide();
                game.Owner = this;
            }
          
        }
    }
}
