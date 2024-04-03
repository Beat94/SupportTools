internal class ShortAnswerData
{
    AnswerType answerType = new();
    List<Answer> shortAnswers = new List<Answer>();
    
    internal void addAnswer(string answerString, AnswerType answerType)
    {
        shortAnswers.Add(new Answer(answerString, answerType));
    }

    internal void delAnswer(int index)
    {
        shortAnswers.RemoveAt(index);
    }

    internal List<Answer> getAnswerList()
    {
        return shortAnswers;
    }
}