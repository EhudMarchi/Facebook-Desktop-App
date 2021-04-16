using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public partial class MainForm : Form
    {
        private readonly AppSettings r_AppSettings;
        private LoginResult m_LoginResult;
        private FriendQuizComposer m_QuizComposer = new FriendQuizComposer();
        private FilterIteratorListBox<User> m_FriendsFilterIterator;
        private FilterIteratorListBox<Page> m_FavTeamsFilterIterator;

        public MainForm()
        {
            InitializeComponent();
            r_AppSettings = AppSettings.LoadSettingsFromFile();
            this.checkBoxRememberUser.Checked = r_AppSettings.RememberUser;
        }

        public User LoggedInUser { get; set; }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            r_AppSettings.RememberUser = this.checkBoxRememberUser.Checked;
            if(r_AppSettings.RememberUser && m_LoginResult != null)
            {
                r_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
            }
            else
            {
                r_AppSettings.RememberUser = false;
                r_AppSettings.LastAccessToken = null;
            }

            r_AppSettings.SaveToFile();
        }

        private bool login()
        {
            bool success = true;
            try
            {
                if(checkBoxRememberUser.Checked && !string.IsNullOrEmpty(r_AppSettings.LastAccessToken))
                {
                    m_LoginResult = FacebookService.Connect(r_AppSettings.LastAccessToken);
                }
                else
                {
                    m_LoginResult = FacebookService.Login(
                        "1390141937858644",
                        "user_status",
                        "public_profile",
                        "email",
                        "user_birthday",
                        "user_age_range",
                        "user_gender",
                        "user_link",
                        "user_tagged_places",
                        "user_videos",
                        "user_friends",
                        "user_events",
                        "user_likes",
                        "user_location",
                        "user_photos",
                        "user_posts",
                        "user_hometown");
                }

                if(m_LoginResult != null)
                {
                    LoggedInUser = m_LoginResult.LoggedInUser;
                    Services.SetImage(pictureBoxProfilePic, LoggedInUser.PictureNormalURL);
                    new Thread(fetchInfo).Start();
                    friendQuizComposerBindingSource.DataSource = m_QuizComposer;
                    buttonLogin.Visible = false;
                    buttonLogout.Visible = true;
                    groupBoxStatus.Visible = true;
                    buttonAlbumViewer.Visible = true;
                    buttonPostsViewer.Visible = true;
                    groupBoxFriends.Visible = true;
                    groupBoxTeams.Visible = true;
                    this.Refresh();
                }
            }
            catch(Exception)
            {
                success = false;
                MessageBox.Show("Login Faild");
            }

            return success;
        }

        private void fetchUserInfo()
        {
            labelName.Invoke(new Action(() => labelName.Text = LoggedInUser.Name));
            labelEmail.Invoke(new Action(() => labelEmail.Text = LoggedInUser.Email));
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if(checkBoxRememberUser.Checked)
            {
                login();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void fetchInfo()
        {
            new Thread(fetchUserInfo).Start();
            m_FriendsFilterIterator = new FilterIteratorListBox<User>(listBoxFriends, textBoxFriendsSearch, LoggedInUser.Friends, (i_User, i_SearchText) => i_User.Name.ToLower().Contains(i_SearchText.ToLower()));
            m_FavTeamsFilterIterator = new FilterIteratorListBox<Page>(listBoxMyTeams, textBoxTeamsSearch, LoggedInUser.FavofriteTeams, (i_Page, i_SearchText) => i_Page.Name.ToLower().Contains(i_SearchText.ToLower()));
        }

        private void buttonAlbumViewer_Click(object sender, EventArgs e)
        {
            ContentViewerForm albumViewerForm = ContentViewerFormFactory.CreateContentViewerForm(LoggedInUser.Albums);
            albumViewerForm.ShowDialog();
        }

        private void clearForm()
        {
            listBoxFriends.Items.Clear();
            listBoxMyTeams.Items.Clear();
            pictureBoxProfilePic.Image = null;
            labelName.Text = string.Empty;
            labelEmail.Text = string.Empty;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if(LoggedInUser == null || string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                MessageBox.Show("You must be logged in before you can log out!");
            }
            else
            {
                clearForm();
                FacebookService.Logout(null, m_LoginResult.AccessToken);
                LoggedInUser = null;
                m_LoginResult = null;
                buttonLogin.Visible = true;
                buttonLogout.Visible = false;
                buttonAlbumViewer.Visible = false;
                buttonPostsViewer.Visible = false;
                groupBoxStatus.Visible = false;
                groupBoxFriends.Visible = false;
                groupBoxTeams.Visible = false;
                MessageBox.Show("You are now logged out!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonFriendAlbums_Click(object sender, EventArgs e)
        {
            if(listBoxFriends.SelectedItem != null)
            {
                ContentViewerForm albumViewerForm = ContentViewerFormFactory.CreateContentViewerForm(LoggedInUser.Friends[listBoxFriends.SelectedIndex].Albums);
                albumViewerForm.ShowDialog();
            }
            else
            {
                labelNotSelectedFriend.Text = "Please select friend";
            }
        }

        private void buttonPages_Click(object sender, EventArgs e)
        {
            ContentViewerForm postsPreviewForm = ContentViewerFormFactory.CreateContentViewerForm(LoggedInUser.WallPosts);
            postsPreviewForm.ShowDialog();
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            User friend = listBoxFriends.SelectedItem as User;
            m_QuizComposer.Friend = friend;
            if(listBoxFriends.SelectedItem != null)
            {
                Services.SetImage(pictureBoxFriendProfile, friend.PictureNormalURL);
                labelNotSelectedFriend.Text = string.Empty;
                labelFriendAbout.Text = friend.About;
            }
        }

        private void buttonFriendPosts_Click(object sender, EventArgs e)
        {
            if(listBoxFriends.SelectedItem != null)
            {
                ContentViewerForm postsViewerForm = ContentViewerFormFactory.CreateContentViewerForm(LoggedInUser.Friends[listBoxFriends.SelectedIndex].Posts);
                postsViewerForm.ShowDialog();
            }
            else
            {
                labelNotSelectedFriend.Text = "Please select friend";
            }
        }

        private void listBoxMyTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            Page page = listBoxMyTeams.SelectedItem as Page;
            if(listBoxMyTeams.SelectedItem != null)
            {
                Services.SetImage(pictureBoxTeam, page.PictureURL);
                labelTeamsAbout.Text = page.Website;
            }
        }

        private void buttonTeamAlbums_Click(object sender, EventArgs e)
        {
            try
            {
                if(listBoxMyTeams.SelectedItem != null)
                {
                    ContentViewerForm albumViewerForm = ContentViewerFormFactory.CreateContentViewerForm(LoggedInUser.FavofriteTeams[listBoxMyTeams.SelectedIndex].Albums);
                    albumViewerForm.ShowDialog();
                }
                else
                {
                    labelNotSelectedTeam.Text = "Please select team";
                }
            }
            catch(Exception ex)
            {
                labelNotSelectedTeam.Text = string.Empty;
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTeamPosts_Click(object sender, EventArgs e)
        {
            try
            {
                if(listBoxMyTeams.SelectedItem != null)
                {
                    ContentViewerForm postsViewerForm = ContentViewerFormFactory.CreateContentViewerForm(LoggedInUser.FavofriteTeams[listBoxMyTeams.SelectedIndex].Posts);
                    postsViewerForm.ShowDialog();
                }
                else
                {
                    labelNotSelectedTeam.Text = "Please select team";
                }
            }
            catch(Exception ex)
            {
                labelNotSelectedTeam.Text = string.Empty;
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(richTextBoxStatus.Text))
                {
                    LoggedInUser.PostStatus(richTextBoxStatus.Text);
                    MessageBox.Show("Status Uploaded");
                }
                else
                {
                    MessageBox.Show("Please enter text to post");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            richTextBoxStatus.Text = string.Empty;
        }

        private void buttonQuiz_Click(object sender, EventArgs e)
        {
            if(listBoxFriends.SelectedItem != null)
            {
                FriendQuizForm friendQuizForm = FriendQuizBuilder.BuildQuiz(m_QuizComposer, LoggedInUser);
                friendQuizForm.ShowDialog();
            }
            else
            {
                labelNotSelectedFriend.Text = "Please select friend";
            }
        }

        private void buttonFriendsProfileSlideShow_Click(object sender, EventArgs e)
        {
            ProfilePicturesSlideShow friendPicturesSlideShow = new ProfilePicturesSlideShow(LoggedInUser.Friends);
            friendPicturesSlideShow.StartSlideShow();
        }
    }
}