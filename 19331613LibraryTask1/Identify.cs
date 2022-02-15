using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _19331613LibraryTask1
{
    public partial class Identify : Form
    {
     
        int time = 0;

        Boolean timeOut = false;

        Boolean timerSet = false;

        public static Boolean callNum = true;

        public Dictionary<int, string> DicIdent = new Dictionary<int, string>();

        List<string> aryAnswers = new List<string>();

        int ranNum1 = 0;
        int ranNum2 = 0;
        int ranNum3 = 0;
        int ranNum4 = 0;
        int ranNum5 = 0;
        int ranNum6 = 0;
        int ranNum7 = 0;

        public Identify()
        {
            InitializeComponent();

              DicIdent.Add(000, "Computer Science");                            //initialize dictionary
               DicIdent.Add(100, "Philosophy & Psychology");
               DicIdent.Add(200, "Religion");
               DicIdent.Add(300, "Social Sciences");
               DicIdent.Add(400, "Languages");
               DicIdent.Add(500, "Science");
               DicIdent.Add(600, "Technology");
               DicIdent.Add(700, "Arts & Recreation");
               DicIdent.Add(800, "Literature");
               DicIdent.Add(900, "History & Geography");
        }

        private void btnIdentify_Click(object sender, EventArgs e)
        {
            StringBuilder wrongQs = new StringBuilder();    // holds wrong answers to output to user

            int score = 0;

            int q1 = 0;
            int q2 = 0;
            int q3 = 0;
            int q4 = 0;

            timer1.Stop();

           if (callNum == true)                             // if the questions are call numbers , it then gets the first number which is also the index for the key and value
            {                                               // it then uses the position to find the value for the call number and checks it against what the user choose in the combobox 
                
                q1 = Int32.Parse(idBox1.Text.Substring(0, 1));
            
                q2 = Int32.Parse(idBox2.Text.Substring(0, 1));
            
                q3 = Int32.Parse(idBox3.Text.Substring(0, 1));
             
                q4 = Int32.Parse(idBox4.Text.Substring(0, 1));
              

                if (cmbAns1.Text == DicIdent.ElementAt(q1).Value)
                {
                    score++;
                }
                else
                {
                    wrongQs.Append("Question 1 is incorrect \n");
                }
                if (cmbAns2.Text == DicIdent.ElementAt(q2).Value)
                {
                    score++;
                }
                else
                {
                    wrongQs.Append("Question 2 is incorrect \n");
                }
                if (cmbAns3.Text == DicIdent.ElementAt(q3).Value)
                {
                    score++;
                }
                else
                {
                    wrongQs.Append("Question 3 is incorrect \n");
                }
                if (cmbAns4.Text == DicIdent.ElementAt(q4).Value)
                {
                    score++;
                }
                else
                {
                    wrongQs.Append("Question 4 is incorrect \n");
                }

            }
            else                                                            // if the questions are call numbers genre , it then gets the first number of the select combobox option which is also the index for the key and value
            {                                                               // it then uses the position to find the value for the call number and checks it against the question
                if (cmbAns1.Text == "")
                {
                    q1 = -1;
                }
                else
                {
                    q1 = Int32.Parse(cmbAns1.Text.Substring(0, 1));
                }
                if (cmbAns2.Text == "")
                {
                    q2 = -1;
                }
                else
                {
                    q2 = Int32.Parse(cmbAns2.Text.Substring(0, 1));
                }
                if (cmbAns3.Text == "")
                {
                    q3 = -1;
                }
                else
                {
                    q3 = Int32.Parse(cmbAns3.Text.Substring(0, 1));    
                }
                if (cmbAns4.Text == "")
                {
                    q4 = -1;
                }
                else
                {
                    q4 = Int32.Parse(cmbAns4.Text.Substring(0, 1));
                }              
                if (q1 == -1)
                {
                    wrongQs.Append("Question 1 is incorrect \n");
                    
                }
                else if (idBox1.Text != DicIdent.ElementAt(q1).Value)
                {
                    score++;
                }              
               
                if (q2 == -1)
                {
                    wrongQs.Append("Question 2 is incorrect \n");
                   
                }
                else if(idBox2.Text != DicIdent.ElementAt(q2).Value)
                {
                    score++;
                }
                if (q3 == -1)
                {
                    wrongQs.Append("Question 3 is incorrect \n"); 
                }
                else if(idBox3.Text == DicIdent.ElementAt(q3).Value)
                {
                    score++;
                }
                if (q4 == -1)
                {
                    wrongQs.Append("Question 4 is incorrect \n");
                }
                else if(idBox4.Text == DicIdent.ElementAt(q4).Value)
                {
                  score++;
                    
                }

               
            }

            MessageBox.Show("Your score is " + score);          // adds score and outputs it 
            MessageBox.Show("Questions you got wrong \n" + wrongQs.ToString());                //outputs what questions the user got wrong
         //   DialogResult dialog = MessageBox.Show("Do you want to change questions", "Confirmations", MessageBoxButtons.YesNo);     //asks if the user what to alternate
         //   if (dialog == DialogResult.Yes)
         //   {
         //       callNum = !callNum;                         // toggles the boolean    

          //  }
                callNum = !callNum;
                cmbAns1.Items.Clear();
                cmbAns2.Items.Clear();
                cmbAns3.Items.Clear();
                cmbAns4.Items.Clear();

                aryAnswers.Clear();

                randomNums();

                if (callNum == false)
                {
                    idBox1.Text = DicIdent.ElementAt(ranNum1).Value.ToString();
                    idBox2.Text = DicIdent.ElementAt(ranNum2).Value.ToString();
                    idBox3.Text = DicIdent.ElementAt(ranNum3).Value.ToString();
                    idBox4.Text = DicIdent.ElementAt(ranNum4).Value.ToString();

                    aryAnswers.AddRange(new string[] { DicIdent.ElementAt(ranNum1).Key.ToString(), DicIdent.ElementAt(ranNum2).Key.ToString(), DicIdent.ElementAt(ranNum3).Key.ToString(), DicIdent.ElementAt(ranNum4).Key.ToString(), DicIdent.ElementAt(ranNum5).Key.ToString(), DicIdent.ElementAt(ranNum6).Key.ToString(), DicIdent.ElementAt(ranNum7).Key.ToString() });
                     aryAnswers.Sort();

                cmbAns1.Items.AddRange(aryAnswers.ToArray());
                    cmbAns2.Items.AddRange(aryAnswers.ToArray());
                    cmbAns3.Items.AddRange(aryAnswers.ToArray());
                    cmbAns4.Items.AddRange(aryAnswers.ToArray());
                }
                else
                {
                    idBox1.Text = DicIdent.ElementAt(ranNum1).Key.ToString();
                    idBox2.Text = DicIdent.ElementAt(ranNum2).Key.ToString();
                    idBox3.Text = DicIdent.ElementAt(ranNum3).Key.ToString();
                    idBox4.Text = DicIdent.ElementAt(ranNum4).Key.ToString();

                    aryAnswers.AddRange(new string[] { DicIdent.ElementAt(ranNum1).Value, DicIdent.ElementAt(ranNum2).Value, DicIdent.ElementAt(ranNum3).Value, DicIdent.ElementAt(ranNum4).Value, DicIdent.ElementAt(ranNum5).Value, DicIdent.ElementAt(ranNum6).Value, DicIdent.ElementAt(ranNum7).Value });
                    aryAnswers.Sort();

                cmbAns1.Items.AddRange(aryAnswers.ToArray());
                    cmbAns2.Items.AddRange(aryAnswers.ToArray());
                    cmbAns3.Items.AddRange(aryAnswers.ToArray());
                    cmbAns4.Items.AddRange(aryAnswers.ToArray());
                }

            if (timeOut == false && !lblTime.Equals("Time : Infinite"))           // checks to see if user ran out of time
            {
                timer1.Start();
            }
           // timer1.Start();
        }

        public void randomNums()                    //creates 7 unique random numbers and assign them to variables
        {
            Random rand = new Random();          
            ranNum1 = rand.Next(0, 9);
             ranNum2 = rand.Next(0, 9);
             ranNum3 = rand.Next(0, 9);
             ranNum4 = rand.Next(0, 9);
             ranNum5 = rand.Next(0, 9);
             ranNum6 = rand.Next(0, 9);
             ranNum7 = rand.Next(0, 9);

            while (ranNum2 == ranNum1)
            {
                ranNum2 = rand.Next(0, 9);
            }
            while (ranNum3 == ranNum1 || ranNum3 == ranNum2)
            {
                ranNum3 = rand.Next(0, 9);
            }
            while (ranNum4 == ranNum1 || ranNum4 == ranNum2 || ranNum4 == ranNum3)
            {
                ranNum4 = rand.Next(0, 9);
            }
            while (ranNum5 == ranNum1 || ranNum5 == ranNum2 || ranNum5 == ranNum3 || ranNum5 == ranNum4)
            {
                ranNum5 = rand.Next(0, 9);
            }
            while (ranNum6 == ranNum1 || ranNum6 == ranNum2 || ranNum6 == ranNum3 || ranNum6 == ranNum4 || ranNum6 == ranNum5)
            {
                ranNum6 = rand.Next(0, 9);
            }
            while (ranNum7 == ranNum1 || ranNum7 == ranNum2 || ranNum7 == ranNum3 || ranNum7 == ranNum4 || ranNum7 == ranNum5 || ranNum7 == ranNum6)
            {
                ranNum7 = rand.Next(0, 9);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (timerSet == true)
            {
                timer1.Enabled = true;
            }
                                    

            btnEasy.Enabled = false;
            btnMedium.Enabled = false;
            btnHard.Enabled = false;
            btnStart.Enabled = false;
            btnIdentify.Enabled = true;

            idBox1.Enabled = true;
            idBox2.Enabled = true;
            idBox3.Enabled = true;
            idBox4.Enabled = true;
            cmbAns1.Enabled = true;
            cmbAns2.Enabled = true;
            cmbAns3.Enabled = true;
            cmbAns4.Enabled = true;

            randomNums();
                                          
                idBox1.Text = DicIdent.ElementAt(ranNum1).Key.ToString();
                idBox2.Text = DicIdent.ElementAt(ranNum2).Key.ToString();
                idBox3.Text = DicIdent.ElementAt(ranNum3).Key.ToString();
                idBox4.Text = DicIdent.ElementAt(ranNum4).Key.ToString();

                aryAnswers.AddRange(new string[] { DicIdent.ElementAt(ranNum1).Value, DicIdent.ElementAt(ranNum2).Value, DicIdent.ElementAt(ranNum3).Value, DicIdent.ElementAt(ranNum4).Value, DicIdent.ElementAt(ranNum5).Value, DicIdent.ElementAt(ranNum6).Value, DicIdent.ElementAt(ranNum7).Value });
                aryAnswers.Sort();

                cmbAns1.Items.AddRange(aryAnswers.ToArray());
                cmbAns2.Items.AddRange(aryAnswers.ToArray());
                cmbAns3.Items.AddRange(aryAnswers.ToArray());
                cmbAns4.Items.AddRange(aryAnswers.ToArray());
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            lblTime.Text = "Time : " + time.ToString();
            if (time > 0)                               //takes away a second if there is still time every second
            {
                time = time - 1 ;
                lblTime.Text = "Time : " + time.ToString();
               
            }
            else                                                //if user runs out of time
            {
                timer1.Stop();

                MessageBox.Show("Time's up! , click the check button to see your score and click the end/reset button to play again");
                idBox1.Enabled = false;
                idBox2.Enabled = false;
               idBox3.Enabled = false;
                idBox4.Enabled = false;
                cmbAns1.Enabled = false;
                cmbAns2.Enabled = false;
                cmbAns3.Enabled = false;
                cmbAns4.Enabled = false;

                timeOut = true;
            }
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void btnEasy_Click(object sender, EventArgs e)
        {

            timerSet = false;

            lblTime.Text = "Time : Infinite";

            btnStart.Enabled = true;
            
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            time = 20;

            timerSet = true;

            lblTime.Text = "Time : 20 sec" ;

            btnStart.Enabled = true;
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            time = 10;

            timerSet = true;

            lblTime.Text = "Time : 10 sec";

            btnStart.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 home = new Form1();
            home.Show();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            idBox1.Enabled = false;
            idBox2.Enabled = false;
            idBox3.Enabled = false;
            idBox4.Enabled = false;
            cmbAns1.Enabled = false;
            cmbAns2.Enabled = false;
            cmbAns3.Enabled = false;
            cmbAns4.Enabled = false;
            btnEasy.Enabled = true;
            btnMedium.Enabled = true;
            btnHard.Enabled = true;
            btnStart.Enabled = false;
            btnIdentify.Enabled = false;

            cmbAns1.Items.Clear();
            cmbAns2.Items.Clear();
            cmbAns3.Items.Clear();
            cmbAns4.Items.Clear();
            idBox1.Clear();
            idBox2.Clear();
            idBox3.Clear();
            idBox4.Clear();

            aryAnswers.Clear();
            timer1.Stop();
        }
    }
}
