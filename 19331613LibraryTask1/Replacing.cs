using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _19331613LibraryTask1
{
    public partial class Replacing : Form
    {
       
        List<string> aryBooks = new List<string>();
       
        int min = 0;
        int max = 9;
       
        string randomNum;
        string randomNum2;
        string auth;
        string book;

        public Replacing()
        {
            InitializeComponent();
            listSort.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form1 home = new Form1();
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean isSorted = true ;

          //  for (int i = 0; i < aryBooks.Count; i++)
          //  {
           //     MessageBox.Show(aryBooks[i]);
         //   }
            //  MessageBox.Show(aryBooks.Count.ToString());
            for (int i = 0; i < aryBooks.Count; i++)
            {
                
                for (int j = 0; j < aryBooks.Count - 1; j++)
                {
                    //the double loop checks one item against each other item e.g checks item[0] against item[1] then item[2] until end of loop
                    if (String.Compare(aryBooks[i], aryBooks[j]) < 0)           // if item is bigger than other item , the item then switches places with that item
                    {
                        
                        string temp = aryBooks[i];                  //stores current item temparoaly
                        aryBooks[i] = aryBooks[j];                  //switchs item i with item j
                        aryBooks[j] = temp;                         //switchs j with temp (item i)
                        
                    }

                }

            }             
            
            
            
            
                int checkCount = 0;
                foreach (string item in listSort.Items)
            {
                if (item.ToString().Equals(aryBooks[checkCount])) 
                {
                    checkCount++;
                }
                else
                {
                    isSorted = false;
                    MessageBox.Show("books was not sorted correctly , try again");
                    return;
                }
            }
            if (isSorted == true)
            {
                MessageBox.Show("books was sorted correctly , well done!");
            }

            //listSort.Items.Add(aryBooks[i]);

            


        }



        private void Up_Click(object sender, EventArgs e)
        {
            if (listSort.SelectedIndex == -1)
            {
                MessageBox.Show("Select an item");
            }
            else
            {
                int newIndex = listSort.SelectedIndex - 1;

                if (newIndex < 0)         
                    return;
              
               object SelectedItem = listSort.SelectedItem;

                listSort.Items.Remove(SelectedItem);

                listSort.Items.Insert(newIndex, SelectedItem);

                listSort.SetSelected(newIndex, true);

               
            }
        }
        
        public void genBooks(int diff)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var random = new Random();

            for (int i = 0; i < diff; i++)
            {
                // format of book call numbers 3 numbers(randomNum) , 2 numbers(randomNum2) and auth first 3 letters(auth)
                randomNum = "";                                                 
                randomNum2 = "";
                auth = "";
                randomNum = random.Next(min, max).ToString();           //adds first random number to 3 number set
                auth = chars[random.Next(chars.Length)].ToString();         //adds first letter to auth 


                for (int j = 0; j < 2; j++)                                     //adds rest of letters /characters to each category
                {
                    randomNum = randomNum + random.Next(min, max).ToString();
                    auth = auth + chars[random.Next(chars.Length)].ToString();
                    randomNum2 = randomNum2 + random.Next(min, max).ToString();
                }

                book = randomNum + "." + randomNum2 + " " + auth;
                //MessageBox.Show(book);
                listSort.Items.Add(book);
                aryBooks.Add(book);
                
                //test[i] = book;
                
            }
        }

        private void Down_Click(object sender, EventArgs e)
        {
            if (listSort.SelectedIndex == -1)
            {
                MessageBox.Show("Select an item");
            }
            else
            {
                int newIndex = listSort.SelectedIndex + 1;
                if (newIndex >= listSort.Items.Count)
                    return;
  
                object SelectedItem = listSort.SelectedItem;

                listSort.Items.Remove(SelectedItem);

                listSort.Items.Insert(newIndex, SelectedItem);

                listSort.SetSelected(newIndex, true);
            }
        }

        private void Replacing_Load(object sender, EventArgs e)
        {

        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            listSort.Enabled = true;        //allows user to interact with list and its buttons
            Up.Enabled = true;
            Down.Enabled = true;
            btnFinish.Enabled = true;
            aryBooks.Clear();
            listSort.Items.Clear();
            genBooks(10);
            //diff = 10;
        }

        private void btnMed_Click(object sender, EventArgs e)
        {
            listSort.Enabled = true;             //allows user to interact with list and its buttons
            Up.Enabled = true;
            Down.Enabled = true;
            btnFinish.Enabled = true;
            aryBooks.Clear();
            listSort.Items.Clear();
            genBooks(15);
          //  diff = 15;
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            listSort.Enabled = true;         //allows user to interact with list and its buttons
            Up.Enabled = true;
            Down.Enabled = true;
            btnFinish.Enabled = true;
            aryBooks.Clear();
            listSort.Items.Clear();
            genBooks(20);
          //  diff = 20;
        }

        private void button3_Click(object sender, EventArgs e)
        {
         // for (int i = 0; i < aryBooks.Count; i++)
         //   {
         //       MessageBox.Show(aryBooks[i]);
         //   }
        }
    }
}
