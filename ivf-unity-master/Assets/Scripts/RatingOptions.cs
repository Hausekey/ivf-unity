using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class RatingOptions : MonoBehaviour {
    public Text[] _emotions;
    public NumberRatings[] _correspondingRatings;
    public int number_of_emotions;
    // Use this for initialization
    void Start () {
        string[] names = new string[] { "Worried", "Anxious", "Agitated", "Happy", "Angry", "Frustrated" };
        setText(names);
    }

    public void setText(string[] names)
    {
        for (int i = 0; i < number_of_emotions; i++)
        {
            _emotions[i].text = names[i];
            _correspondingRatings[i].setInt();
        }
    }

}
