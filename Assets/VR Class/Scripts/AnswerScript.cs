using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;
    public GameObject dung;
    public GameObject sai;
    public void Answers()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            quizManager.Correct();
            dung.SetActive(true);
            sai.SetActive(false);
        }
        else
        {
            Debug.Log("Wrong");
             quizManager.Correct();
            dung.SetActive(false);
            sai.SetActive(true);
        }
    }
}
