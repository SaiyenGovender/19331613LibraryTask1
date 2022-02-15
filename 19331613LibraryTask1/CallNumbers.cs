using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace _19331613LibraryTask1
{
    public partial class CallNumbers : Form
    {
        ArrayList aryParents = new ArrayList();     // first level
        ArrayList aryChild = new ArrayList();        // second level
        ArrayList aryLeaf = new ArrayList();        // third level
        ArrayList aryOptions = new ArrayList();
        Node root = addNode("Dewey decimals");
        string checkAnswer = "";
        string diff = "";
        public int curlevel = 1;
        public string curAns;   // gets                  
        public string curQ;      // gets and hold current question descriptions

        public class Node   // holds a node of n-ary tree type
        {
            public string key;
            public List<Node> child = new List<Node>();
        }

        static Node addNode(string key) // adds new node to tree
        {
            Node temp = new Node();
            temp.key = key;
            return temp;
        }
        static ArrayList LevelTraversal(Node root, int level) // returns tree level values
        {
            ArrayList arygroup = new ArrayList();
            int counter = 0;

            Queue<Node> que = new Queue<Node>();
            que.Enqueue(root);
            while (que.Count != 0)
            {
                int n = que.Count;

                while (n > 0)       // if selcetd node is child
                {
                    Node p = que.Peek();
                    que.Dequeue();
                    arygroup.Add(p.key);

                    for (int i = 0; i < p.child.Count; i++)
                    {
                        que.Enqueue(p.child[i]);
                    }
                        n = n - 1;
                    
                }

                counter++;
                if (level == 2)             // if parent(1st level) level is added to arygroup
                {
                    if (counter == 2)
                    {
                        return arygroup;
                    }
                }
                if (level == 3)             // if child(2nd level) level is added to arygroup
                {
                    if (counter == 3)
                    {
                        return arygroup;
                    }
                }
                if (level == 4)             // if leaf(3rd levl) level is added to arygroup
                {
                    if (counter == 4)
                    {
                        return arygroup;
                    }
                }

                arygroup.Clear();
            }

            return arygroup;
        }
        public CallNumbers()
        {
            InitializeComponent();

            if (!File.Exists("Dewey.txt"))
            {
                MessageBox.Show("File could not be found ,Dewey.txt file can be found in zipped folder , please add Dewey.txt to debug directry");
                Environment.Exit(0);
            }

            char pos1;
            char pos2;
            int nodepos1;
            int nodepos2;
            string[] textfile = File.ReadAllLines("Dewey.txt");

            foreach (string line in textfile)
            {
                if (line.Contains("parent"))        // check selected line if its a parent nodes  1st level
                {
                    root.child.Add(addNode(line.TrimEnd('p', 'a', 'r', 'e', 'n', 't')));
                  //  MessageBox.Show(line);
                }
                if (line.Contains("child"))          // check selected line if its a child nodes 2nd level
                {
                    pos1 = line[0];
                    nodepos1 = pos1 - '0';
                    root.child[nodepos1].child.Add(addNode(line.TrimEnd('c', 'h', 'i', 'l', 'd')));
                }
                if (line.Contains("leaf"))           // check selected line if its a leaf nodes 3rd level
                {
                    pos1 = line[0];
                    pos2 = line[1];
                    nodepos1 = pos1 - '0';
                    nodepos2 = pos2 - '0';
                    root.child[nodepos1].child[nodepos2].child.Add(addNode(line.TrimEnd('l', 'e', 'a', 'f')));
                }
            }
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 home = new Form1();
            home.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnEasy.Enabled = false;
            btnMedium.Enabled = false;
            btnHard.Enabled = false;
            btnStart.Enabled = false;
            btnCheck.Enabled = true;
            btnEnd.Enabled = true;
            aryOptions.Clear();
            lbAns.Items.Clear();
            aryParents = LevelTraversal(root, 2);
            aryChild = LevelTraversal(root, 3);
            aryLeaf = LevelTraversal(root, 4);

            Random random = new Random();
           // int curLvl = 0;
            int Qselect;
         
            string option1 = null;
            string option2 = null;
            string option3 = null;
            string option4 = null;
            string option5 = null;
            string curLvlQ;
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;

            if (curlevel == 1)
            {
                Qselect = random.Next(aryLeaf.Count);  // number used to get positon of random leaf array value
                curQ = aryLeaf[Qselect].ToString().Remove(0, 4);  // gets the leafs description only for display
                curAns = aryLeaf[Qselect].ToString();
            }          
            label4.Text = "Select the correct call number and description that \n" + curQ + " falls under ";
            if (curlevel == 1)
            {
                curLvlQ = curAns.Substring(0, 1);       // gets the selected leaf questions first number from its call number             
                for (int i = 0; i < aryParents.Count; i++)
                {
                    if (aryParents[i].ToString().Substring(0, 1).Equals(curLvlQ))    // checks the first number against the curAns first number in its call numbers
                    {
                        aryOptions.Add(aryParents[i]);          // adds answers call number and description to the current question
                        checkAnswer = aryParents[i].ToString();
                        num1 = i;                               // integer value taken to make sure its not randomly picked
                    }
                }
                num2 = random.Next(0, aryParents.Count);            //gets random numbers
                num3 = random.Next(0, aryParents.Count);
                num4 = random.Next(0, aryParents.Count);
                num5 = random.Next(0, aryParents.Count);
                num6 = random.Next(0, aryParents.Count);
                while (num2 == num1)                                // ensures random numbers are not the same
                {
                    num2 = random.Next(0, aryParents.Count);
                }
                while (num3 == num1 || num3 == num2)
                {
                    num3 = random.Next(0, aryParents.Count);
                }
                while (num4 == num1 || num4 == num2 || num4 == num3)
                {
                    num4 = random.Next(0, aryParents.Count);
                }
                while (num5 == num1 || num5 == num2 || num5 == num3 || num5 == num4)
                {
                    num5 = random.Next(0, aryParents.Count);
                }
                while (num6 == num1 || num6 == num2 || num6 == num3 || num6 == num4 || num6 == num5)
                {
                    num6 = random.Next(0, aryParents.Count);
                }
                option1 = aryParents[num2].ToString();              //gets random unique values from first level array and stores them in option array
                aryOptions.Add(option1);
                option2 = aryParents[num3].ToString();
                aryOptions.Add(option2);
                option3 = aryParents[num4].ToString();
                aryOptions.Add(option3);
                if (diff.Equals("Medium"))
                {
                    option4 = aryParents[num5].ToString();
                    aryOptions.Add(option4);
                }
               if (diff.Equals("Hard"))
                {
                    option4 = aryParents[num5].ToString();
                    aryOptions.Add(option4);
                    option5 = aryParents[num6].ToString();
                    aryOptions.Add(option5);
                }
            }
            if (curlevel == 2)
            {
                string curSameLvl;
                curLvlQ = curAns.Substring(0, 2);                   // gets the selected leaf questions first two number from its call number
                curSameLvl = curAns.Substring(0, 1);          
                for (int i = 0; i < aryChild.Count; i++)
                {
                    if (aryChild[i].ToString().Substring(0,2).Equals(curLvlQ))            // checks the first two numbers against the curAns first two number in its call numbers
                    {
                        aryOptions.Add(aryChild[i]);
                        checkAnswer = aryChild[i].ToString();
                        num1 = i;
                    }
                }
                num2 = random.Next(0, aryChild.Count);                              //gets random numbers
                num3 = random.Next(0, aryChild.Count);
                num4 = random.Next(0, aryChild.Count);
                num5 = random.Next(0, aryChild.Count);
                num6 = random.Next(0, aryChild.Count);
                while (num2 == num1 || !curSameLvl.Equals(aryChild[num2].ToString().Substring(0,1)))                                                // ensures random numbers are not the same
                {
                    num2 = random.Next(0, aryChild.Count);
                }
                while (num3 == num1 || num3 == num2 || !curSameLvl.Equals(aryChild[num3].ToString().Substring(0, 1)))
                {
                    num3 = random.Next(0, aryChild.Count);
                }
                while (num4 == num1 || num4 == num2 || num4 == num3 || !curSameLvl.Equals(aryChild[num4].ToString().Substring(0, 1)))
                {
                    num4 = random.Next(0, aryChild.Count);
                }
                while (num5 == num1 || num5 == num2 || num5 == num3 || num5 == num4 || !curSameLvl.Equals(aryChild[num5].ToString().Substring(0, 1)))
                {
                    num5 = random.Next(0, aryChild.Count);
                }
                while (num6 == num1 || num6 == num2 || num6 == num3 || num6 == num4 || num6 == num5 || !curSameLvl.Equals(aryChild[num6].ToString().Substring(0, 1)))
                {
                    num6 = random.Next(0, aryChild.Count);
                }
                option1 = aryChild[num2].ToString();                        //gets random unique values from first level array and stores them in option array
                aryOptions.Add(option1);
                option2 = aryChild[num3].ToString();
                aryOptions.Add(option2);
                option3 = aryChild[num4].ToString();
                aryOptions.Add(option3);
                if (diff.Equals("Medium"))
                {
                    option4 = aryChild[num5].ToString();
                    aryOptions.Add(option4);
                }
                if (diff.Equals("Hard"))
                {
                    option4 = aryChild[num5].ToString();
                    aryOptions.Add(option4);
                    option5 = aryChild[num6].ToString();
                    aryOptions.Add(option5);
                }

            }
            if (curlevel == 3)
            {
                //   curAns = aryLeaf[Qselect].ToString().Substring(0, 3);                   // gets the selected leaf questions first two number from its call number
                string curSameLvl;
                curLvlQ = curAns.Substring(0, 3);
                curSameLvl = curAns.Substring(0, 2);
                for (int i = 0; i < aryLeaf.Count; i++)
                {
                    if (aryLeaf[i].ToString().Substring(0, 3).Equals(curLvlQ))            // checks the first two numbers against the curAns first two number in its call numbers
                    {
                        aryOptions.Add(aryLeaf[i].ToString().Substring(0, 3));
                        checkAnswer = aryLeaf[i].ToString().Substring(0, 3);
                        num1 = i;
                    }
                }
                num2 = random.Next(0, aryLeaf.Count);                              //gets random numbers
                num3 = random.Next(0, aryLeaf.Count);
                num4 = random.Next(0, aryLeaf.Count);
                num5 = random.Next(0, aryLeaf.Count);
                num6 = random.Next(0, aryLeaf.Count);
                while (num2 == num1 || !curSameLvl.Equals(aryLeaf[num2].ToString().Substring(0, 2)))                                                // ensures random numbers are not the same
                {
                    num2 = random.Next(0, aryLeaf.Count);
                }
                while (num3 == num1 || num3 == num2 || !curSameLvl.Equals(aryLeaf[num3].ToString().Substring(0, 2)))
                {
                    num3 = random.Next(0, aryLeaf.Count);
                }
                while (num4 == num1 || num4 == num2 || num4 == num3 || !curSameLvl.Equals(aryLeaf[num4].ToString().Substring(0, 2)))
                {
                    num4 = random.Next(0, aryLeaf.Count);
                }
                while (num5 == num1 || num5 == num2 || num5 == num3 || num5 == num4 || !curSameLvl.Equals(aryLeaf[num5].ToString().Substring(0, 2)))
                {
                    num5 = random.Next(0, aryLeaf.Count);
                }
                while (num6 == num1 || num6 == num2 || num6 == num3 || num6 == num4 || num6 == num5 || !curSameLvl.Equals(aryLeaf[num6].ToString().Substring(0, 2)))
                {
                    num6 = random.Next(0, aryLeaf.Count);
                }
                option1 = aryLeaf[num2].ToString().Substring(0, 3);                        //gets random unique values from first level array and stores them in option array
                aryOptions.Add(option1);
                option2 = aryLeaf[num3].ToString().Substring(0, 3);
                aryOptions.Add(option2);
                option3 = aryLeaf[num4].ToString().Substring(0, 3);
                aryOptions.Add(option3);
                if (diff.Equals("Medium"))
                {
                    option4 = aryLeaf[num5].ToString().Substring(0, 3);
                    aryOptions.Add(option4);
                }
                if (diff.Equals("Hard"))
                {
                    option4 = aryLeaf[num5].ToString().Substring(0, 3);
                    aryOptions.Add(option4);
                    option5 = aryLeaf[num6].ToString().Substring(0, 3);
                    aryOptions.Add(option5);
                }

            }
            aryOptions.Sort();                                          // sorts options by call numbers 
          
            lbAns.Items.AddRange(aryOptions.ToArray());                 // displays options in listbox answers
            MessageBox.Show("Answer is " + checkAnswer);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
            if (lbAns.SelectedItem.Equals(checkAnswer))
            {
                MessageBox.Show("Correct answer!");
                btnEasy.Enabled = false;
                btnMedium.Enabled = false;
                btnHard.Enabled = false;
                btnStart.Enabled = true;
                btnCheck.Enabled = false;
                btnEnd.Enabled = false;
                curlevel++;
                if (curlevel > 3)
                {
                    curlevel = 1;
                    MessageBox.Show("Well done , select a difficulty and press start to get a new question");
                    btnEasy.Enabled = true;
                    btnMedium.Enabled = true;
                    btnHard.Enabled = true;
                    btnStart.Enabled = false;
                    btnCheck.Enabled = false;
                    btnEnd.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Click start to continue to the next level");                    
                }
                lbAns.Items.Clear();
            }
            else
            {
                MessageBox.Show("Wrong answer , the correct answer was " + checkAnswer);
                btnEasy.Enabled = true;
                btnMedium.Enabled = true;
                btnHard.Enabled = true;
                btnStart.Enabled = false;
                btnCheck.Enabled = false;
                curlevel = 1;
                lbAns.Items.Clear();
            }
            
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            diff = "Easy";
            MessageBox.Show("Easy mode selected");
            btnStart.Enabled = true;
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            diff = "Medium";
            MessageBox.Show("Medium mode selected");
            btnStart.Enabled = true;
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            diff = "Hard";
            MessageBox.Show("Hard mode selected");
            btnStart.Enabled = true;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            btnEasy.Enabled = true;
            btnMedium.Enabled = true;
            btnHard.Enabled = true;
            btnStart.Enabled = true;
            btnCheck.Enabled = false;
            btnCheck.Enabled = false;
            btnEnd.Enabled = false;
            lbAns.Items.Clear();
        }
    }
}
