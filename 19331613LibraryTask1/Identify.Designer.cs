
namespace _19331613LibraryTask1
{
    partial class Identify
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.idBox1 = new System.Windows.Forms.TextBox();
            this.idBox2 = new System.Windows.Forms.TextBox();
            this.idBox3 = new System.Windows.Forms.TextBox();
            this.idBox4 = new System.Windows.Forms.TextBox();
            this.cmbAns1 = new System.Windows.Forms.ComboBox();
            this.cmbAns2 = new System.Windows.Forms.ComboBox();
            this.cmbAns3 = new System.Windows.Forms.ComboBox();
            this.cmbAns4 = new System.Windows.Forms.ComboBox();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(188, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indentify areas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // idBox1
            // 
            this.idBox1.Location = new System.Drawing.Point(128, 265);
            this.idBox1.Name = "idBox1";
            this.idBox1.ReadOnly = true;
            this.idBox1.Size = new System.Drawing.Size(100, 23);
            this.idBox1.TabIndex = 3;
            // 
            // idBox2
            // 
            this.idBox2.Location = new System.Drawing.Point(128, 310);
            this.idBox2.Name = "idBox2";
            this.idBox2.ReadOnly = true;
            this.idBox2.Size = new System.Drawing.Size(100, 23);
            this.idBox2.TabIndex = 4;
            // 
            // idBox3
            // 
            this.idBox3.Location = new System.Drawing.Point(128, 351);
            this.idBox3.Name = "idBox3";
            this.idBox3.ReadOnly = true;
            this.idBox3.Size = new System.Drawing.Size(100, 23);
            this.idBox3.TabIndex = 5;
            // 
            // idBox4
            // 
            this.idBox4.Location = new System.Drawing.Point(128, 390);
            this.idBox4.Name = "idBox4";
            this.idBox4.ReadOnly = true;
            this.idBox4.Size = new System.Drawing.Size(100, 23);
            this.idBox4.TabIndex = 6;
            // 
            // cmbAns1
            // 
            this.cmbAns1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAns1.Enabled = false;
            this.cmbAns1.FormattingEnabled = true;
            this.cmbAns1.Location = new System.Drawing.Point(327, 265);
            this.cmbAns1.Name = "cmbAns1";
            this.cmbAns1.Size = new System.Drawing.Size(121, 23);
            this.cmbAns1.TabIndex = 7;
            // 
            // cmbAns2
            // 
            this.cmbAns2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAns2.Enabled = false;
            this.cmbAns2.FormattingEnabled = true;
            this.cmbAns2.Location = new System.Drawing.Point(327, 310);
            this.cmbAns2.Name = "cmbAns2";
            this.cmbAns2.Size = new System.Drawing.Size(121, 23);
            this.cmbAns2.TabIndex = 8;
            // 
            // cmbAns3
            // 
            this.cmbAns3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAns3.Enabled = false;
            this.cmbAns3.FormattingEnabled = true;
            this.cmbAns3.Location = new System.Drawing.Point(327, 351);
            this.cmbAns3.Name = "cmbAns3";
            this.cmbAns3.Size = new System.Drawing.Size(121, 23);
            this.cmbAns3.TabIndex = 9;
            // 
            // cmbAns4
            // 
            this.cmbAns4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAns4.Enabled = false;
            this.cmbAns4.FormattingEnabled = true;
            this.cmbAns4.Location = new System.Drawing.Point(327, 390);
            this.cmbAns4.Name = "cmbAns4";
            this.cmbAns4.Size = new System.Drawing.Size(121, 23);
            this.cmbAns4.TabIndex = 10;
            // 
            // btnIdentify
            // 
            this.btnIdentify.Enabled = false;
            this.btnIdentify.Location = new System.Drawing.Point(234, 473);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(75, 23);
            this.btnIdentify.TabIndex = 11;
            this.btnIdentify.Text = "Check";
            this.btnIdentify.UseVisualStyleBackColor = true;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(229, 159);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(234, 533);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 14;
            this.btnEnd.Text = "End/Reset";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(229, 214);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(39, 15);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "Time :";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.Location = new System.Drawing.Point(131, 109);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(75, 23);
            this.btnEasy.TabIndex = 16;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(231, 109);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(75, 23);
            this.btnMedium.TabIndex = 17;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(327, 109);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(75, 23);
            this.btnHard.TabIndex = 18;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(613, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-19, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(613, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(119, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Select a difficulty , then click start to begin";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 628);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Identify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 663);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnIdentify);
            this.Controls.Add(this.cmbAns4);
            this.Controls.Add(this.cmbAns3);
            this.Controls.Add(this.cmbAns2);
            this.Controls.Add(this.cmbAns1);
            this.Controls.Add(this.idBox4);
            this.Controls.Add(this.idBox3);
            this.Controls.Add(this.idBox2);
            this.Controls.Add(this.idBox1);
            this.Controls.Add(this.label1);
            this.Name = "Identify";
            this.Text = "Identify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idBox1;
        private System.Windows.Forms.TextBox idBox2;
        private System.Windows.Forms.TextBox idBox3;
        private System.Windows.Forms.TextBox idBox4;
        private System.Windows.Forms.ComboBox cmbAns1;
        private System.Windows.Forms.ComboBox cmbAns2;
        private System.Windows.Forms.ComboBox cmbAns3;
        private System.Windows.Forms.ComboBox cmbAns4;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
    }
}