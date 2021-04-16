using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public partial class PostsPreviewForm : ContentViewerForm
    {
        private readonly FacebookObjectCollection<Post> r_Posts;

        public PostsPreviewForm(FacebookObjectCollection<Post> i_LoggedInUserPosts)
        {
            InitializeComponent();
            r_Posts = i_LoggedInUserPosts;
        }

        private void fetchPosts()
        {
            ListViewItem item;
            int itemIndex = 1;
            imageListPosts.Images.Add(
                Services.URLtoImage(
                    "https://st2.depositphotos.com/1144386/7770/v/600/depositphotos_77705004-stock-illustration-original-square-with-round-corners.jpg"));
            if(r_Posts != null)
            {
                foreach(Post post in r_Posts)
                {
                    {
                        {
                            if(string.IsNullOrEmpty(post.Message))
                            {
                                item = new ListViewItem(post.CreatedTime.ToString());
                            }
                            else
                            {
                                item = new ListViewItem(post.Message);
                            }

                            Image postImage = Services.URLtoImage(post.PictureURL);
                            if(postImage != null)
                            {
                                imageListPosts.Images.Add(postImage);
                                item.ImageIndex = itemIndex++;
                            }
                            else
                            {
                                item.ImageIndex = 0;
                            }

                            listViewPosts.Items.Add(item);
                        }
                    }
                }
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchPosts();
        }

        private void listViewPosts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Services.ViewPost(r_Posts[listViewPosts.SelectedItems[0].Index] as Post);
        }

        private void PostsPreviewForm_Load(object sender, EventArgs e)
        {
        }
    }
}