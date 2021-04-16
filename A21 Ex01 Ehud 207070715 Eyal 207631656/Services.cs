using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public sealed class Services
    {
        private Services()
        {
        }

        public static void FindControlsOfType(
            Type i_Type,
            Control.ControlCollection i_FormControls,
            ref List<Control> i_Controls)
        {
            foreach(Control control in i_FormControls)
            {
                if(control.GetType() == i_Type)
                {
                    i_Controls.Add(control);
                }

                if(control.Controls.Count > 0)
                {
                    FindControlsOfType(i_Type, control.Controls, ref i_Controls);
                }
            }
        }

        public static void ViewImage(PictureBox i_PicBox)
        {
            if(i_PicBox.Image != null)
            {
                ImagePreviewForm imagePreviewForm = new ImagePreviewForm(i_PicBox.Image);
                imagePreviewForm.ShowDialog();
            }
        }

        public static void ViewPost(Post i_Post)
        {
            PostPreviewForm postPreviewForm = new PostPreviewForm(i_Post);
            postPreviewForm.ShowDialog();
        }

        public static void ShowPhotos(Album i_Album, List<Control> i_picBoxes, ref int i_PhotoIndex)
        {
            foreach(PictureBox picBox in i_picBoxes)
            {
                if(i_PhotoIndex < i_Album.Photos.Count)
                {
                    if(i_Album.Photos[i_PhotoIndex] != null)
                    {
                        SetImage(picBox, i_Album.Photos[i_PhotoIndex].PictureNormalURL);
                    }
                    else
                    {
                        picBox.LoadAsync(null);
                    }

                    i_PhotoIndex++;
                }
            }
        }

        public static Image URLtoImage(string i_URL)
        {
            Image image = null;
            if(!string.IsNullOrEmpty(i_URL))
            {
                using(WebClient webClient = new WebClient())
                {
                    using(Stream stream = new MemoryStream(webClient.DownloadData(i_URL)))
                    {
                        image = Image.FromStream(stream);
                    }
                }
            }

            return image;
        }

        public static void SetImage(PictureBox i_PicBox, string i_URL)
        {
            i_PicBox.Image = Properties.Resources.LoaderGif;
            i_PicBox.LoadAsync(i_URL);
        }
    }
}