using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[System.Serializable]
public class Question {
    public string question;
    public bool isTrue;
    private int id;

    public void setId(int i)
    {
        id = i;
    }
}