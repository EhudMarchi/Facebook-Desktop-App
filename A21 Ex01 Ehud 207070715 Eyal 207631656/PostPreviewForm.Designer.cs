using System;

namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public partial class PostPreviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostPreviewForm));
            this.labelPostName = new System.Windows.Forms.Label();
            this.pictureBoxPostImage = new System.Windows.Forms.PictureBox();
            this.richTextBoxPost = new System.Windows.Forms.RichTextBox();
            this.labelLikes = new System.Windows.Forms.Label();
            this.buttonLike = new System.Windows.Forms.Button();
            this.labelComment = new System.Windows.Forms.Label();
            this.buttonSendComment = new System.Windows.Forms.Button();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
            this.labelComments = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPostName
            // 
            this.labelPostName.AutoSize = true;
            this.labelPostName.BackColor = System.Drawing.Color.Transparent;
            this.labelPostName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostName.ForeColor = System.Drawing.Color.White;
            this.labelPostName.Location = new System.Drawing.Point(322, 19);
            this.labelPostName.Name = "labelPostName";
            this.labelPostName.Size = new System.Drawing.Size(0, 27);
            this.labelPostName.TabIndex = 1;
            // 
            // pictureBoxPostImage
            // 
            this.pictureBoxPostImage.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPostImage.Location = new System.Drawing.Point(21, 86);
            this.pictureBoxPostImage.Name = "pictureBoxPostImage";
            this.pictureBoxPostImage.Size = new System.Drawing.Size(301, 289);
            this.pictureBoxPostImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPostImage.TabIndex = 0;
            this.pictureBoxPostImage.TabStop = false;
            this.pictureBoxPostImage.Click += new System.EventHandler(this.pictureBoxPostImage_Click);
            // 
            // richTextBoxPost
            // 
            this.richTextBoxPost.BackColor = System.Drawing.Color.White;
            this.richTextBoxPost.Location = new System.Drawing.Point(359, 86);
            this.richTextBoxPost.Name = "richTextBoxPost";
            this.richTextBoxPost.ReadOnly = true;
            this.richTextBoxPost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBoxPost.Size = new System.Drawing.Size(443, 180);
            this.richTextBoxPost.TabIndex = 2;
            this.richTextBoxPost.Text = String.Empty;
            // 
            // labelLikes
            // 
            this.labelLikes.AutoSize = true;
            this.labelLikes.BackColor = System.Drawing.Color.Transparent;
            this.labelLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikes.Location = new System.Drawing.Point(449, 276);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(60, 20);
            this.labelLikes.TabIndex = 3;
            this.labelLikes.Text = "Likes:";
            // 
            // buttonLike
            // 
            this.buttonLike.Location = new System.Drawing.Point(359, 272);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(69, 30);
            this.buttonLike.TabIndex = 4;
            this.buttonLike.Text = "Like";
            this.buttonLike.UseVisualStyleBackColor = true;
            this.buttonLike.Click += new System.EventHandler(this.buttonLike_Click);
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.BackColor = System.Drawing.Color.Transparent;
            this.labelComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelComment.Location = new System.Drawing.Point(355, 446);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(88, 20);
            this.labelComment.TabIndex = 6;
            this.labelComment.Text = "Comment";
            this.labelComment.Click += new System.EventHandler(this.labelComment_Click);
            // 
            // buttonSendComment
            // 
            this.buttonSendComment.Location = new System.Drawing.Point(733, 439);
            this.buttonSendComment.Name = "buttonSendComment";
            this.buttonSendComment.Size = new System.Drawing.Size(68, 24);
            this.buttonSendComment.TabIndex = 7;
            this.buttonSendComment.Text = "Send";
            this.buttonSendComment.UseVisualStyleBackColor = true;
            this.buttonSendComment.Click += new System.EventHandler(this.buttonSendComment_Click);
            // 
            // listBoxComments
            // 
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.ItemHeight = 16;
            this.listBoxComments.Location = new System.Drawing.Point(360, 333);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(442, 100);
            this.listBoxComments.TabIndex = 8;
            // 
            // richTextBoxComment
            // 
            this.richTextBoxComment.Location = new System.Drawing.Point(359, 469);
            this.richTextBoxComment.Name = "richTextBoxComment";
            this.richTextBoxComment.Size = new System.Drawing.Size(442, 72);
            this.richTextBoxComment.TabIndex = 9;
            this.richTextBoxComment.Text = String.Empty;
            this.richTextBoxComment.TextChanged += new System.EventHandler(this.richTextBoxComment_TextChanged);
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.BackColor = System.Drawing.Color.Transparent;
            this.labelComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelComments.Location = new System.Drawing.Point(356, 310);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(98, 20);
            this.labelComments.TabIndex = 10;
            this.labelComments.Text = "Comments";
            // 
            // PostPreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.labelComments);
            this.Controls.Add(this.richTextBoxComment);
            this.Controls.Add(this.listBoxComments);
            this.Controls.Add(this.buttonSendComment);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.labelLikes);
            this.Controls.Add(this.richTextBoxPost);
            this.Controls.Add(this.labelPostName);
            this.Controls.Add(this.pictureBoxPostImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PostPreviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PostPreviewForm";
            this.Load += new System.EventHandler(this.PostPreviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPostImage;
        private System.Windows.Forms.Label labelPostName;
        private System.Windows.Forms.RichTextBox richTextBoxPost;
        private System.Windows.Forms.Label labelLikes;
        private System.Windows.Forms.Button buttonLike;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Button buttonSendComment;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.RichTextBox richTextBoxComment;
        private System.Windows.Forms.Label labelComments;
    }
}