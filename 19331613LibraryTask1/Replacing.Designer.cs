
namespace _19331613LibraryTask1
{
    partial class Replacing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.listSort = new System.Windows.Forms.ListBox();
            this.Up = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMed = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Enabled = false;
            this.btnFinish.Location = new System.Drawing.Point(408, 438);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.button2_Click);
            // 
            // listSort
            // 
            this.listSort.Enabled = false;
            this.listSort.FormattingEnabled = true;
            this.listSort.ItemHeight = 15;
            this.listSort.Location = new System.Drawing.Point(150, 202);
            this.listSort.Name = "listSort";
            this.listSort.Size = new System.Drawing.Size(243, 334);
            this.listSort.TabIndex = 3;
            // 
            // Up
            // 
            this.Up.Enabled = false;
            this.Up.Location = new System.Drawing.Point(408, 224);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(75, 23);
            this.Up.TabIndex = 4;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Down
            // 
            this.Down.Enabled = false;
            this.Down.Location = new System.Drawing.Point(408, 306);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(75, 23);
            this.Down.TabIndex = 5;
            this.Down.Text = "Down";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.Location = new System.Drawing.Point(88, 99);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(104, 23);
            this.btnEasy.TabIndex = 6;
            this.btnEasy.Text = "Easy (10 Books)";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMed
            // 
            this.btnMed.Location = new System.Drawing.Point(207, 99);
            this.btnMed.Name = "btnMed";
            this.btnMed.Size = new System.Drawing.Size(131, 23);
            this.btnMed.TabIndex = 7;
            this.btnMed.Text = "Medium (15 Books)";
            this.btnMed.UseVisualStyleBackColor = true;
            this.btnMed.Click += new System.EventHandler(this.btnMed_Click);
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(356, 99);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(103, 23);
            this.btnHard.TabIndex = 8;
            this.btnHard.Text = "Hard (20 Books)";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(104, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Start or restart the game by selecting a difficulty :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(84, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Order the books in ascending order (smallest value on the top)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-10, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(607, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(190, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Replacing books";
            // 
            // Replacing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 663);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMed);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.listSort);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.button1);
            this.Name = "Replacing";
            this.Text = "Replacing";
            this.Load += new System.EventHandler(this.Replacing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ListBox listSort;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMed;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}