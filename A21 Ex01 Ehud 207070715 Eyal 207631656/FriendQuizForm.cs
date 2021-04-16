using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Threading;
using FacebookWrapper.ObjectModel;
using Timer = System.Windows.Forms.Timer;

namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public partial class FriendQuizForm : Form
    {
        private readonly List<Control> r_Buttons;
        private readonly User r_LoggedInUser;
        private readonly Timer r_QuestionTimer;
        private readonly int r_QuestionsAmount;
        private readonly User r_User;
        private readonly Random r_Generator = new Random();
        private int m_Answer;
        private int m_QuestionIndex = 0;
        private int m_Score = 0;
        private float m_TimeLeft;
        private SpeechSynthesizer m_SpeechSynthesizer;
        private List<string> m_Questions;
        private bool m_IsReading = true;

        public FriendQuizForm(User i_User, User i_LoggedInUser, bool i_IsReading, int i_QuestionAmount, int i_QuestionTime)
        {
            InitializeComponent();
            r_User = i_User;
            r_LoggedInUser = i_LoggedInUser;
            m_SpeechSynthesizer = new SpeechSynthesizer();
            m_SpeechSynthesizer.SetOutputToDefaultAudioDevice();
            m_Questions = new List<string>();
            r_QuestionsAmount = i_QuestionAmount;
            m_IsReading = i_IsReading;
            labelHeadline.Text = string.Format("How Well Do You Know {0}?", r_User.FirstName);
            r_QuestionTimer = new Timer();
            r_QuestionTimer.Enabled = true;
            r_QuestionTimer.Interval = 100;
            progressBarQuestions.Value = 0;
            progressBarQuestions.Step = 100;
            progressBarQuestions.Maximum = i_QuestionTime * 1000;
            m_TimeLeft = progressBarQuestions.Maximum / 1000f;
            r_QuestionTimer.Tick += M_QuestionTimer_Tick;
            labelTimeLeft.Text = string.Format("{0:0.0}s", m_TimeLeft);
            r_Buttons = new List<Control>();
            Services.FindControlsOfType(typeof(Button), this.Controls, ref r_Buttons);
        }

        private void M_QuestionTimer_Tick(object sender, EventArgs e)
        {
            progressBarQuestions.PerformStep();
            if(progressBarQuestions.Value < 10000)
            {
                progressBarQuestions.Value++;
                m_TimeLeft -= 0.1f;
                labelTimeLeft.Text = string.Format("{0:0.0}s", m_TimeLeft);
            }
            else
            {
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Out of time";
                this.Refresh();
                System.Threading.Thread.Sleep(1000);
                nextQuestion();
            }
        }

        private void nextQuestion()
        {
            m_TimeLeft = progressBarQuestions.Maximum / 1000;
            r_QuestionTimer.Stop();
            m_QuestionIndex++;
            if(m_QuestionIndex < r_QuestionsAmount)
            {
                startQuestion(m_Questions[m_QuestionIndex]);
            }
            else
            {
                this.Close();
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            LoadQuestionsFromFile();
            Services.SetImage(pictureBoxFriendPhoto, r_User.PictureNormalURL);
            startQuestion(m_Questions[m_QuestionIndex]);
        }

        private void startQuestion(string i_Question)
        {
            int answerIndex = r_Generator.Next(0, 3);
            m_Answer = getAnswer();
            clear();
            r_Buttons[answerIndex].Text = m_Answer.ToString();
            generateOptions();
            progressBarQuestions.Value = 0;
            labelQuestionNum.Text = "Question " + (m_Questions.IndexOf(i_Question) + 1).ToString();
            labelQuestion.Text = string.Format(i_Question, r_User.FirstName);
            if(m_IsReading)
            {
                new Thread(readQuestion).Start();
            }

            r_QuestionTimer.Start();
        }

        private void readQuestion()
        {
            m_SpeechSynthesizer.Speak(labelQuestion.Text);
        }

        private int getAnswer()
        {
            int answer = 0;

            if(m_QuestionIndex == 0)
            {
                int mutual = 0;
                foreach(User friend in r_LoggedInUser.Friends)
                {
                    foreach(User userFriend in r_User.Friends)
                    {
                        if(friend.Id == userFriend.Id)
                        {
                            mutual++;
                            break;
                        }
                    }
                }

                answer = mutual;
            }
            else if(m_QuestionIndex == 1)
            {
                foreach(Album album in r_User.Albums)
                {
                    answer += album.Photos.Count();
                }
            }
            else if(m_QuestionIndex == 2)
            {
                if(r_User.Checkins != null)
                {
                    answer = r_User.Checkins.Count;
                }
            }
            else if(m_QuestionIndex == 3)
            {
                if(r_User.FavofriteTeams != null)
                {
                    answer = r_User.FavofriteTeams.Length;
                }
            }
            else if(m_QuestionIndex == 4)
            {
                if(r_User.Albums != null)
                {
                    answer = r_User.Albums.Count;
                }
            }
            else if(m_QuestionIndex == 5)
            {
                if(r_User.Posts != null)
                {
                    answer = r_User.Posts.Count;
                }
            }

            return answer;
        }

        private void clear()
        {
            foreach(Button button in r_Buttons)
            {
                button.Text = string.Empty;
            }

            labelResult.Text = string.Empty;
        }

        private void generateOptions()
        {
            int falseAnswer;
            foreach(Button button in r_Buttons)
            {
                if(string.IsNullOrEmpty(button.Text))
                {
                    falseAnswer = r_Generator.Next(0, (m_Answer + 3) * 2);
                    while(isExists(falseAnswer))
                    {
                        falseAnswer = r_Generator.Next(0, (m_Answer + 3) * 2);
                    }

                    button.Text = falseAnswer.ToString();
                }
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            MessageBox.Show(m_Score + " Correct answers!");
            base.OnClosing(e);
            r_QuestionTimer.Stop();
        }

        private bool isExists(int i_Answer)
        {
            bool isExist = false;
            foreach(Button button in r_Buttons)
            {
                if(button.Text == i_Answer.ToString())
                {
                    isExist = true;
                }
            }

            return isExist;
        }

        private void checkAnswer(int i_ChosenAnswer)
        {
            if(i_ChosenAnswer == m_Answer)
            {
                labelResult.Text = "Correct!";
                labelResult.ForeColor = Color.Green;
                m_Score++;
            }
            else
            {
                labelResult.Text = "Wrong!";
                labelResult.ForeColor = Color.Red;
            }

            this.Refresh();
            System.Threading.Thread.Sleep(1000);
            nextQuestion();
        }

        private void LoadQuestionsFromFile()
        {
            string line;
            StreamReader file = new StreamReader(@"C:\Temp\Resources\questions.txt");

            if(File.Exists(@"C:\Temp\Resources\questions.txt"))
            {
                while((line = file.ReadLine()) != null)
                {
                    m_Questions.Add(line);
                }
            }
        }

        private void buttonOption1_Click(object sender, EventArgs e)
        {
            checkAnswer(int.Parse(buttonOption1.Text));
        }

        private void buttonOption2_Click(object sender, EventArgs e)
        {
            checkAnswer(int.Parse(buttonOption2.Text));
        }

        private void buttonOption3_Click(object sender, EventArgs e)
        {
            checkAnswer(int.Parse(buttonOption3.Text));
        }

        private void buttonOption4_Click(object sender, EventArgs e)
        {
            checkAnswer(int.Parse(buttonOption4.Text));
        }

        private void FriendQuizForm_Load(object sender, EventArgs e)
        {
        }
    }
}