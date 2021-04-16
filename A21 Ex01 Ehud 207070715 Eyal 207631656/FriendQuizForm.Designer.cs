namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public partial class FriendQuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendQuizForm));
            this.labelQuestionNum = new System.Windows.Forms.Label();
            this.progressBarQuestions = new System.Windows.Forms.ProgressBar();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonOption1 = new System.Windows.Forms.Button();
            this.buttonOption2 = new System.Windows.Forms.Button();
            this.buttonOption3 = new System.Windows.Forms.Button();
            this.buttonOption4 = new System.Windows.Forms.Button();
            this.pictureBoxFriendPhoto = new System.Windows.Forms.PictureBox();
            this.labelHeadline = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelTimeLeft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelQuestionNum
            // 
            this.labelQuestionNum.AutoSize = true;
            this.labelQuestionNum.BackColor = System.Drawing.Color.Transparent;
            this.labelQuestionNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelQuestionNum.ForeColor = System.Drawing.Color.White;
            this.labelQuestionNum.Location = new System.Drawing.Point(326, 52);
            this.labelQuestionNum.Name = "labelQuestionNum";
            this.labelQuestionNum.Size = new System.Drawing.Size(116, 29);
            this.labelQuestionNum.TabIndex = 0;
            this.labelQuestionNum.Text = "Question ";
            // 
            // progressBarQuestions
            // 
            this.progressBarQuestions.BackColor = System.Drawing.Color.White;
            this.progressBarQuestions.Location = new System.Drawing.Point(268, 84);
            this.progressBarQuestions.Name = "progressBarQuestions";
            this.progressBarQuestions.Size = new System.Drawing.Size(250, 36);
            this.progressBarQuestions.TabIndex = 1;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.BackColor = System.Drawing.Color.White;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelQuestion.Location = new System.Drawing.Point(138, 181);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(0, 25);
            this.labelQuestion.TabIndex = 2;
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonOption1
            // 
            this.buttonOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonOption1.Location = new System.Drawing.Point(89, 300);
            this.buttonOption1.Name = "buttonOption1";
            this.buttonOption1.Size = new System.Drawing.Size(288, 73);
            this.buttonOption1.TabIndex = 3;
            this.buttonOption1.UseVisualStyleBackColor = true;
            this.buttonOption1.Click += new System.EventHandler(this.buttonOption1_Click);
            // 
            // buttonOption2
            // 
            this.buttonOption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonOption2.Location = new System.Drawing.Point(417, 300);
            this.buttonOption2.Name = "buttonOption2";
            this.buttonOption2.Size = new System.Drawing.Size(288, 73);
            this.buttonOption2.TabIndex = 4;
            this.buttonOption2.UseVisualStyleBackColor = true;
            this.buttonOption2.Click += new System.EventHandler(this.buttonOption2_Click);
            // 
            // buttonOption3
            // 
            this.buttonOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonOption3.Location = new System.Drawing.Point(89, 411);
            this.buttonOption3.Name = "buttonOption3";
            this.buttonOption3.Size = new System.Drawing.Size(288, 73);
            this.buttonOption3.TabIndex = 5;
            this.buttonOption3.UseVisualStyleBackColor = true;
            this.buttonOption3.Click += new System.EventHandler(this.buttonOption3_Click);
            // 
            // buttonOption4
            // 
            this.buttonOption4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonOption4.Location = new System.Drawing.Point(417, 411);
            this.buttonOption4.Name = "buttonOption4";
            this.buttonOption4.Size = new System.Drawing.Size(288, 73);
            this.buttonOption4.TabIndex = 6;
            this.buttonOption4.UseVisualStyleBackColor = true;
            this.buttonOption4.Click += new System.EventHandler(this.buttonOption4_Click);
            // 
            // pictureBoxFriendPhoto
            // 
            this.pictureBoxFriendPhoto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFriendPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFriendPhoto.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxFriendPhoto.Name = "pictureBoxFriendPhoto";
            this.pictureBoxFriendPhoto.Size = new System.Drawing.Size(102, 94);
            this.pictureBoxFriendPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFriendPhoto.TabIndex = 7;
            this.pictureBoxFriendPhoto.TabStop = false;
            // 
            // labelHeadline
            // 
            this.labelHeadline.AutoSize = true;
            this.labelHeadline.BackColor = System.Drawing.Color.Transparent;
            this.labelHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHeadline.ForeColor = System.Drawing.Color.White;
            this.labelHeadline.Location = new System.Drawing.Point(226, 9);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(240, 25);
            this.labelHeadline.TabIndex = 8;
            this.labelHeadline.Text = "How Well Do You Know";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.Color.White;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelResult.Location = new System.Drawing.Point(344, 501);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 25);
            this.labelResult.TabIndex = 9;
            // 
            // labelTimeLeft
            // 
            this.labelTimeLeft.AutoSize = true;
            this.labelTimeLeft.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTimeLeft.ForeColor = System.Drawing.Color.White;
            this.labelTimeLeft.Location = new System.Drawing.Point(673, 9);
            this.labelTimeLeft.Name = "labelTimeLeft";
            this.labelTimeLeft.Size = new System.Drawing.Size(0, 38);
            this.labelTimeLeft.TabIndex = 10;
            // 
            // FriendQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.labelTimeLeft);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelHeadline);
            this.Controls.Add(this.pictureBoxFriendPhoto);
            this.Controls.Add(this.buttonOption4);
            this.Controls.Add(this.buttonOption3);
            this.Controls.Add(this.buttonOption2);
            this.Controls.Add(this.buttonOption1);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.progressBarQuestions);
            this.Controls.Add(this.labelQuestionNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FriendQuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FriendQuizForm";
            this.Load += new System.EventHandler(this.FriendQuizForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestionNum;
        private System.Windows.Forms.ProgressBar progressBarQuestions;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button buttonOption1;
        private System.Windows.Forms.Button buttonOption2;
        private System.Windows.Forms.Button buttonOption3;
        private System.Windows.Forms.Button buttonOption4;
        private System.Windows.Forms.PictureBox pictureBoxFriendPhoto;
        private System.Windows.Forms.Label labelHeadline;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelTimeLeft;
    }
}