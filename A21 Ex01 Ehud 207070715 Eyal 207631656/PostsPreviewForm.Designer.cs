namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public partial class PostsPreviewForm
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
            this.labelPostMessege = new System.Windows.Forms.Label();
            this.listViewPosts = new System.Windows.Forms.ListView();
            this.imageListPosts = new System.Windows.Forms.ImageList(this.components);
            this.labelExplain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHead
            // 
            this.labelHead.Size = new System.Drawing.Size(126, 46);
            this.labelHead.Text = "Posts";
            // 
            // labelPostMessege
            // 
            this.labelPostMessege.AutoSize = true;
            this.labelPostMessege.BackColor = System.Drawing.Color.Transparent;
            this.labelPostMessege.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPostMessege.Location = new System.Drawing.Point(273, 115);
            this.labelPostMessege.Name = "labelPostMessege";
            this.labelPostMessege.Size = new System.Drawing.Size(0, 29);
            this.labelPostMessege.TabIndex = 48;
            this.labelPostMessege.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // listViewPosts
            // 
            this.listViewPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listViewPosts.HideSelection = false;
            this.listViewPosts.LargeImageList = this.imageListPosts;
            this.listViewPosts.Location = new System.Drawing.Point(208, 115);
            this.listViewPosts.Margin = new System.Windows.Forms.Padding(10);
            this.listViewPosts.MultiSelect = false;
            this.listViewPosts.Name = "listViewPosts";
            this.listViewPosts.Size = new System.Drawing.Size(852, 566);
            this.listViewPosts.TabIndex = 49;
            this.listViewPosts.TileSize = new System.Drawing.Size(600, 110);
            this.listViewPosts.UseCompatibleStateImageBehavior = false;
            this.listViewPosts.View = System.Windows.Forms.View.Tile;
            this.listViewPosts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewPosts_MouseDoubleClick);
            // 
            // imageListPosts
            // 
            this.imageListPosts.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListPosts.ImageSize = new System.Drawing.Size(100, 100);
            this.imageListPosts.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelExplain
            // 
            this.labelExplain.AutoSize = true;
            this.labelExplain.BackColor = System.Drawing.Color.Transparent;
            this.labelExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelExplain.Location = new System.Drawing.Point(526, 691);
            this.labelExplain.Name = "labelExplain";
            this.labelExplain.Size = new System.Drawing.Size(222, 24);
            this.labelExplain.TabIndex = 50;
            this.labelExplain.Text = "Double click post to open";
            // 
            // PostsPreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.labelExplain);
            this.Controls.Add(this.listViewPosts);
            this.Controls.Add(this.labelPostMessege);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PostsPreviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PostsPreviewForm";
            this.Load += new System.EventHandler(this.PostsPreviewForm_Load);
            this.Controls.SetChildIndex(this.labelHead, 0);
            this.Controls.SetChildIndex(this.labelPostMessege, 0);
            this.Controls.SetChildIndex(this.listViewPosts, 0);
            this.Controls.SetChildIndex(this.labelExplain, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPostMessege;
        private System.Windows.Forms.ListView listViewPosts;
        private System.Windows.Forms.ImageList imageListPosts;
        private System.Windows.Forms.Label labelExplain;
    }
}