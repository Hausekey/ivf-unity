using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreateSurvey : MonoBehaviour {
	public Text myText;
    public void insertQuestion()
    {
        for (int y = 0; y < 5; y++)
        {
            GameObject 
        }
    }
	public void setText(string text) {
		if (myText == null) {
			myText = gameObject.GetComponent<Text> ();
			if (myText == null) {
				myText = gameObject.AddComponent<Text> ();
			}

		}
		myText.text = text;
	}
		
	// Use this for initialization
	void Start () {
		
		setText ("hello" + "\n" + "I'm jackie" + "<h1>Hi</h1>");
		//setText ("hi");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
