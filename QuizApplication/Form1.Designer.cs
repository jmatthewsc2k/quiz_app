namespace QuizApplication
{
    partial class Form1
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
            this.lbScores = new System.Windows.Forms.Label();
            this.gbQ1 = new System.Windows.Forms.GroupBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbCorrectQM = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.rbAns4 = new System.Windows.Forms.RadioButton();
            this.rbAns3 = new System.Windows.Forms.RadioButton();
            this.rbAns2 = new System.Windows.Forms.RadioButton();
            this.rbAns1 = new System.Windows.Forms.RadioButton();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.lbWordQuestion = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.btnGoAgain = new System.Windows.Forms.Button();
            this.lbNotScores = new System.Windows.Forms.Label();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.btnNextTo2 = new System.Windows.Forms.Button();
            this.gbQ1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbScores
            // 
            this.lbScores.AutoSize = true;
            this.lbScores.Location = new System.Drawing.Point(573, 27);
            this.lbScores.Name = "lbScores";
            this.lbScores.Size = new System.Drawing.Size(43, 13);
            this.lbScores.TabIndex = 0;
            this.lbScores.Text = "Scores:";
            // 
            // gbQ1
            // 
            this.gbQ1.Controls.Add(this.lbTime);
            this.gbQ1.Controls.Add(this.lbCorrectQM);
            this.gbQ1.Controls.Add(this.btnCheck);
            this.gbQ1.Controls.Add(this.rbAns4);
            this.gbQ1.Controls.Add(this.rbAns3);
            this.gbQ1.Controls.Add(this.rbAns2);
            this.gbQ1.Controls.Add(this.rbAns1);
            this.gbQ1.Controls.Add(this.lbQuestion);
            this.gbQ1.Controls.Add(this.lbWordQuestion);
            this.gbQ1.Location = new System.Drawing.Point(42, 66);
            this.gbQ1.Name = "gbQ1";
            this.gbQ1.Size = new System.Drawing.Size(401, 278);
            this.gbQ1.TabIndex = 1;
            this.gbQ1.TabStop = false;
            this.gbQ1.Text = "Question1";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(274, 20);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(33, 13);
            this.lbTime.TabIndex = 7;
            this.lbTime.Text = "Time:";
            // 
            // lbCorrectQM
            // 
            this.lbCorrectQM.AutoSize = true;
            this.lbCorrectQM.Location = new System.Drawing.Point(74, 247);
            this.lbCorrectQM.Name = "lbCorrectQM";
            this.lbCorrectQM.Size = new System.Drawing.Size(47, 13);
            this.lbCorrectQM.TabIndex = 3;
            this.lbCorrectQM.Text = "Correct?";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(77, 212);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(110, 23);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Click to check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // rbAns4
            // 
            this.rbAns4.AutoSize = true;
            this.rbAns4.Location = new System.Drawing.Point(265, 195);
            this.rbAns4.Name = "rbAns4";
            this.rbAns4.Size = new System.Drawing.Size(69, 17);
            this.rbAns4.TabIndex = 5;
            this.rbAns4.TabStop = true;
            this.rbAns4.Text = "Answer 4";
            this.rbAns4.UseVisualStyleBackColor = true;
            // 
            // rbAns3
            // 
            this.rbAns3.AutoSize = true;
            this.rbAns3.Location = new System.Drawing.Point(265, 156);
            this.rbAns3.Name = "rbAns3";
            this.rbAns3.Size = new System.Drawing.Size(69, 17);
            this.rbAns3.TabIndex = 4;
            this.rbAns3.TabStop = true;
            this.rbAns3.Text = "Answer 3";
            this.rbAns3.UseVisualStyleBackColor = true;
            // 
            // rbAns2
            // 
            this.rbAns2.AutoSize = true;
            this.rbAns2.Location = new System.Drawing.Point(265, 113);
            this.rbAns2.Name = "rbAns2";
            this.rbAns2.Size = new System.Drawing.Size(69, 17);
            this.rbAns2.TabIndex = 3;
            this.rbAns2.TabStop = true;
            this.rbAns2.Text = "Answer 2";
            this.rbAns2.UseVisualStyleBackColor = true;
            // 
            // rbAns1
            // 
            this.rbAns1.AutoSize = true;
            this.rbAns1.Location = new System.Drawing.Point(265, 74);
            this.rbAns1.Name = "rbAns1";
            this.rbAns1.Size = new System.Drawing.Size(69, 17);
            this.rbAns1.TabIndex = 2;
            this.rbAns1.TabStop = true;
            this.rbAns1.Text = "Answer 1";
            this.rbAns1.UseVisualStyleBackColor = true;
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Location = new System.Drawing.Point(10, 40);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(105, 13);
            this.lbQuestion.TabIndex = 1;
            this.lbQuestion.Text = "{question goes here}";
            // 
            // lbWordQuestion
            // 
            this.lbWordQuestion.AutoSize = true;
            this.lbWordQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWordQuestion.Location = new System.Drawing.Point(7, 20);
            this.lbWordQuestion.Name = "lbWordQuestion";
            this.lbWordQuestion.Size = new System.Drawing.Size(69, 16);
            this.lbWordQuestion.TabIndex = 0;
            this.lbWordQuestion.Text = "Question";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(244, 27);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(171, 18);
            this.lbWelcome.TabIndex = 2;
            this.lbWelcome.Text = "Welcome to the Quiz!";
            // 
            // btnGoAgain
            // 
            this.btnGoAgain.Location = new System.Drawing.Point(513, 313);
            this.btnGoAgain.Name = "btnGoAgain";
            this.btnGoAgain.Size = new System.Drawing.Size(75, 23);
            this.btnGoAgain.TabIndex = 3;
            this.btnGoAgain.Text = "Go again";
            this.btnGoAgain.UseVisualStyleBackColor = true;
            this.btnGoAgain.Click += new System.EventHandler(this.btnGoAgain_Click);
            // 
            // lbNotScores
            // 
            this.lbNotScores.AutoSize = true;
            this.lbNotScores.Location = new System.Drawing.Point(573, 66);
            this.lbNotScores.Name = "lbNotScores";
            this.lbNotScores.Size = new System.Drawing.Size(63, 13);
            this.lbNotScores.TabIndex = 4;
            this.lbNotScores.Text = "Not Scores:";
            // 
            // tmrTimer
            // 
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // btnNextTo2
            // 
            this.btnNextTo2.Location = new System.Drawing.Point(513, 342);
            this.btnNextTo2.Name = "btnNextTo2";
            this.btnNextTo2.Size = new System.Drawing.Size(103, 23);
            this.btnNextTo2.TabIndex = 5;
            this.btnNextTo2.Text = "Next Question";
            this.btnNextTo2.UseVisualStyleBackColor = true;
            this.btnNextTo2.Click += new System.EventHandler(this.btnNextTo2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 404);
            this.Controls.Add(this.btnNextTo2);
            this.Controls.Add(this.lbNotScores);
            this.Controls.Add(this.btnGoAgain);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.gbQ1);
            this.Controls.Add(this.lbScores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbQ1.ResumeLayout(false);
            this.gbQ1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbScores;
        private System.Windows.Forms.GroupBox gbQ1;
        private System.Windows.Forms.Label lbCorrectQM;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.RadioButton rbAns4;
        private System.Windows.Forms.RadioButton rbAns3;
        private System.Windows.Forms.RadioButton rbAns2;
        private System.Windows.Forms.RadioButton rbAns1;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Label lbWordQuestion;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btnGoAgain;
        private System.Windows.Forms.Label lbNotScores;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btnNextTo2;
    }
}

