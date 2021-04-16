using System.Drawing;
using System.Windows.Forms;

namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public class ImagePreviewForm : Form
    {
        public ImagePreviewForm(Image i_Image)
        {
            this.ClientSize = new Size(i_Image.Width, i_Image.Height);
            this.Text = "Facebook Photo";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            PictureBox picBox = new PictureBox();
            picBox.Location = new Point(0, 0);
            picBox.Image = i_Image;
            picBox.Name = "picBox";
            picBox.Size = new Size(i_Image.Width, i_Image.Height);
            picBox.TabIndex = 1;
            picBox.TabStop = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Controls.Add(picBox);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            //// 
            //// ImagePreviewForm
            //// 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ImagePreviewForm";
            this.Load += new System.EventHandler(this.ImagePreviewForm_Load);
            this.ResumeLayout(false);
        }

        private void ImagePreviewForm_Load(object sender, System.EventArgs e)
        {
        }
    }
}