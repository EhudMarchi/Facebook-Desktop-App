using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public class FriendQuizBuilder
    {
        public static FriendQuizForm BuildQuiz(FriendQuizComposer i_QuizComposer, User i_LoggedInUser)
        {
            FriendQuizForm friendQuizForm = new FriendQuizForm(
                i_QuizComposer.Friend,
                i_LoggedInUser,
                i_QuizComposer.IsReading,
                i_QuizComposer.QuestionsAmount,
                i_QuizComposer.QuestionTime);

            return friendQuizForm;
        }
    }
}
