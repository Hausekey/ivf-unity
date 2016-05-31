using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class toggleButton : MonoBehaviour
{
    public int i = 0;
    public Button button;
    public Text buttonText;
    public string playerSide;
    public Color on;
    public Color off;
    void Start()
    {
        off = button.colors.normalColor;
        on = button.colors.highlightedColor;
    }

    public void SetSpace()
    {
        ColorBlock cb = button.GetComponent<Button> ().colors;
        button.colors = cb;
        buttonText.text = playerSide;

        if (i == 0)
        {
            cb.normalColor = on;
            cb.highlightedColor = on;
            button.colors = cb;
            i = 1;
            buttonText.text = i.ToString();
        }
        else
        {
            cb.normalColor = off;
            cb.highlightedColor = off;
            button.colors = cb;
            i = 0;
            buttonText.text = i.ToString();
        }


    }
}
