namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public partial class AlbumViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumViewerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxAlbums = new System.Windows.Forms.ComboBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.labelExplain = new System.Windows.Forms.Label();
            this.buttonSlideShow = new System.Windows.Forms.Button();
            this.buttonAddAlbum = new System.Windows.Forms.Button();
            this.listBoxSelectedAlbums = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonSlideShowSelected = new System.Windows.Forms.Button();
            this.labelAlbumCollection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(568, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "Albums";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(827, 525);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 184);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBoxAlbums
            // 
            this.comboBoxAlbums.FormattingEnabled = true;
            this.comboBoxAlbums.Location = new System.Drawing.Point(522, 57);
            this.comboBoxAlbums.Name = "comboBoxAlbums";
            this.comboBoxAlbums.Size = new System.Drawing.Size(246, 24);
            this.comboBoxAlbums.TabIndex = 12;
            this.comboBoxAlbums.Text = "Choose Album...";
            this.comboBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlbums_SelectedIndexChanged);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.SystemColors.Control;
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(1026, 35);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(92, 46);
            this.buttonNext.TabIndex = 23;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPrevious.Enabled = false;
            this.buttonPrevious.Location = new System.Drawing.Point(168, 35);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(92, 46);
            this.buttonPrevious.TabIndex = 24;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(495, 525);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 184);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(168, 525);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(291, 184);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(827, 313);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(291, 184);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(495, 313);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(291, 184);
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Location = new System.Drawing.Point(168, 313);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(291, 184);
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Location = new System.Drawing.Point(827, 101);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(291, 184);
            this.pictureBox7.TabIndex = 30;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Location = new System.Drawing.Point(495, 101);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(291, 184);
            this.pictureBox8.TabIndex = 31;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Location = new System.Drawing.Point(168, 101);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(291, 184);
            this.pictureBox9.TabIndex = 32;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // labelExplain
            // 
            this.labelExplain.AutoSize = true;
            this.labelExplain.BackColor = System.Drawing.Color.Transparent;
            this.labelExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelExplain.Location = new System.Drawing.Point(518, 724);
            this.labelExplain.Name = "labelExplain";
            this.labelExplain.Size = new System.Drawing.Size(229, 20);
            this.labelExplain.TabIndex = 34;
            this.labelExplain.Text = "Click on photo to see full size";
            this.labelExplain.Visible = false;
            // 
            // buttonSlideShow
            // 
            this.buttonSlideShow.BackColor = System.Drawing.Color.Yellow;
            this.buttonSlideShow.Enabled = false;
            this.buttonSlideShow.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonSlideShow.Location = new System.Drawing.Point(800, 16);
            this.buttonSlideShow.Name = "buttonSlideShow";
            this.buttonSlideShow.Size = new System.Drawing.Size(150, 75);
            this.buttonSlideShow.TabIndex = 37;
            this.buttonSlideShow.Text = "Slide Show";
            this.buttonSlideShow.UseVisualStyleBackColor = false;
            this.buttonSlideShow.Click += new System.EventHandler(this.buttonSlideShow_Click);
            // 
            // buttonAddAlbum
            // 
            this.buttonAddAlbum.Location = new System.Drawing.Point(12, 421);
            this.buttonAddAlbum.Name = "buttonAddAlbum";
            this.buttonAddAlbum.Size = new System.Drawing.Size(146, 23);
            this.buttonAddAlbum.TabIndex = 39;
            this.buttonAddAlbum.Text = "Add Album";
            this.buttonAddAlbum.UseVisualStyleBackColor = true;
            this.buttonAddAlbum.Click += new System.EventHandler(this.buttonAddAlbum_Click);
            // 
            // listBoxSelectedAlbums
            // 
            this.listBoxSelectedAlbums.FormattingEnabled = true;
            this.listBoxSelectedAlbums.ItemHeight = 16;
            this.listBoxSelectedAlbums.Location = new System.Drawing.Point(12, 347);
            this.listBoxSelectedAlbums.Name = "listBoxSelectedAlbums";
            this.listBoxSelectedAlbums.Size = new System.Drawing.Size(146, 68);
            this.listBoxSelectedAlbums.TabIndex = 40;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(12, 450);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(146, 23);
            this.buttonRemove.TabIndex = 41;
            this.buttonRemove.Text = "Remove Album";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonSlideShowSelected
            // 
            this.buttonSlideShowSelected.BackColor = System.Drawing.Color.Yellow;
            this.buttonSlideShowSelected.Enabled = false;
            this.buttonSlideShowSelected.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSlideShowSelected.Location = new System.Drawing.Point(8, 479);
            this.buttonSlideShowSelected.Name = "buttonSlideShowSelected";
            this.buttonSlideShowSelected.Size = new System.Drawing.Size(150, 83);
            this.buttonSlideShowSelected.TabIndex = 42;
            this.buttonSlideShowSelected.Text = "Collection Slide Show";
            this.buttonSlideShowSelected.UseVisualStyleBackColor = false;
            this.buttonSlideShowSelected.Click += new System.EventHandler(this.buttonSlideShowSelected_Click);
            // 
            // labelAlbumCollection
            // 
            this.labelAlbumCollection.AutoSize = true;
            this.labelAlbumCollection.BackColor = System.Drawing.Color.Transparent;
            this.labelAlbumCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAlbumCollection.ForeColor = System.Drawing.Color.White;
            this.labelAlbumCollection.Location = new System.Drawing.Point(1, 327);
            this.labelAlbumCollection.Name = "labelAlbumCollection";
            this.labelAlbumCollection.Size = new System.Drawing.Size(161, 17);
            this.labelAlbumCollection.TabIndex = 43;
            this.labelAlbumCollection.Text = "My Albums Collection";
            // 
            // AlbumViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.labelAlbumCollection);
            this.Controls.Add(this.buttonSlideShowSelected);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listBoxSelectedAlbums);
            this.Controls.Add(this.buttonAddAlbum);
            this.Controls.Add(this.buttonSlideShow);
            this.Controls.Add(this.labelExplain);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxAlbums);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AlbumViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AlbumViewerForm";
            this.Load += new System.EventHandler(this.AlbumViewerForm_Load);
            this.Controls.SetChildIndex(this.comboBoxAlbums, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.buttonNext, 0);
            this.Controls.SetChildIndex(this.buttonPrevious, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.pictureBox4, 0);
            this.Controls.SetChildIndex(this.pictureBox5, 0);
            this.Controls.SetChildIndex(this.pictureBox6, 0);
            this.Controls.SetChildIndex(this.pictureBox7, 0);
            this.Controls.SetChildIndex(this.pictureBox8, 0);
            this.Controls.SetChildIndex(this.pictureBox9, 0);
            this.Controls.SetChildIndex(this.labelExplain, 0);
            this.Controls.SetChildIndex(this.labelHead, 0);
            this.Controls.SetChildIndex(this.buttonSlideShow, 0);
            this.Controls.SetChildIndex(this.buttonAddAlbum, 0);
            this.Controls.SetChildIndex(this.listBoxSelectedAlbums, 0);
            this.Controls.SetChildIndex(this.buttonRemove, 0);
            this.Controls.SetChildIndex(this.buttonSlideShowSelected, 0);
            this.Controls.SetChildIndex(this.labelAlbumCollection, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxAlbums;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label labelExplain;
        private System.Windows.Forms.Button buttonSlideShow;
        private System.Windows.Forms.Button buttonAddAlbum;
        private System.Windows.Forms.ListBox listBoxSelectedAlbums;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonSlideShowSelected;
        private System.Windows.Forms.Label labelAlbumCollection;
    }
}