using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Logic : MonoBehaviour
{
    Boolean checker;
    int plusOne;

    public Text btnTxt1 = null;
    public Text btnTxt2 = null;
    public Text btnTxt3 = null;
    public Text btnTxt4 = null;
    public Text btnTxt5 = null;
    public Text btnTxt6 = null;
    public Text btnTxt7 = null;
    public Text btnTxt8 = null;
    public Text btnTxt9 = null;
    public Text btnTxtNG = null;
    public Text btnTxtRS = null;
    public Text txtFeedBack = null;
    public Text playerXTxt = null;
    public Text playerOTxt = null;
    Button[] buttons;

    void Start()
    {
        
        SetButtons();
    }

    void SetButtons()
    {
         buttons = new Button[9];
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i] = GameObject.Find("Btn" + (i+1)).GetComponent<Button>();
            buttons[i].interactable = true;
              //changing all text in buttons
            Text buttonText = buttons[i].GetComponentInChildren<Text>();
            buttonText.color = Color.black;
        }
    }

    //checks the combination and the text then decides the winner
    private void WinningPattern(Text firstButtonTxt, Text secondButtonTxt, Text thirdButtonTxt, string choice)
    {
        Color purple = new Color(0.8f, 0.2f, 0.8f);
        if (firstButtonTxt.text.Equals(secondButtonTxt.text) && secondButtonTxt.text.Equals(thirdButtonTxt.text) && thirdButtonTxt.text.Equals(choice) && choice.Equals("X"))
        {
            firstButtonTxt.color = purple;
            secondButtonTxt.color = purple;
            thirdButtonTxt.color = purple;
            int.TryParse(playerXTxt.text, out plusOne);
            playerXTxt.text = Convert.ToString(plusOne + 1);
            Disable_Buttons();

        }else if (firstButtonTxt.text.Equals(secondButtonTxt.text) && secondButtonTxt.text.Equals(thirdButtonTxt.text) && thirdButtonTxt.text.Equals(choice) && choice.Equals("O"))
        {
            firstButtonTxt.color = Color.green;
            secondButtonTxt.color = Color.green;
            thirdButtonTxt.color = Color.green;
            int.TryParse(playerOTxt.text, out plusOne);
            playerOTxt.text = Convert.ToString(plusOne + 1);
            Disable_Buttons();
        }
        txtFeedBack.text = "Player " + choice + " wins!";
    }


    //
    public void Score()
    {
        //======================= Player X ===================================
        WinningPattern(btnTxt1, btnTxt2, btnTxt3, "X");
        WinningPattern(btnTxt4, btnTxt5, btnTxt6, "X");
        WinningPattern(btnTxt7, btnTxt8, btnTxt9, "X");
        WinningPattern(btnTxt1, btnTxt4, btnTxt7, "X");
        WinningPattern(btnTxt2, btnTxt5, btnTxt8, "X");
        WinningPattern(btnTxt3, btnTxt6, btnTxt9, "X");
        WinningPattern(btnTxt1, btnTxt5, btnTxt9, "X");
        WinningPattern(btnTxt3, btnTxt5, btnTxt7, "X");

        //======================= Player O ===================================
        WinningPattern(btnTxt1, btnTxt2, btnTxt3, "O");
        WinningPattern(btnTxt4, btnTxt5, btnTxt6, "O");
        WinningPattern(btnTxt7, btnTxt8, btnTxt9, "O");
        WinningPattern(btnTxt1, btnTxt4, btnTxt7, "O");
        WinningPattern(btnTxt2, btnTxt5, btnTxt8, "O");
        WinningPattern(btnTxt3, btnTxt6, btnTxt9, "O");
        WinningPattern(btnTxt1, btnTxt5, btnTxt9, "O");
        WinningPattern(btnTxt3, btnTxt5, btnTxt7, "O");
    }

    public void Button1_Click()
    {
        if (checker == false)
        {
            btnTxt1.text = "X";
            checker = true;
        }
        else
        {
            btnTxt1.text = "O";
            checker = false;
        }
        Score();
      
    }


    public void Button2_Click()
    {
        if (checker == false)
        {
            btnTxt2.text = "X";
            checker = true;
        }
        else
        {
            btnTxt2.text = "O";
            checker = false;
        }
        Score();
        
    }

    public void Button3_Click()
    {
        if (checker == false)
        {
            btnTxt3.text = "X";
            checker = true;
        }
        else
        {
            btnTxt3.text = "O";
            checker = false;
        }
        Score();
       
    }

    public void Button4_Click()
    {
        if (checker == false)
        {
            btnTxt4.text = "X";
            checker = true;
        }
        else
        {
            btnTxt4.text = "O";
            checker = false;
        }
        Score();
     
    }

    public void Button5_Click()
    {
        if (checker == false)
        {
            btnTxt5.text = "X";
            checker = true;
        }
        else
        {
            btnTxt5.text = "O";
            checker = false;
        }
        Score();
  
    }

    public void Button6_Click()
    {
        if (checker == false)
        {
            btnTxt6.text = "X";
            checker = true;
        }
        else
        {
            btnTxt6.text = "O";
            checker = false;
        }
        Score();
   
    }

    public void Button7_Click()
    {
        if (checker == false)
        {
            btnTxt7.text = "X";
            checker = true;
        }
        else
        {
            btnTxt7.text = "O";
            checker = false;
        }
        Score();
      
    }

    public void Button8_Click()
    {
        if (checker == false)
        {
            btnTxt8.text = "X";
            checker = true;
        }
        else
        {
            btnTxt8.text = "O";
            checker = false;
        }
        Score();
    }

    public void Button9_Click()
    {
        if (checker == false)
        {
            btnTxt9.text = "X";
            checker = true;
        }
        else
        {
            btnTxt9.text = "O";
            checker = false;
        }
        Score();
    }

    //resetting everything to a completely new game
    public void NewGame()
    {
        playerXTxt.text = "0";
        playerOTxt.text = "0";
        ResetGame();
    }

    //reseting the board but retaimning previous score
    public void ResetGame()
    {
        btnTxt1.text = null;
        btnTxt2.text = null;
        btnTxt3.text = null;
        btnTxt4.text = null;
        btnTxt5.text = null;
        btnTxt6.text = null;
        btnTxt7.text = null;
        btnTxt8.text = null;
        btnTxt9.text = null;
        txtFeedBack.text = null;

        if (checker == true)
        {
            checker = false;
        }
        SetButtons();
    }

    //loading all buttons and making the unclicable
    public void Disable_Buttons()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i] = GameObject.Find("Btn" + (i+1)).GetComponent<Button>();
            buttons[i].interactable = false;
        }
    }
}
