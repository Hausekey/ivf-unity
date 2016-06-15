using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberRatings : MonoBehaviour
{
    public Button[] _ratingOptions;
    public int number_of_ratings;

    public void Awake()
    {
        setInt();
//work on this later!
        
    }

    public void setInt()
    {
        for(int i = 0; i < number_of_ratings; i++){
            _ratingOptions[i].GetComponentInChildren<Text>().text = (i + 1).ToString();
        }

        
    }



}