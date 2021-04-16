using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public partial class AlbumSlideShow : Form
    {
        private readonly FacebookObjectCollection<Photo> r_ChosenPhotos;
        private readonly Random r_RandomSongGenerator = new Random();
        private SoundPlayer m_SoundPlayer;
        private int m_TimePassed = 0;
        private int m_PhotoIndex = 0;
        private PictureBox m_PicBox;
        private bool m_IsPlaying;

        public AlbumSlideShow(ISlideShowable i_SlideShowableObject)
        {
            InitializeComponent();
            m_PicBox = new PictureBox();
            m_PicBox.Name = "picBox";
            this.Controls.Add(m_PicBox);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            m_PicBox.BackColor = Color.Transparent;
            r_ChosenPhotos = i_SlideShowableObject.Photos;
            generateSong();
            this.Text = "SlideShow";
            buttonMute.Text = "Mute";
            Timer photoTimer = new Timer();
            photoTimer.Enabled = true;
            photoTimer.Interval = 100;
            photoTimer.Tick += R_PhotoTimer_Tick;
            startSlideShow();
        }

        private void generateSong()
        {
            List<string> paths = new List<string>();
            paths.Add(@"C:\Temp\Resources\Chill.wav");
            paths.Add(@"C:\Temp\Resources\Vibe.wav");
            paths.Add(@"C:\Temp\Resources\Cool.wav");
            m_SoundPlayer = new SoundPlayer(paths[r_RandomSongGenerator.Next(3)]);
        }

        private void mute()
        {
            if(m_IsPlaying)
            {
                m_SoundPlayer.Stop();
                m_IsPlaying = false;
                buttonMute.Text = "Unmute";
            }
            else
            {
                m_SoundPlayer.PlayLooping();
                m_IsPlaying = true;
                buttonMute.Text = "Mute";
            }
        }

        private void R_PhotoTimer_Tick(object sender, EventArgs e)
        {
            if(m_TimePassed <= 2000)
            {
                m_TimePassed += 100;
            }
            else
            {
                m_PhotoIndex++;
                if(r_ChosenPhotos.Count > m_PhotoIndex)
                {
                    if(r_ChosenPhotos[m_PhotoIndex] != null)
                    {
                        changePhoto(Services.URLtoImage(r_ChosenPhotos[m_PhotoIndex].PictureNormalURL));
                    }
                }
                else
                {
                    m_PhotoIndex = 0;
                    this.Close();
                }

                m_TimePassed = 0;
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            m_SoundPlayer.PlayLooping();
            m_IsPlaying = true;
        }

        private void changePhoto(Image i_Image)
        {
            this.ClientSize = new Size(i_Image.Width, i_Image.Height);
            m_PicBox.Location = new Point(0, 0);
            m_PicBox.Image = i_Image;
            m_PicBox.Size = new Size(i_Image.Width, i_Image.Height);
        }
      
        private void startSlideShow()
        {
            if(r_ChosenPhotos.Count >= m_PhotoIndex)
            {
                if(r_ChosenPhotos[m_PhotoIndex] != null)
                {
                    changePhoto(Services.URLtoImage(r_ChosenPhotos[m_PhotoIndex].PictureNormalURL));
                }
                else
                {
                    m_PhotoIndex++;
                    startSlideShow();
                }
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            m_SoundPlayer.Stop();
            m_IsPlaying = false;
        }

        private void buttonMute_Click(object sender, EventArgs e)
        {
            mute();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            if(m_PhotoIndex > 0)
            {
                m_TimePassed = 0;
                m_PhotoIndex = 0;
                startSlideShow();
            }
        }

        private void AlbumSlideShow_Load(object sender, EventArgs e)
        {
        }
    }
}
