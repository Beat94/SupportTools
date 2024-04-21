public class Answer
{   
    public string answerString{get;set;}
    public AnswerType answerType{get;set;}

    public Answer(string answerString, AnswerType? answerType)
    {
        this.answerString = answerString;
        this.answerType = answerType;
    }
}