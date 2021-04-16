using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public class SlideShowAdapter : ISlideShowable
    {
        private AlbumSlideShow m_AlbumSlideShow;

        public FacebookObjectCollection<Photo> Photos { get; set; }

        public SlideShowAdapter(List<Album> i_AlbumCollection)
        {
            Photos = new FacebookObjectCollection<Photo>();
            convertToFacebookObjectCollection(i_AlbumCollection);
        }

        private void convertToFacebookObjectCollection(List<Album> i_AlbumCollection)
        {
            foreach(Album album in i_AlbumCollection)
            {
                foreach(Photo photo in album.Photos)
                {
                    Photos.Add(photo);
                }
            }
        }

        public void ChangeSlideShowCollection(List<Album> i_AlbumCollection)
        {
            Photos.Clear();
            convertToFacebookObjectCollection(i_AlbumCollection);
        }

        public void StartSlideShow()
        {
            m_AlbumSlideShow = new AlbumSlideShow(this);
            m_AlbumSlideShow.ShowDialog();
        }
    }
}
