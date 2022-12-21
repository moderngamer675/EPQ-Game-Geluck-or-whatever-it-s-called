using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Possible_EPQ
{
    public partial class GameUI : Form
    {
        bool correctDoorPressed = false;
        bool incorrectDoorPressed = false;
        bool buttonPressed = false;

        bool doorOne = false;
        bool doorTwo = false;
        bool doorThree = false;

        int counter = 0;
        string answerText;
        string count;
        Random rnd = new Random();

        public GameUI()
        {
            InitializeComponent();
            tb_answer.Visible = false;
            tbScore.Text = "0";
        }

        private void timerTick_Tick(object sender, EventArgs e)
        {
            int doorNumber = randomDoorSelcter();
            timerTick.Stop();
            doorNumber = doorNumber + 1;

            double chance = rnd.NextDouble();

            if(doorNumber == 1)
            {
                if(chance < 0.5)
                {
                    answerText = Convert.ToString(doorNumber + 1);
                }
                else
                {
                    answerText = Convert.ToString(doorNumber + 2);
                }
            }
            else if(doorNumber == 2)
            {
                if (chance < 0.5)
                {
                    answerText = Convert.ToString(doorNumber + 1);
                }
                else
                {
                    answerText = Convert.ToString(doorNumber - 1);
                }
            }
            else
            {
                if (chance < 0.5)
                {
                    answerText = Convert.ToString(doorNumber - 1);
                }
                else
                {
                    answerText = Convert.ToString(doorNumber - 2);
                }
            }
            tb_answer.Text = answerText;

            switch (doorNumber)
            {
                case 1:
                    doorOne = true;
                    doorTwo = false;
                    doorThree = false;
                    break;

                case 2:
                    doorOne = false;
                    doorTwo = true;
                    doorThree = false;
                    break;

                case 3:
                    doorOne = false;
                    doorTwo = false;
                    doorThree = true;
                    break;
            }
        }

        public int randomDoorSelcter()
        {
            Random A = new Random();
            Random B = new Random();
            Random M = new Random();
            Random I = new Random();

            Stack st = new Stack();

            int a = A.Next(0, 797);
            int b = B.Next(0, 576);
            int m = M.Next(3, 23);
            int ik = I.Next(560, 890);

            int startValue = (0 * a) + (b % m);
            st.Push(startValue);

            int answer = 0;

            for (int i = 0; i < ik; i++)
            {
                answer = (startValue * a + b) % m;
                startValue = answer;
                st.Push(startValue);
            }

            answer = 0;

            for (int i = 0; i < st.Count; i++)
            {
                answer = answer + (int)st.Pop();
            }

            answer = answer % 3;

            return answer;
        }

        public void scoreCounter()
        {
            while (buttonPressed == true && correctDoorPressed == true)
            {
                counter++;
                count = Convert.ToString(counter);
                tbScore.Text = count;
                correctDoorPressed = false;
                buttonPressed = false;
                timerTick.Start();
            }
            if (incorrectDoorPressed == true)
            {
                timerTick.Enabled = false;
                btn_doorOne.Enabled = false;
                btn_doorTwo.Enabled = false;
                btn_doorThree.Enabled = false;
                MessageBox.Show($"Incorrect Door Pressed, your score was {counter}");
            }
        }

        private void btn_doorOne_Click(object sender, EventArgs e)
        {
            buttonPressed = true;
            if (doorOne == true)
            {
                correctDoorPressed = true;
            }
            else
            {
                incorrectDoorPressed = true;
            }
            scoreCounter();
        }

        private void btn_doorTwo_Click(object sender, EventArgs e)
        {
            buttonPressed = true;
            if (doorTwo == true)
            {
                correctDoorPressed = true;
            }
            else
            {
                incorrectDoorPressed = true;
            }
            scoreCounter();
        }

        private void btn_doorThree_Click(object sender, EventArgs e)
        {
            buttonPressed = true;
            if (doorThree == true)
            {
                correctDoorPressed = true;
            }
            else
            {
                incorrectDoorPressed = true;
            }
            scoreCounter();
        }

        private void Exit(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_showAnswer(object sender, MouseEventArgs e)
        {
            tb_answer.Visible = true;
        }

        private void btn_hideAnswer(object sender, MouseEventArgs e)
        {
            tb_answer.Visible = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            timerTick.Enabled = true;
            btn_doorOne.Enabled = true;
            btn_doorTwo.Enabled = true;
            btn_doorThree.Enabled = true;

            correctDoorPressed = false;
            incorrectDoorPressed = false;
            buttonPressed = false;

            doorOne = false;
            doorTwo = false;
            doorThree = false;

            tbScore.Text = "0";

            counter = 0;
            answerText = "0";
            count = "0";

            timerTick.Start();
        }
    }
}
