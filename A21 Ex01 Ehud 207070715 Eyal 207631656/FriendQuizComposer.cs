using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public class FriendQuizComposer
    {
        public int QuestionsAmount { get; set; }

        public int QuestionTime { get; set; }

        public bool IsReading { get; set; }

        public User Friend { get; set; }

        public FriendQuizComposer()
        {
            QuestionsAmount = 6;
            QuestionTime = 10;
            IsReading = true;
        }
    }
}
