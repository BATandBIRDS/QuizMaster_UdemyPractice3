using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// when you create new scriptable object like:
// [Assets (right click) / Create]
// its name and new created file' name: below
[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]

public class QuestionSO : ScriptableObject
{
    // [TextArea(min row size, max row size)]
    [TextArea(2, 6)] // Text space to enter for serialized field. UX purposes.

    [SerializeField] string question = "Enter new question txt here.";

    // The 4 choices in test
    // answers* array has 4* string* variables.
    [SerializeField] string[] answers = new string[4];

    [SerializeField] int correctAnswerIndex;

    public string GetQuestion()
    {
        return question;
    }

    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }

    public string GetAnswer(int index)
    {
        return answers[index];
    }

}

//                        How we get questionText:
//public class Test
//{
//    QuestionSO questionSO;

//    void Test()
//    {
//        string questionText = questionSO.GetQuestion();
//    }
//}
