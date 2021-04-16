namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public partial class ContentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContentViewerForm));
            this.labelHead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHead
            // 
            this.labelHead.AutoSize = true;
            this.labelHead.BackColor = System.Drawing.Color.Transparent;
            this.labelHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHead.Location = new System.Drawing.Point(568, 8);
            this.labelHead.Name = "labelHead";
            this.labelHead.Size = new System.Drawing.Size(0, 46);
            this.labelHead.TabIndex = 36;
            this.labelHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.labelHead);
            this.Name = "ContentViewerForm";
            this.Text = "ContentViewerForm";
            this.Load += new System.EventHandler(this.ContentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label labelHead;
    }
}