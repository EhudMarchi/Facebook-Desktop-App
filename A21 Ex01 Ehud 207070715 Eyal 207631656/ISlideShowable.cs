using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public interface ISlideShowable
    {
        FacebookObjectCollection<Photo> Photos { get; set; }

        void StartSlideShow();
    }
}
