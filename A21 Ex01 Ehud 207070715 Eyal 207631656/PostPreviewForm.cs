using System;
using System.Windows.Forms;
using A21_Ex02_Ehud_207070715_Eyal_207631656;
using FacebookWrapper.ObjectModel;

namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public partial class PostPreviewForm : Form
    {
        private readonly Post r_Post;

        public PostPreviewForm(Post i_Post)
        {
            InitializeComponent();
            r_Post = i_Post;
            if(r_Post.PictureURL != null)
            {
                Services.SetImage(pictureBoxPostImage, i_Post.PictureURL);
            }
            else
            {
                Services.SetImage(
                    pictureBoxPostImage,
                    "https://st2.depositphotos.com/1144386/7770/v/600/depositphotos_77705004-stock-illustration-original-square-with-round-corners.jpg");
            }

            labelPostName.Text = r_Post.Name;
            richTextBoxPost.Text = string.Format(
                "{0}\n{1}\n{2}",
                r_Post.CreatedTime,
                i_Post.Description,
                r_Post.Message);
            listBoxComments.DisplayMember = "Message";
            foreach(Comment comment in r_Post.Comments)
            {
                listBoxComments.Items.Add(comment);
            }
        }

        private void PostPreviewForm_Load(object sender, EventArgs e)
        {
        }

        private void pictureBoxPostImage_Click(object sender, EventArgs e)
        {
        }

        private void buttonLike_Click(object sender, EventArgs e)
        {
            try
            {
                r_Post.Like();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSendComment_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(richTextBoxComment.Text))
                {
                    r_Post.Comment(richTextBoxComment.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            richTextBoxComment.Text = string.Empty;
        }

        private void labelComment_Click(object sender, EventArgs e)
        {
        }

        private void richTextBoxComment_TextChanged(object sender, EventArgs e)
        {
        }
    }
}