using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[System.Serializable]
public class PlayerColor
{
    public Color panelColor;
    public Color textColor;
}

[System.Serializable]
public class Player
{
    public Image panel;
    public Text text;
<<<<<<< HEAD
    public Button button;
}
public class GameController : MonoBehaviour {
    public Player playerX;
    public GameObject startInfo;
=======
}
public class GameController : MonoBehaviour {
    public Player playerX;
>>>>>>> 6abe9c39f1542053fb011943f4f0fe591f85e9ef
    public Player playerO;
    public PlayerColor activePlayerColor;
    public PlayerColor inactivePlayerColor;
    public Text[] buttonList;
    private string playerSide;
    public GameObject gameOverPanel;
    public Text gameOverText;
    private int moveCount;
    public GameObject restartButton;
    void SetGameControllerReferenceOnButtons()
    {
        for (int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].GetComponentInParent<GridSpace>().SetGameControllerReference(this);
        }
    }

    void Awake()
    {
        moveCount = 0;
<<<<<<< HEAD
        gameOverPanel.SetActive(false);
        SetGameControllerReferenceOnButtons();
        restartButton.SetActive(false);
=======
        playerSide = "X";
        gameOverPanel.SetActive(false);
        SetGameControllerReferenceOnButtons();
        restartButton.SetActive(false);
        SetPlayerColors(playerX, playerO);
>>>>>>> 6abe9c39f1542053fb011943f4f0fe591f85e9ef
    }

    public string GetPlayerSide()
    {
        return playerSide;
    }

    void GameOver(string winningPlayer)
    {
        SetBoardInteractable(false);
        if(winningPlayer == "draw")
        {
            SetGameOverText("It's a draw!");
<<<<<<< HEAD
            SetPlayerColorsInactive();
=======
>>>>>>> 6abe9c39f1542053fb011943f4f0fe591f85e9ef
        }
        else
        {
            SetGameOverText(winningPlayer + " Wins!");

        }
        restartButton.SetActive(true);
    }

    public void EndTurn()
    {
        moveCount++;
        //top row
        if (buttonList[0].text == playerSide && buttonList[1].text == playerSide && buttonList[2].text == playerSide)
        {
            GameOver(playerSide);
        }

        else if (buttonList[3].text == playerSide && buttonList[4].text == playerSide && buttonList[5].text == playerSide)
        {
            GameOver(playerSide);
        }

        else if (buttonList[6].text == playerSide && buttonList[7].text == playerSide && buttonList[8].text == playerSide)
        {
            GameOver(playerSide);
        }

        else if (buttonList[0].text == playerSide && buttonList[3].text == playerSide && buttonList[6].text == playerSide)
        {
            GameOver(playerSide);
        }

        else if(buttonList[1].text == playerSide && buttonList[4].text == playerSide && buttonList[7].text == playerSide)
        {
            GameOver(playerSide);
        }

        else if(buttonList[2].text == playerSide && buttonList[5].text == playerSide && buttonList[8].text == playerSide)
        {
            GameOver(playerSide);
        }

        else if(buttonList[0].text == playerSide && buttonList[4].text == playerSide && buttonList[8].text == playerSide)
        {
            GameOver(playerSide);
        }

        else if(buttonList[2].text == playerSide && buttonList[4].text == playerSide && buttonList[6].text == playerSide)
        {
            GameOver(playerSide);
        }

        else if(moveCount >= 9)
        {
            GameOver("draw");
        }
        else {
            ChangeSides();
        }
        
    }

    public void SetStartingSide(string startingSide)
    {
        playerSide = startingSide;
        if(playerSide == "X")
        {
            SetPlayerColors(playerX, playerO);
        }
        else
        {
            SetPlayerColors(playerO, playerX);
        }
<<<<<<< HEAD
        StartGame();
=======
>>>>>>> 6abe9c39f1542053fb011943f4f0fe591f85e9ef
    }

    void ChangeSides()
    {
        playerSide = (playerSide == "X") ? "O" : "X";
        if (playerSide == "X")
        {
            SetPlayerColors(playerX, playerO);
        }
        else
        {
            SetPlayerColors(playerO, playerX);
        }
    }

    void SetGameOverText(string value)
    {
        gameOverPanel.SetActive(true);
        gameOverText.text =  value;
    }

<<<<<<< HEAD
    void SetPlayerButtons(bool toggle)
    {
        playerX.button.interactable = toggle;
        playerO.button.interactable = toggle;
    }
    public void RestartGame()
    {
        moveCount = 0;
        gameOverPanel.SetActive(false);
        
=======
    public void RestartGame()
    {
        playerSide = "X";
        moveCount = 0;
        gameOverPanel.SetActive(false);
        SetBoardInteractable(true);
>>>>>>> 6abe9c39f1542053fb011943f4f0fe591f85e9ef
        for (int i = 0; i < 9; i++)
        {
            buttonList[i].text = "";
        }
<<<<<<< HEAD
        SetPlayerButtons(true);
        startInfo.SetActive(true);
        SetPlayerColorsInactive();
        restartButton.SetActive(false);
=======
        restartButton.SetActive(false);
        SetPlayerColors(playerX, playerO);
>>>>>>> 6abe9c39f1542053fb011943f4f0fe591f85e9ef
    }

    void SetBoardInteractable (bool toggle)
    {
        for (int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].GetComponentInParent<Button>().interactable = toggle;
        }
    }

    void SetPlayerColors (Player newPlayer, Player oldPlayer)
    {
        newPlayer.panel.color = activePlayerColor.panelColor;
        newPlayer.text.color = activePlayerColor.textColor;
        oldPlayer.panel.color = inactivePlayerColor.panelColor;
        oldPlayer.text.color = inactivePlayerColor.textColor;
    }
<<<<<<< HEAD

    void StartGame()
    {
        SetBoardInteractable(true);
        startInfo.SetActive(false);
        SetPlayerButtons(false);
    }
    void SetPlayerColorsInactive()
    {
        playerX.panel.color = inactivePlayerColor.panelColor;
        playerX.text.color = inactivePlayerColor.textColor;
        playerO.panel.color = inactivePlayerColor.panelColor;
        playerO.text.color = inactivePlayerColor.textColor;
    }
=======
  
>>>>>>> 6abe9c39f1542053fb011943f4f0fe591f85e9ef
}
