using System;
using FacebookWrapper.ObjectModel;

namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public abstract class ContentViewerFormFactory
    {
        public static ContentViewerForm CreateContentViewerForm<T>(FacebookObjectCollection<T> i_Collection)
        {
            ContentViewerForm contentForm;
            if (typeof(T) == typeof(Album))
            {
                contentForm = new AlbumViewerForm(i_Collection as FacebookObjectCollection<Album>);
            }
            else if (typeof(T) == typeof(Post))
            {
                contentForm = new PostsPreviewForm(i_Collection as FacebookObjectCollection<Post>);
            }
            else
            {
                throw new ArgumentException();
            }

            return contentForm;
        }
    }
}
