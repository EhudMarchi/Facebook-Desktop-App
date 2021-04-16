using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public class ProfilePicturesSlideShow : ISlideShowable
    {
        private AlbumSlideShow m_AlbumSlideShow;

        public FacebookObjectCollection<Photo> Photos { get; set; }

        public ProfilePicturesSlideShow(FacebookObjectCollection<User> i_Users)
        {
            Photos = new FacebookObjectCollection<Photo>();
            foreach (User user in i_Users)
            {
                Photo profilePhoto = getProfilePhoto(user);
                if(profilePhoto != null)
                {
                    Photos.Add(profilePhoto);
                }
            }
        }

        private Photo getProfilePhoto(User i_User)
        {
            Photo profilePhoto = null;
            foreach(Album album in i_User.Albums)
            {
                if(album.Name.ToLower().Contains("profile") || album.Name.ToLower().Contains("פרופיל"))
                {
                    profilePhoto = album.Photos[0];
                }
            }

            return profilePhoto;
        }

        public void StartSlideShow()
        {
            m_AlbumSlideShow = new AlbumSlideShow(this);
            m_AlbumSlideShow.ShowDialog();
        }
    }
}
