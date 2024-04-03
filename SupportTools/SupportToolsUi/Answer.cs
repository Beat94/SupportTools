internal class Answer
{   
    internal string answerString{get;set;}
    internal AnswerType answerType{get;set;}

    internal Answer(string answerString, AnswerType answerType)
    {
        this.answerString = answerString;
        this.answerType = answerType;
    }
}