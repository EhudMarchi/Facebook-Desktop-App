using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public partial class AlbumViewerForm : ContentViewerForm
    {
        private readonly FacebookObjectCollection<Album> r_Albums;
        private readonly List<Control> r_PicBoxes;
        private Album m_ChosenAlbum;
        private ISlideShowable m_SlideShowAdapter;
        private int m_PhotosIndex = 0;

        public List<Album> AlbumsCollectionList { get; set; }

        public AlbumViewerForm(FacebookObjectCollection<Album> i_LoggedInUserAlbums)
        {
            InitializeComponent();
            AlbumsCollectionList = new List<Album>();
            m_SlideShowAdapter = new SlideShowAdapter(AlbumsCollectionList);
            comboBoxAlbums.DisplayMember = "Name";
            listBoxSelectedAlbums.DisplayMember = "Name";
            r_Albums = i_LoggedInUserAlbums;
            foreach(Album album in r_Albums)
            {
                comboBoxAlbums.Items.Add(album);
            }

            r_PicBoxes = new List<Control>();
            Services.FindControlsOfType(typeof(PictureBox), this.Controls, ref r_PicBoxes);
            initializePicBoxes();
        }

        private Album getSelectedAlbum()
        {
            Album chosenAlbum = null;
            foreach(Album album in r_Albums)
            {
                if(album.Name == comboBoxAlbums.Text)
                {
                    chosenAlbum = album;
                }
            }

            return chosenAlbum;
        }

        private void comboBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearPhotos();
            m_PhotosIndex = 0;
            buttonNext.Enabled = false;
            buttonPrevious.Enabled = false;
            m_ChosenAlbum = getSelectedAlbum();
            Services.ShowPhotos(m_ChosenAlbum, r_PicBoxes, ref m_PhotosIndex);
            labelExplain.Visible = true;
            buttonSlideShow.Enabled = true;
            if(m_ChosenAlbum.Photos.Count > r_PicBoxes.Count)
            {
                buttonNext.Enabled = true;
            }
        }

        private void clearPhotos()
        {
            foreach(PictureBox picBox in r_PicBoxes)
            {
                picBox.Image = null;
            }
        }

        private void initializePicBoxes()
        {
            foreach(PictureBox picBox in r_PicBoxes)
            {
                picBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            buttonPrevious.Enabled = true;
            if(m_PhotosIndex + r_PicBoxes.Count > m_ChosenAlbum.Photos.Count)
            {
                buttonNext.Enabled = false;
            }

            Services.ShowPhotos(m_ChosenAlbum, r_PicBoxes, ref m_PhotosIndex);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            buttonNext.Enabled = true;
            if(m_PhotosIndex > r_PicBoxes.Count * 2)
            {
                m_PhotosIndex -= r_PicBoxes.Count * 2;
            }
            else
            {
                m_PhotosIndex = 0;
                buttonPrevious.Enabled = false;
            }

            Services.ShowPhotos(m_ChosenAlbum, r_PicBoxes, ref m_PhotosIndex);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Services.ViewImage(pictureBox9);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Services.ViewImage(pictureBox8);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Services.ViewImage(pictureBox7);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Services.ViewImage(pictureBox6);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Services.ViewImage(pictureBox5);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Services.ViewImage(pictureBox4);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Services.ViewImage(pictureBox3);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Services.ViewImage(pictureBox2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Services.ViewImage(pictureBox1);
        }

        private void buttonSlideShow_Click(object sender, EventArgs e)
        {
            AlbumsCollectionList.Clear();
            AlbumsCollectionList.Add(m_ChosenAlbum);
            viewAlbum();
        }

        private void viewAlbum()
        {
            if(m_ChosenAlbum.Photos != null)
            {
                (m_SlideShowAdapter as SlideShowAdapter).ChangeSlideShowCollection(AlbumsCollectionList);
                m_SlideShowAdapter.StartSlideShow();
            }
        }

        private void AlbumViewerForm_Load(object sender, EventArgs e)
        {
        }

        private void buttonAddAlbum_Click(object sender, EventArgs e)
        {
            if(m_ChosenAlbum != null)
            {
                if(!listBoxSelectedAlbums.Items.Contains(m_ChosenAlbum))
                {
                    listBoxSelectedAlbums.Items.Add(m_ChosenAlbum);
                    buttonSlideShowSelected.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("No album selected");
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedAlbums.SelectedItem != null)
            {
                listBoxSelectedAlbums.Items.Remove(listBoxSelectedAlbums.SelectedItem);
                if(listBoxSelectedAlbums.Items.Count == 0)
                {
                    buttonSlideShowSelected.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please select album to remove");
            }
    }

        private void buttonSlideShowSelected_Click(object sender, EventArgs e)
        {
            AlbumsCollectionList.Clear();
            foreach(Album album in listBoxSelectedAlbums.Items)
            {
                AlbumsCollectionList.Add(album);
            }

            viewAlbum();
        }
    }
}