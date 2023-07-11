using System;
using System.Collections.Generic;

public class QuestionStorage
{
    public List<Question> Questions;


    public static List<Question> GetQuestions()

    {
        var questions = new List<Question>();

        questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
        questions.Add(new Question("Бревно нужно распилить на 10 частей, Сколько нужно сделать распилов?", 9));
        questions.Add(new Question("На двух руках 10 пальцев  (Сколько пальцев на 5 руках?)", 25));
        questions.Add(new Question("Укол делают каждые пол часа  Сколько нужно минут для 3 уколов?", 60));
        questions.Add(new Question("Пять свечей сгорело  Две потухли  Сколько свечей осталось?", 2));

        return questions;
    }

    //public static string EnterNewQuestion()
    //{

    //    while (true)
    //    {

    //        try
    //        {

    //            return userAnswerTextBox.Text;



    //        }

    //        catch (FormatException)
    //        {

    //            //Console.WriteLine($"Введите текст вопроса");
    //            //Console.WriteLine();

    //        }

    //        catch (OverflowException)
    //        {
    //            //Console.WriteLine();
    //            //Console.WriteLine($"Введите текст вопроса");
    //        }
    //    }

    //}

    

    public static int GetNumber()
    {


        while (true)
        {

            try
            {


                return Convert.ToInt32(Console.ReadLine());

            }

            catch (FormatException)
            {

                //Console.WriteLine("ВВЕДИТЕ ЧИСЛО!");
                //Console.WriteLine();

            }

            catch (OverflowException)
            {
                //Console.WriteLine();
                //Console.WriteLine("ВВЕДИТЕ ЧИСЛО от -2*10^-9 до 2*10^9");
            }
        }

    }


}






