namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public partial class AlbumSlideShow
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
            this.buttonMute = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMute
            // 
            this.buttonMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMute.Location = new System.Drawing.Point(12, 12);
            this.buttonMute.Name = "buttonMute";
            this.buttonMute.Size = new System.Drawing.Size(75, 28);
            this.buttonMute.TabIndex = 0;
            this.buttonMute.Text = "Mute";
            this.buttonMute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMute.UseVisualStyleBackColor = true;
            this.buttonMute.Click += new System.EventHandler(this.buttonMute_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Location = new System.Drawing.Point(12, 46);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(75, 28);
            this.buttonRestart.TabIndex = 1;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // AlbumSlideShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonMute);
            this.MaximizeBox = false;
            this.Name = "AlbumSlideShow";
            this.Text = "AlbumSlideShow";
            this.Load += new System.EventHandler(this.AlbumSlideShow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMute;
        private System.Windows.Forms.Button buttonRestart;
    }
}