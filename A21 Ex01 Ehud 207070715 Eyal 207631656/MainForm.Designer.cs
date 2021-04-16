using System;

namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public partial class MainForm
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
            System.Windows.Forms.Label isReadingLabel;
            System.Windows.Forms.Label questionsAmountLabel;
            System.Windows.Forms.Label questionTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxProfilePic = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.listBoxMyTeams = new System.Windows.Forms.ListBox();
            this.buttonAlbumViewer = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonFriendAlbums = new System.Windows.Forms.Button();
            this.labelFriends = new System.Windows.Forms.Label();
            this.buttonPostsViewer = new System.Windows.Forms.Button();
            this.pictureBoxFriendProfile = new System.Windows.Forms.PictureBox();
            this.buttonFriendPosts = new System.Windows.Forms.Button();
            this.labelNotSelectedFriend = new System.Windows.Forms.Label();
            this.pictureBoxTeam = new System.Windows.Forms.PictureBox();
            this.labelTeams = new System.Windows.Forms.Label();
            this.labelFriendAbout = new System.Windows.Forms.Label();
            this.groupBoxFriends = new System.Windows.Forms.GroupBox();
            this.textBoxFriendsSearch = new System.Windows.Forms.TextBox();
            this.panelQuizComposer = new System.Windows.Forms.Panel();
            this.questionTimeComboBox = new System.Windows.Forms.ComboBox();
            this.isReadingCheckBox = new System.Windows.Forms.CheckBox();
            this.questionsAmountComboBox = new System.Windows.Forms.ComboBox();
            this.buttonQuiz = new System.Windows.Forms.Button();
            this.groupBoxTeams = new System.Windows.Forms.GroupBox();
            this.textBoxTeamsSearch = new System.Windows.Forms.TextBox();
            this.labelNotSelectedTeam = new System.Windows.Forms.Label();
            this.buttonTeamPosts = new System.Windows.Forms.Button();
            this.buttonTeamAlbums = new System.Windows.Forms.Button();
            this.labelTeamsAbout = new System.Windows.Forms.Label();
            this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.buttonFriendsProfileSlideShow = new System.Windows.Forms.Button();
            this.friendQuizComposerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            isReadingLabel = new System.Windows.Forms.Label();
            questionsAmountLabel = new System.Windows.Forms.Label();
            questionTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeam)).BeginInit();
            this.groupBoxFriends.SuspendLayout();
            this.panelQuizComposer.SuspendLayout();
            this.groupBoxTeams.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendQuizComposerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // isReadingLabel
            // 
            isReadingLabel.AutoSize = true;
            isReadingLabel.Location = new System.Drawing.Point(16, 20);
            isReadingLabel.Name = "isReadingLabel";
            isReadingLabel.Size = new System.Drawing.Size(79, 17);
            isReadingLabel.TabIndex = 0;
            isReadingLabel.Text = "Is Reading:";
            // 
            // questionsAmountLabel
            // 
            questionsAmountLabel.AutoSize = true;
            questionsAmountLabel.Location = new System.Drawing.Point(16, 48);
            questionsAmountLabel.Name = "questionsAmountLabel";
            questionsAmountLabel.Size = new System.Drawing.Size(128, 17);
            questionsAmountLabel.TabIndex = 2;
            questionsAmountLabel.Text = "Questions Amount:";
            // 
            // questionTimeLabel
            // 
            questionTimeLabel.AutoSize = true;
            questionTimeLabel.Location = new System.Drawing.Point(16, 77);
            questionTimeLabel.Name = "questionTimeLabel";
            questionTimeLabel.Size = new System.Drawing.Size(104, 17);
            questionTimeLabel.TabIndex = 4;
            questionTimeLabel.Text = "Question Time:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogin.Location = new System.Drawing.Point(450, 19);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(384, 104);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxProfilePic
            // 
            this.pictureBoxProfilePic.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxProfilePic.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxProfilePic.Name = "pictureBoxProfilePic";
            this.pictureBoxProfilePic.Size = new System.Drawing.Size(102, 94);
            this.pictureBoxProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfilePic.TabIndex = 1;
            this.pictureBoxProfilePic.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(120, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 37);
            this.labelName.TabIndex = 2;
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRememberUser.ForeColor = System.Drawing.Color.White;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(12, 145);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(122, 21);
            this.checkBoxRememberUser.TabIndex = 3;
            this.checkBoxRememberUser.Text = "Remember me";
            this.checkBoxRememberUser.UseVisualStyleBackColor = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 25;
            this.listBoxFriends.Location = new System.Drawing.Point(2, 53);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(560, 179);
            this.listBoxFriends.TabIndex = 4;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // listBoxMyTeams
            // 
            this.listBoxMyTeams.DisplayMember = "Name";
            this.listBoxMyTeams.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.listBoxMyTeams.FormattingEnabled = true;
            this.listBoxMyTeams.ItemHeight = 25;
            this.listBoxMyTeams.Location = new System.Drawing.Point(3, 49);
            this.listBoxMyTeams.Name = "listBoxMyTeams";
            this.listBoxMyTeams.Size = new System.Drawing.Size(560, 179);
            this.listBoxMyTeams.TabIndex = 5;
            this.listBoxMyTeams.SelectedIndexChanged += new System.EventHandler(this.listBoxMyTeams_SelectedIndexChanged);
            // 
            // buttonAlbumViewer
            // 
            this.buttonAlbumViewer.Location = new System.Drawing.Point(1023, 15);
            this.buttonAlbumViewer.Name = "buttonAlbumViewer";
            this.buttonAlbumViewer.Size = new System.Drawing.Size(236, 65);
            this.buttonAlbumViewer.TabIndex = 6;
            this.buttonAlbumViewer.Text = "My Albums";
            this.buttonAlbumViewer.UseVisualStyleBackColor = true;
            this.buttonAlbumViewer.Visible = false;
            this.buttonAlbumViewer.Click += new System.EventHandler(this.buttonAlbumViewer_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Red;
            this.buttonLogout.ForeColor = System.Drawing.Color.Black;
            this.buttonLogout.Location = new System.Drawing.Point(10, 112);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(102, 27);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Visible = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(122, 60);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(0, 20);
            this.labelEmail.TabIndex = 8;
            // 
            // buttonFriendAlbums
            // 
            this.buttonFriendAlbums.Location = new System.Drawing.Point(117, 294);
            this.buttonFriendAlbums.Name = "buttonFriendAlbums";
            this.buttonFriendAlbums.Size = new System.Drawing.Size(197, 38);
            this.buttonFriendAlbums.TabIndex = 9;
            this.buttonFriendAlbums.Text = "See Friend Albums";
            this.buttonFriendAlbums.UseVisualStyleBackColor = true;
            this.buttonFriendAlbums.Click += new System.EventHandler(this.buttonFriendAlbums_Click);
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.BackColor = System.Drawing.Color.Transparent;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriends.ForeColor = System.Drawing.Color.White;
            this.labelFriends.Location = new System.Drawing.Point(3, 13);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(148, 31);
            this.labelFriends.TabIndex = 10;
            this.labelFriends.Text = "My Friends";
            // 
            // buttonPostsViewer
            // 
            this.buttonPostsViewer.Location = new System.Drawing.Point(1023, 112);
            this.buttonPostsViewer.Name = "buttonPostsViewer";
            this.buttonPostsViewer.Size = new System.Drawing.Size(236, 65);
            this.buttonPostsViewer.TabIndex = 11;
            this.buttonPostsViewer.Text = "My Posts";
            this.buttonPostsViewer.UseVisualStyleBackColor = true;
            this.buttonPostsViewer.Visible = false;
            this.buttonPostsViewer.Click += new System.EventHandler(this.buttonPages_Click);
            // 
            // pictureBoxFriendProfile
            // 
            this.pictureBoxFriendProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFriendProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFriendProfile.Location = new System.Drawing.Point(2, 238);
            this.pictureBoxFriendProfile.Name = "pictureBoxFriendProfile";
            this.pictureBoxFriendProfile.Size = new System.Drawing.Size(102, 94);
            this.pictureBoxFriendProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFriendProfile.TabIndex = 12;
            this.pictureBoxFriendProfile.TabStop = false;
            // 
            // buttonFriendPosts
            // 
            this.buttonFriendPosts.Location = new System.Drawing.Point(330, 294);
            this.buttonFriendPosts.Name = "buttonFriendPosts";
            this.buttonFriendPosts.Size = new System.Drawing.Size(197, 38);
            this.buttonFriendPosts.TabIndex = 13;
            this.buttonFriendPosts.Text = "See Friend Posts";
            this.buttonFriendPosts.UseVisualStyleBackColor = true;
            this.buttonFriendPosts.Click += new System.EventHandler(this.buttonFriendPosts_Click);
            // 
            // labelNotSelectedFriend
            // 
            this.labelNotSelectedFriend.AutoSize = true;
            this.labelNotSelectedFriend.BackColor = System.Drawing.Color.Transparent;
            this.labelNotSelectedFriend.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotSelectedFriend.ForeColor = System.Drawing.Color.Black;
            this.labelNotSelectedFriend.Location = new System.Drawing.Point(177, 23);
            this.labelNotSelectedFriend.Name = "labelNotSelectedFriend";
            this.labelNotSelectedFriend.Size = new System.Drawing.Size(0, 19);
            this.labelNotSelectedFriend.TabIndex = 14;
            this.labelNotSelectedFriend.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxTeam
            // 
            this.pictureBoxTeam.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTeam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxTeam.Location = new System.Drawing.Point(3, 234);
            this.pictureBoxTeam.Name = "pictureBoxTeam";
            this.pictureBoxTeam.Size = new System.Drawing.Size(102, 94);
            this.pictureBoxTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTeam.TabIndex = 16;
            this.pictureBoxTeam.TabStop = false;
            // 
            // labelTeams
            // 
            this.labelTeams.AutoSize = true;
            this.labelTeams.BackColor = System.Drawing.Color.Transparent;
            this.labelTeams.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeams.ForeColor = System.Drawing.Color.Black;
            this.labelTeams.Location = new System.Drawing.Point(4, 9);
            this.labelTeams.Name = "labelTeams";
            this.labelTeams.Size = new System.Drawing.Size(139, 31);
            this.labelTeams.TabIndex = 15;
            this.labelTeams.Text = "My Teams";
            // 
            // labelFriendAbout
            // 
            this.labelFriendAbout.AutoSize = true;
            this.labelFriendAbout.BackColor = System.Drawing.Color.Transparent;
            this.labelFriendAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendAbout.ForeColor = System.Drawing.Color.Black;
            this.labelFriendAbout.Location = new System.Drawing.Point(113, 238);
            this.labelFriendAbout.Name = "labelFriendAbout";
            this.labelFriendAbout.Size = new System.Drawing.Size(0, 20);
            this.labelFriendAbout.TabIndex = 17;
            // 
            // groupBoxFriends
            // 
            this.groupBoxFriends.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxFriends.Controls.Add(this.buttonFriendsProfileSlideShow);
            this.groupBoxFriends.Controls.Add(this.textBoxFriendsSearch);
            this.groupBoxFriends.Controls.Add(this.panelQuizComposer);
            this.groupBoxFriends.Controls.Add(this.buttonQuiz);
            this.groupBoxFriends.Controls.Add(this.labelFriendAbout);
            this.groupBoxFriends.Controls.Add(this.labelNotSelectedFriend);
            this.groupBoxFriends.Controls.Add(this.buttonFriendPosts);
            this.groupBoxFriends.Controls.Add(this.pictureBoxFriendProfile);
            this.groupBoxFriends.Controls.Add(this.labelFriends);
            this.groupBoxFriends.Controls.Add(this.buttonFriendAlbums);
            this.groupBoxFriends.Controls.Add(this.listBoxFriends);
            this.groupBoxFriends.Location = new System.Drawing.Point(12, 173);
            this.groupBoxFriends.Name = "groupBoxFriends";
            this.groupBoxFriends.Size = new System.Drawing.Size(582, 577);
            this.groupBoxFriends.TabIndex = 18;
            this.groupBoxFriends.TabStop = false;
            this.groupBoxFriends.Visible = false;
            // 
            // textBoxFriendsSearch
            // 
            this.textBoxFriendsSearch.Location = new System.Drawing.Point(378, 22);
            this.textBoxFriendsSearch.Name = "textBoxFriendsSearch";
            this.textBoxFriendsSearch.Size = new System.Drawing.Size(183, 22);
            this.textBoxFriendsSearch.TabIndex = 20;
            this.textBoxFriendsSearch.Text = "Search...";
            // 
            // panelQuizComposer
            // 
            this.panelQuizComposer.BackColor = System.Drawing.Color.LightYellow;
            this.panelQuizComposer.Controls.Add(questionTimeLabel);
            this.panelQuizComposer.Controls.Add(this.questionTimeComboBox);
            this.panelQuizComposer.Controls.Add(isReadingLabel);
            this.panelQuizComposer.Controls.Add(this.isReadingCheckBox);
            this.panelQuizComposer.Controls.Add(questionsAmountLabel);
            this.panelQuizComposer.Controls.Add(this.questionsAmountComboBox);
            this.panelQuizComposer.Location = new System.Drawing.Point(239, 371);
            this.panelQuizComposer.Name = "panelQuizComposer";
            this.panelQuizComposer.Size = new System.Drawing.Size(342, 135);
            this.panelQuizComposer.TabIndex = 19;
            // 
            // questionTimeComboBox
            // 
            this.questionTimeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendQuizComposerBindingSource, "QuestionTime", true));
            this.questionTimeComboBox.FormattingEnabled = true;
            this.questionTimeComboBox.Items.AddRange(new object[] {
            "20.0",
            "15.0",
            "10.0",
            "8.0"});
            this.questionTimeComboBox.Location = new System.Drawing.Point(150, 74);
            this.questionTimeComboBox.Name = "questionTimeComboBox";
            this.questionTimeComboBox.Size = new System.Drawing.Size(121, 24);
            this.questionTimeComboBox.TabIndex = 5;
            // 
            // isReadingCheckBox
            // 
            this.isReadingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.friendQuizComposerBindingSource, "IsReading", true));
            this.isReadingCheckBox.Location = new System.Drawing.Point(150, 15);
            this.isReadingCheckBox.Name = "isReadingCheckBox";
            this.isReadingCheckBox.Size = new System.Drawing.Size(121, 24);
            this.isReadingCheckBox.TabIndex = 1;
            this.isReadingCheckBox.UseVisualStyleBackColor = true;
            // 
            // questionsAmountComboBox
            // 
            this.questionsAmountComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendQuizComposerBindingSource, "QuestionsAmount", true));
            this.questionsAmountComboBox.DisplayMember = "6,5,4,3,2,1";
            this.questionsAmountComboBox.FormattingEnabled = true;
            this.questionsAmountComboBox.Items.AddRange(new object[] {
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.questionsAmountComboBox.Location = new System.Drawing.Point(150, 45);
            this.questionsAmountComboBox.Name = "questionsAmountComboBox";
            this.questionsAmountComboBox.Size = new System.Drawing.Size(121, 24);
            this.questionsAmountComboBox.TabIndex = 3;
            // 
            // buttonQuiz
            // 
            this.buttonQuiz.BackColor = System.Drawing.Color.Yellow;
            this.buttonQuiz.Location = new System.Drawing.Point(2, 371);
            this.buttonQuiz.Name = "buttonQuiz";
            this.buttonQuiz.Size = new System.Drawing.Size(195, 118);
            this.buttonQuiz.TabIndex = 18;
            this.buttonQuiz.Text = "How Well Do You Know Your Friend?";
            this.buttonQuiz.UseVisualStyleBackColor = false;
            this.buttonQuiz.Click += new System.EventHandler(this.buttonQuiz_Click);
            // 
            // groupBoxTeams
            // 
            this.groupBoxTeams.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTeams.Controls.Add(this.textBoxTeamsSearch);
            this.groupBoxTeams.Controls.Add(this.labelNotSelectedTeam);
            this.groupBoxTeams.Controls.Add(this.buttonTeamPosts);
            this.groupBoxTeams.Controls.Add(this.buttonTeamAlbums);
            this.groupBoxTeams.Controls.Add(this.labelTeamsAbout);
            this.groupBoxTeams.Controls.Add(this.pictureBoxTeam);
            this.groupBoxTeams.Controls.Add(this.labelTeams);
            this.groupBoxTeams.Controls.Add(this.listBoxMyTeams);
            this.groupBoxTeams.Location = new System.Drawing.Point(634, 310);
            this.groupBoxTeams.Name = "groupBoxTeams";
            this.groupBoxTeams.Size = new System.Drawing.Size(567, 440);
            this.groupBoxTeams.TabIndex = 19;
            this.groupBoxTeams.TabStop = false;
            this.groupBoxTeams.Visible = false;
            // 
            // textBoxTeamsSearch
            // 
            this.textBoxTeamsSearch.Location = new System.Drawing.Point(380, 18);
            this.textBoxTeamsSearch.Name = "textBoxTeamsSearch";
            this.textBoxTeamsSearch.Size = new System.Drawing.Size(183, 22);
            this.textBoxTeamsSearch.TabIndex = 21;
            this.textBoxTeamsSearch.Text = "Search...";
            // 
            // labelNotSelectedTeam
            // 
            this.labelNotSelectedTeam.AutoSize = true;
            this.labelNotSelectedTeam.BackColor = System.Drawing.Color.Transparent;
            this.labelNotSelectedTeam.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotSelectedTeam.ForeColor = System.Drawing.Color.Black;
            this.labelNotSelectedTeam.Location = new System.Drawing.Point(149, 21);
            this.labelNotSelectedTeam.Name = "labelNotSelectedTeam";
            this.labelNotSelectedTeam.Size = new System.Drawing.Size(0, 19);
            this.labelNotSelectedTeam.TabIndex = 18;
            this.labelNotSelectedTeam.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonTeamPosts
            // 
            this.buttonTeamPosts.Location = new System.Drawing.Point(3, 378);
            this.buttonTeamPosts.Name = "buttonTeamPosts";
            this.buttonTeamPosts.Size = new System.Drawing.Size(197, 38);
            this.buttonTeamPosts.TabIndex = 18;
            this.buttonTeamPosts.Text = "See Team Posts";
            this.buttonTeamPosts.UseVisualStyleBackColor = true;
            this.buttonTeamPosts.Click += new System.EventHandler(this.buttonTeamPosts_Click);
            // 
            // buttonTeamAlbums
            // 
            this.buttonTeamAlbums.Location = new System.Drawing.Point(3, 334);
            this.buttonTeamAlbums.Name = "buttonTeamAlbums";
            this.buttonTeamAlbums.Size = new System.Drawing.Size(197, 38);
            this.buttonTeamAlbums.TabIndex = 18;
            this.buttonTeamAlbums.Text = "See Team Albums";
            this.buttonTeamAlbums.UseVisualStyleBackColor = true;
            this.buttonTeamAlbums.Click += new System.EventHandler(this.buttonTeamAlbums_Click);
            // 
            // labelTeamsAbout
            // 
            this.labelTeamsAbout.AutoSize = true;
            this.labelTeamsAbout.BackColor = System.Drawing.Color.Transparent;
            this.labelTeamsAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTeamsAbout.ForeColor = System.Drawing.Color.Black;
            this.labelTeamsAbout.Location = new System.Drawing.Point(111, 234);
            this.labelTeamsAbout.Name = "labelTeamsAbout";
            this.labelTeamsAbout.Size = new System.Drawing.Size(0, 20);
            this.labelTeamsAbout.TabIndex = 18;
            // 
            // richTextBoxStatus
            // 
            this.richTextBoxStatus.Location = new System.Drawing.Point(2, 46);
            this.richTextBoxStatus.Name = "richTextBoxStatus";
            this.richTextBoxStatus.Size = new System.Drawing.Size(560, 72);
            this.richTextBoxStatus.TabIndex = 22;
            this.richTextBoxStatus.Text = String.Empty;
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Location = new System.Drawing.Point(490, 16);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(68, 24);
            this.buttonPostStatus.TabIndex = 21;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(3, 14);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(107, 20);
            this.labelStatus.TabIndex = 20;
            this.labelStatus.Text = "Post Status";
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxStatus.Controls.Add(this.labelStatus);
            this.groupBoxStatus.Controls.Add(this.buttonPostStatus);
            this.groupBoxStatus.Controls.Add(this.richTextBoxStatus);
            this.groupBoxStatus.Location = new System.Drawing.Point(694, 173);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(565, 131);
            this.groupBoxStatus.TabIndex = 23;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Visible = false;
            // 
            // buttonFriendsProfileSlideShow
            // 
            this.buttonFriendsProfileSlideShow.BackColor = System.Drawing.Color.Yellow;
            this.buttonFriendsProfileSlideShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFriendsProfileSlideShow.Location = new System.Drawing.Point(157, 20);
            this.buttonFriendsProfileSlideShow.Name = "buttonFriendsProfileSlideShow";
            this.buttonFriendsProfileSlideShow.Size = new System.Drawing.Size(202, 26);
            this.buttonFriendsProfileSlideShow.TabIndex = 21;
            this.buttonFriendsProfileSlideShow.Text = "Start Friends Slideshow";
            this.buttonFriendsProfileSlideShow.UseVisualStyleBackColor = false;
            this.buttonFriendsProfileSlideShow.Click += new System.EventHandler(this.buttonFriendsProfileSlideShow_Click);
            // 
            // friendQuizComposerBindingSource
            // 
            this.friendQuizComposerBindingSource.DataSource = typeof(A21_Ex02_Ehud_207070715_Eyal_207631656.FriendQuizComposer);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.groupBoxTeams);
            this.Controls.Add(this.groupBoxFriends);
            this.Controls.Add(this.buttonPostsViewer);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonAlbumViewer);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxProfilePic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeam)).EndInit();
            this.groupBoxFriends.ResumeLayout(false);
            this.groupBoxFriends.PerformLayout();
            this.panelQuizComposer.ResumeLayout(false);
            this.panelQuizComposer.PerformLayout();
            this.groupBoxTeams.ResumeLayout(false);
            this.groupBoxTeams.PerformLayout();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendQuizComposerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxProfilePic;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.ListBox listBoxMyTeams;
        private System.Windows.Forms.Button buttonAlbumViewer;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonFriendAlbums;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Button buttonPostsViewer;
        private System.Windows.Forms.PictureBox pictureBoxFriendProfile;
        private System.Windows.Forms.Button buttonFriendPosts;
        private System.Windows.Forms.Label labelNotSelectedFriend;
        private System.Windows.Forms.PictureBox pictureBoxTeam;
        private System.Windows.Forms.Label labelTeams;
        private System.Windows.Forms.Label labelFriendAbout;
        private System.Windows.Forms.GroupBox groupBoxFriends;
        private System.Windows.Forms.GroupBox groupBoxTeams;
        private System.Windows.Forms.Label labelTeamsAbout;
        private System.Windows.Forms.Button buttonTeamPosts;
        private System.Windows.Forms.Button buttonTeamAlbums;
        private System.Windows.Forms.Label labelNotSelectedTeam;
        private System.Windows.Forms.RichTextBox richTextBoxStatus;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.Button buttonQuiz;
        private System.Windows.Forms.Panel panelQuizComposer;
        private System.Windows.Forms.CheckBox isReadingCheckBox;
        private System.Windows.Forms.BindingSource friendQuizComposerBindingSource;
        private System.Windows.Forms.ComboBox questionsAmountComboBox;
        private System.Windows.Forms.ComboBox questionTimeComboBox;
        private System.Windows.Forms.TextBox textBoxFriendsSearch;
        private System.Windows.Forms.TextBox textBoxTeamsSearch;
        private System.Windows.Forms.Button buttonFriendsProfileSlideShow;
    }
}