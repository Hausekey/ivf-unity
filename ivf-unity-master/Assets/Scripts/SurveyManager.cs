using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;


public class SurveyManager : MonoBehaviour {

    public Question[] questions;
    private static List<Question> unansweredQuestions;

    private Question currentQuestion;

    [SerializeField]
    private Text questionText;

    [SerializeField]
    private float timeBetweenQuestions = 1f;
	// Use this for initialization
	void Start () {
        if(unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }

        SetCurrentQuestion();
        Debug.Log(currentQuestion.question + " is " + currentQuestion.isTrue);
	}
	
    void SetCurrentQuestion()
    {
        int QuestionIndex = 0;
        currentQuestion = unansweredQuestions[QuestionIndex];

        questionText.text = currentQuestion.question;
    }

    IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestions.RemoveAt(currentQuestion);
        yield return new WaitForSeconds(timeBetweenQuestions);

    }

    public void UserSelectTrue()
    {
        if (currentQuestion.isTrue)
        {
            Debug.Log("You selected True. That's positive");
        }
        else
        {
            Debug.Log("False. That's negative");
        }
    }

    public void UserSelectFalse()
    {
        if (!currentQuestion.isTrue)
        {
            Debug.Log("You selected False. That's positive");
        }
        else
        {
            Debug.Log("True. That's negative");
        }
    }
}
