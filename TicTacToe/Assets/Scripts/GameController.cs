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
    public Button button;
}
public class GameController : MonoBehaviour {
    public Player playerX;
    public GameObject startInfo;
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
        gameOverPanel.SetActive(false);
        SetGameControllerReferenceOnButtons();
        restartButton.SetActive(false);
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
            SetPlayerColorsInactive();
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
        StartGame();
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

    void SetPlayerButtons(bool toggle)
    {
        playerX.button.interactable = toggle;
        playerO.button.interactable = toggle;
    }
    public void RestartGame()
    {
        moveCount = 0;
        gameOverPanel.SetActive(false);
        
        for (int i = 0; i < 9; i++)
        {
            buttonList[i].text = "";
        }
        SetPlayerButtons(true);
        startInfo.SetActive(true);
        SetPlayerColorsInactive();
        restartButton.SetActive(false);
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
}
