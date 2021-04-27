using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace QuizApplication
{
    public partial class Form1 : Form
    {
        int score = 0;
        int notscore = 0;
        int counter = 0;
        int nextq = 0;
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            setUpQuestion();
            btnGoAgain.Visible = false;
            btnGoAgain.Enabled = false;
            btnNextTo2.Visible = false;
            btnNextTo2.Enabled = false;
            lbCorrectQM.ForeColor = Color.Red;
            tmrTimer.Start();
        }

        private void setUpQ(string q, string rb1, string rb2, string rb3, string rb4, string ca)
        {
            lbQuestion.Text = q;
            rbAns1.Text = rb1;
            rbAns2.Text = rb2;
            rbAns3.Text = rb3;
            rbAns4.Text = rb4;
            lbCorrectQM.Visible = false;
            lbCorrectQM.Text = $"The correct answer is: {ca}";
        }
        private void setUpQuestion()
        {
            lbQuestion.Text = "What datatype would you make variable score?";
            rbAns1.Text = "String";
            rbAns2.Text = "Int";
            rbAns3.Text = "Float";
            rbAns4.Text = "Char";
            lbCorrectQM.Visible = false;
            lbCorrectQM.Text = "The correct answer is: Int";
        }

        private void setUpQuestion2()
        {
            lbQuestion.Text = "Which one is not a country";
            rbAns1.Text = "Peru";
            rbAns2.Text = "Europe";
            rbAns3.Text = "Norway";
            rbAns4.Text = "Finland";
            lbCorrectQM.Visible = false;
            lbCorrectQM.Text = "The correct answer is: Europe";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //string anQ1 = "Int";

            if(rbAns2.Checked == true)
            {
                score++;
                lbScores.ForeColor = Color.LawnGreen;
                lbScores.Text = "Score: " + score;
                lbCorrectQM.ForeColor = Color.LawnGreen;
            }
            else
            {
                notscore++;
                lbNotScores.ForeColor = Color.Red;
                lbNotScores.Text = "Not Score: " + notscore;
                lbCorrectQM.ForeColor = Color.Red;
            }

            lbCorrectQM.Visible = true;
            rbAns1.Enabled = false;
            rbAns2.Enabled = false;
            rbAns3.Enabled = false;
            rbAns4.Enabled = false;
            btnCheck.Enabled = false;
            btnGoAgain.Visible = true;
            btnGoAgain.Enabled = true;
            btnNextTo2.Visible = true;
            btnNextTo2.Enabled = true;
            tmrTimer.Stop();
            lbTime.Text = ($"Times up! You took {counter}s.");
        }

        private void disableNextAndAgainButtons()
        {
            btnGoAgain.Visible = false;
            btnGoAgain.Enabled = false;
            btnNextTo2.Visible = false;
            btnNextTo2.Enabled = false;
        }

        private void enableNextAndAgainButtons()
        {
            btnGoAgain.Visible = true;
            btnGoAgain.Enabled = true;
            btnNextTo2.Visible = true;
            btnNextTo2.Enabled = true;
        }

        private void rbreset()
        {
            rbAns1.Checked = false;
            rbAns2.Checked = false;
            rbAns3.Checked = false;
            rbAns4.Checked = false;
            rbAns1.Enabled = true;
            rbAns2.Enabled = true;
            rbAns3.Enabled = true;
            rbAns4.Enabled = true;
            btnCheck.Enabled = true;
        }

        private void btnGoAgain_Click(object sender, EventArgs e)
        {
            lbCorrectQM.Visible = false;
            rbAns1.Enabled = true;
            rbAns2.Enabled = true;
            rbAns3.Enabled = true;
            rbAns4.Enabled = true;
            btnCheck.Enabled = true;
            disableNextAndAgainButtons();
            tmrTimer.Start();
            counter = 0;
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            counter++;
            lbTime.Text = ($"Timer: {counter.ToString()}");
        }

        private void btnNextTo2_Click(object sender, EventArgs e)
        {
            nextq++;

            gbQ1.Visible = false;
            disableNextAndAgainButtons();

            gbQ1.Visible = true;
            rbreset();

            tmrTimer.Start();
            counter = 0;

            switch (nextq)
            {
                case 1: setUpQ("Hello", "Bye", "Hi", "Goodbye", "Goodnight", "Hi");
                    break;
                case 2: setUpQ("What question is this?", "First", "Third", "Last", "Second", "Third");
                    break;
                case 3: setUpQ("What is the capital of Chile?", "Chile City", "Santiago", "Los Angeles", "London", "Santiago");
                    break;
                case 4:
                    setUpQ("Question Goes Here", "Answer 1", "Answer 2", "Answer 3", "Answer 4", "Correct Answer");
                    break;
                case 5:
                    setUpQ("Question Goes Here", "Answer 1", "Answer 2", "Answer 3", "Answer 4", "Correct Answer");
                    break;
                case 6:
                    setUpQ("Question Goes Here", "Answer 1", "Answer 2", "Answer 3", "Answer 4", "Correct Answer");
                    break;
                case 7:
                    setUpQ("Question Goes Here", "Answer 1", "Answer 2", "Answer 3", "Answer 4", "Correct Answer");
                    break;
                case 8:
                    setUpQ("Question Goes Here", "Answer 1", "Answer 2", "Answer 3", "Answer 4", "Correct Answer");
                    break;
            }
            

            //setUpQuestion2();
        }
    }
}
