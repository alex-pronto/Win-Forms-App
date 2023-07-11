using System.Xml.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;



public class Question
{

    public string Text;
    public int Answer;
    //public int Number;

    public Question(string text, int answer)
    {

        Text = text;
        Answer = answer;
    }

    //public Question(int number)
    //{
    //    Number = number;
    //}

    //public void SetNewNumber(int number)
    //{
    //    Number = number;
    //}



}



