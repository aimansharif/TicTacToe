using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToe_script : MonoBehaviour {

    public Text [] buttonTextList;
    public Text Result; 
    public Button[] ButtonList;
    public Text Player1Text;
    public Text Player2Text;
    public AudioSource ClickAudioSource;
    public AudioSource WinAudioSource;
    public AudioSource DrawAudioSource;
    public Image Player1Image;
    public Image Player2Image;
    public bool VsPlayer;

    public void IsVsPlayer()
    {
        VsPlayer = true;
        Player1Image.GetComponent<Image>().color = Color.green;
    }

    public void IsComputer()
    {
        Player1Image.GetComponent<Image>().color = Color.green;
    }

    public void OnClickButton_1(Button button)
    {
        IsPlayer1(button.gameObject.transform.GetChild(0).GetComponent<Text>());
        ButtonClick();
        button.interactable = false;  
        if (!IsInvoking("NextMove"))
            Invoke("NextMove", 1f);
    }

    public void OnClickButton_2(Button button)
    {
        IsPlayer1(button.gameObject.transform.GetChild(0).GetComponent<Text>());
        ButtonClick();
        button.interactable = false;
        if (!IsInvoking("NextMove"))
            Invoke("NextMove", 1f);
        
    }

    public void OnClickButton_3(Button button)
    {
        IsPlayer1(button.gameObject.transform.GetChild(0).GetComponent<Text>());
        ButtonClick();
        button.interactable = false;
        if (!IsInvoking("NextMove"))
            Invoke("NextMove", 1f);
    }

    public void OnClickButton_4(Button button)
    {
        IsPlayer1(button.gameObject.transform.GetChild(0).GetComponent<Text>());
        ButtonClick();
        button.interactable = false;
        if (!IsInvoking("NextMove"))
            Invoke("NextMove", 1f);   
    }

    public void OnClickButton_5(Button button)
    {
        IsPlayer1(button.gameObject.transform.GetChild(0).GetComponent<Text>());
        ButtonClick();
        button.interactable = false;
        if (!IsInvoking("NextMove"))
            Invoke("NextMove", 1f);
    }

    public void OnClickButton_6(Button button)
    {
        IsPlayer1(button.gameObject.transform.GetChild(0).GetComponent<Text>());
        ButtonClick();
        button.interactable = false;
        if (!IsInvoking("NextMove"))
            Invoke("NextMove", 1f);
    }

    public void OnClickButton_7(Button button)
    {
        IsPlayer1(button.gameObject.transform.GetChild(0).GetComponent<Text>());
        ButtonClick();
        button.interactable = false;
        if (!IsInvoking("NextMove"))
            Invoke("NextMove", 1f);
    }

    public void OnClickButton_8(Button button)
    {
        IsPlayer1(button.gameObject.transform.GetChild(0).GetComponent<Text>());
        ButtonClick();
        button.interactable = false;
        if (!IsInvoking("NextMove"))
            Invoke("NextMove", 1f);
    }

    public void OnClickButton_9(Button button)
    {
        IsPlayer1(button.gameObject.transform.GetChild(0).GetComponent<Text>());
        ButtonClick();
        button.interactable = false;
        if (!IsInvoking("NextMove"))
            Invoke("NextMove", 1f);
    }
    
    private void ButtonClick()
    {
        IsWinner();
        PlayerTurn();
        IsDrawGame();
        DisplayPlayer();
        IsWinnerPlayer();
    }

    public void IsWinner()
    {
        ClickAudioSource.Play();

        if (buttonTextList[0].text == "X" && buttonTextList[1].text == "X" && buttonTextList[2].text == "X")
        {
            Result.text = "Player 1 Wins";
            isWin = true;
        }

        else if (buttonTextList[0].text == "O" && buttonTextList[1].text == "O" && buttonTextList[2].text == "O")
        {
            Result.text = "Player 2 Wins";
            isWin = true;
        }

        if (buttonTextList[0].text == "X" && buttonTextList[3].text == "X" && buttonTextList[6].text == "X")
        {
            Result.text = "Player 1 Wins";
            isWin = true;

        }

        else if (buttonTextList[0].text == "O" && buttonTextList[3].text == "O" && buttonTextList[6].text == "O")
        {
            Result.text = "Player 2 Wins";
            isWin = true;
        }

        if (buttonTextList[0].text == "X" && buttonTextList[4].text == "X" && buttonTextList[8].text == "X")
        {
            Result.text = "Player 1 Wins";
            isWin = true;
        }

        else if (buttonTextList[0].text == "O" && buttonTextList[4].text == "O" && buttonTextList[8].text == "O")
        {
            Result.text = "Player 2 Wins";
            isWin = true;
        }

        if (buttonTextList[1].text == "X" && buttonTextList[4].text == "X" && buttonTextList[7].text == "X")
        {
            Result.text = "Player 1 Wins";
            isWin = true;
        }

        else if (buttonTextList[1].text == "O" && buttonTextList[4].text == "O" && buttonTextList[7].text == "O")
        {
            Result.text = "Player 2 Wins";
            isWin = true;

        }

        if (buttonTextList[2].text == "X" && buttonTextList[5].text == "X" && buttonTextList[8].text == "X")
        {
            Result.text = "Player 1 Wins";
            isWin = true;

        }

        else if (buttonTextList[2].text == "O" && buttonTextList[5].text == "O" && buttonTextList[8].text == "O")
        {
            Result.text = "Player 2 Wins";
            isWin = true;

        }

        if (buttonTextList[3].text == "X" && buttonTextList[4].text == "X" && buttonTextList[5].text == "X")
        {
            Result.text = "Player 1 Wins";
            isWin = true;
        }

        else if (buttonTextList[3].text == "O" && buttonTextList[4].text == "O" && buttonTextList[5].text == "O")
        {
            Result.text = "Player 2 Wins";
            isWin = true;
        }

        if (buttonTextList[0].text == "X" && buttonTextList[1].text == "X" && buttonTextList[2].text == "X")
        {
            Result.text = "Player 1 Wins";
            isWin = true;

        }

        else if (buttonTextList[0].text == "O" && buttonTextList[1].text == "O" && buttonTextList[2].text == "O")
        {
            Result.text = "Player 2 Wins";
            isWin = true;
        }

        if (buttonTextList[6].text == "X" && buttonTextList[7].text == "X" && buttonTextList[8].text == "X")
        {
            Result.text = "Player 1 Wins";
            isWin = true;
        }

        else if (buttonTextList[6].text == "O" && buttonTextList[7].text == "O" && buttonTextList[8].text == "O")
        {
            Result.text = "Player 2 Wins";
            isWin = true;
        }

        if (buttonTextList[2].text == "X" && buttonTextList[4].text == "X" && buttonTextList[6].text == "X")
        {
            Result.text = "Player 1 Wins";
            isWin = true;
        }

        else if (buttonTextList[2].text == "O" && buttonTextList[4].text == "O" && buttonTextList[6].text == "O")
        {
            Result.text = "Player 2 Wins";
            isWin = true;
        }
    }

    bool isPlayerOne = true;

    //Changes turns for player 1 and player 2

    public void IsPlayer1(Text buttonText)
    {

        if (isPlayerOne)
        {
            buttonText.text = "X";
            Debug.Log("Player1: " + isPlayerOne);
            isPlayerOne = false;

            return;
        }

        if (!isPlayerOne)
        {
            buttonText.text = "O";
            Debug.Log("Player1: " + isPlayerOne);
            isPlayerOne = true;

            return;
        }
    }

    //Displays whether it is the turn of Player1 or Player2

    public void PlayerTurn()
    {
        if(isPlayerOne)
        {
            Player2Image.GetComponent<Image>().color = Color.white;
            Debug.Log("Turn of Player1");
            Player1Text.text = "Player 1: X";
            Player1Image.GetComponent<Image>().color = Color.green;

        }
        
        else
        {
            Player1Image.GetComponent<Image>().color = Color.white;

            Debug.Log("Turn of Player2");
            Player2Text.text = "Player 2: O";
            Player2Image.GetComponent<Image>().color = Color.green;
        }
        
    }

    //Checks whether player 1 or player 2 is the winner

    public bool isWin;
    public bool PlayerWinner;

    public void IsWinnerPlayer()
    {
        IsWinner();
        if(isWin == true)
        {
            Player1Text.text = "";
            Player2Text.text = "";
            EndGame();
            PlayerWinner = true;
            WinAudioSource.Play();
            Player1Image.GetComponent<Image>().color = Color.gray;
            Player2Image.GetComponent<Image>().color = Color.gray;

        }
    }

    //Restarts the game and enables all buttons to be interactable 
    //Player one starts with "X"

    public void RestartGame()
    {
        index = 0;
        int i;
        for (i = 0; i < buttonTextList.Length; i++)
        {
            buttonTextList[i].text = "";
            ButtonList[i].interactable = true;
            isPlayerOne = true;
        }
        Result.text = "";

        Player1Text.text = "Player 1: X";
        Player2Text.text = "Player 2: O";
        PlayerWinner = false;
        isWin = false;
        Player1Image.GetComponent<Image>().color = Color.gray;
        Player2Image.GetComponent<Image>().color = Color.gray;
        VsPlayer = false;

        isDraw = false;
    }
    
    //Disable all buttons when game ends

    public void EndGame()
    {
        index = 0;
        for (int i = 0; i < ButtonList.Length; i++)
        {
            ButtonList[i].interactable = false;
        }
    }
    public bool isDraw;
    public void IsDrawGame()
    {
        for (int i = 0; i < buttonTextList.Length; i++)
        {
            if (buttonTextList[i].text == "")
            {
                return;
            }
        }

        if (!isWin)
        {
            Debug.Log("Game is drawn");
            Result.text = "Draw!";

            Player1Text.text = "";
            Player2Text.text = "";
            DrawAudioSource.Play();
            isDraw = true;
            Player1Image.GetComponent<Image>().color = Color.gray;
            Player2Image.GetComponent<Image>().color = Color.gray;

        }
    }
    
    //Displays whether it is Player 1 or Player 2's turn

    public void DisplayPlayer()
    {
        if(PlayerWinner == true)
        {
            Player1Text.text = "";
            Player2Text.text = "";
        }
    }

    List<int> list = new List<int>();
    int index;

    public void NextMove()
    {

        if (isWin || isDraw || VsPlayer)
        {
            return;
        }

        Player1Image.GetComponent<Image>().color = Color.green;

        list.Clear();

        for (int i = 0; i < buttonTextList.Length; i++)
        {
            if (buttonTextList[i].text == "")
            {
                list.Add(i) ;
            }
        }

        Debug.Log("List size: " + list.Count);

        if (list.Count < 1)
        {
            index = 0;
        }
        else
        {
            int randomNumber = UnityEngine.Random.Range(0, list.Count);
            Debug.Log("Random number: " + randomNumber);

            index = list[randomNumber];
        }

        buttonTextList[index].text = "O" ;
        ButtonList[index].interactable = false;
        isPlayerOne = true;
        PlayerTurn();


        IsWinner();
        if (isWin)
        {
            Player1Text.text = "";
            Player2Text.text = "";
            EndGame();
            WinAudioSource.Play();
            Player1Image.GetComponent<Image>().color = Color.gray;
            Player2Image.GetComponent<Image>().color = Color.gray;

            return;
        }

        for (int j = 0; j < list.Count; j++)
        {
            Debug.Log(list[j]);
        }
    }
}