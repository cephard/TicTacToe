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


    void SetButtons()
    {
         buttons = new Button[10];
        for (int i = 1; i <= buttons.Length; i++)
        {
            buttons[i] = GameObject.Find("Btn" + i).GetComponent<Button>();
            buttons[i].interactable = true;
        }
    }



    public void Score()
    {
        //======================= Player X ===================================
        if (btnTxt1.text == "X" && btnTxt2.text == "X" && btnTxt3.text == "X") // Row 1
        {
            btnTxt1.color = Color.red;
            btnTxt2.color = Color.red;
            btnTxt3.color = Color.red;
            txtFeedBack.text = "Player X wins";
            int.TryParse(playerXTxt.text, out plusOne);
            playerXTxt.text = Convert.ToString(plusOne + 1);
            Disable_Buttons();
        }
        if (btnTxt4.text == "X" && btnTxt5.text == "X" && btnTxt6.text == "X") // Row 2
        {
            btnTxt4.color = Color.red;
            btnTxt5.color = Color.red;
            btnTxt6.color = Color.red;
            txtFeedBack.text = "Player X wins";
           int.TryParse(playerXTxt.text, out plusOne);
            playerXTxt.text = Convert.ToString(plusOne + 1);
        }
        if (btnTxt7.text == "X" && btnTxt8.text == "X" && btnTxt9.text == "X") // Row 3
        {
            btnTxt7.color = Color.red;
            btnTxt8.color = Color.red;
            btnTxt9.color = Color.red;
            txtFeedBack.text = "Player X wins";
           int.TryParse(playerXTxt.text, out plusOne);
            playerXTxt.text = Convert.ToString(plusOne + 1);
        }
        if (btnTxt1.text == "X" && btnTxt4.text == "X" && btnTxt7.text == "X") // Column 1
        {
            btnTxt1.color = Color.red;
            btnTxt4.color = Color.red;
            btnTxt7.color = Color.red;
            txtFeedBack.text = "Player X wins";
           int.TryParse(playerXTxt.text, out plusOne);
            playerXTxt.text = Convert.ToString(plusOne + 1);
        }
        if (btnTxt2.text == "X" && btnTxt5.text == "X" && btnTxt8.text == "X") // Column 2
        {
            btnTxt2.color = Color.red;
            btnTxt5.color = Color.red;
            btnTxt8.color = Color.red;
            txtFeedBack.text = "Player X wins";
           int.TryParse(playerXTxt.text, out plusOne);
            playerXTxt.text = Convert.ToString(plusOne + 1);
        }
        if (btnTxt3.text == "X" && btnTxt6.text == "X" && btnTxt9.text == "X") // Column 3
        {
            btnTxt3.color = Color.red;
            btnTxt6.color = Color.red;
            btnTxt9.color = Color.red;
            txtFeedBack.text = "Player X wins";
           int.TryParse(playerXTxt.text, out plusOne);
            playerXTxt.text = Convert.ToString(plusOne + 1);
        }
        if (btnTxt1.text == "X" && btnTxt5.text == "X" && btnTxt9.text == "X") // Diagonal 1
        {
            btnTxt1.color = Color.red;
            btnTxt5.color = Color.red;
            btnTxt9.color = Color.red;
            txtFeedBack.text = "Player X wins";
           int.TryParse(playerXTxt.text, out plusOne);
            playerXTxt.text = Convert.ToString(plusOne + 1);
        }
        if (btnTxt3.text == "X" && btnTxt5.text == "X" && btnTxt7.text == "X") // Diagonal 2
        {
            btnTxt3.color = Color.red;
            btnTxt5.color = Color.red;
            btnTxt7.color = Color.red;
            txtFeedBack.text = "Player X wins";
           int.TryParse(playerXTxt.text, out plusOne);
            playerXTxt.text = Convert.ToString(plusOne + 1);
        }

        //======================= Player O ===================================
        if (btnTxt1.text == "O" && btnTxt2.text == "O" && btnTxt3.text == "O") // Row 1
        {
            btnTxt1.color = Color.red;
            btnTxt2.color = Color.red;
            btnTxt3.color = Color.red;
            txtFeedBack.text = "Player O wins";
            int.TryParse(playerOTxt.text, out plusOne);
            playerOTxt.text = Convert.ToString(plusOne + 1);
        }
        if (btnTxt4.text == "O" && btnTxt5.text == "O" && btnTxt6.text == "O") // Row 2
        {
            btnTxt4.color = Color.red;
            btnTxt5.color = Color.red;
            btnTxt6.color = Color.red;
            txtFeedBack.text = "Player O wins";
            int.TryParse(playerOTxt.text, out plusOne);
            playerOTxt.text = Convert.ToString(plusOne + 1);
        }
        if (btnTxt7.text == "O" && btnTxt8.text == "O" && btnTxt9.text == "O") // Row 3
        {
            btnTxt7.color = Color.red;
            btnTxt8.color = Color.red;
            btnTxt9.color = Color.red;
            txtFeedBack.text = "Player O wins";
            int.TryParse(playerOTxt.text, out plusOne);
            playerOTxt.text = Convert.ToString(plusOne + 1);
        }
        if (btnTxt1.text == "O" && btnTxt4.text == "O" && btnTxt7.text == "O") // Column 1
        {
            btnTxt1.color = Color.red;
            btnTxt4.color = Color.red;
            btnTxt7.color = Color.red;
            txtFeedBack.text = "Player O wins";
            int.TryParse(playerOTxt.text, out plusOne);
            playerOTxt.text = Convert.ToString(plusOne + 1);
        }
        if (btnTxt2.text == "O" && btnTxt5.text == "O" && btnTxt8.text == "O") // Column 2
        {
            btnTxt2.color = Color.red;
            btnTxt5.color = Color.red;
            btnTxt8.color = Color.red;
            txtFeedBack.text = "Player O wins";
            int.TryParse(playerOTxt.text, out plusOne);
            playerOTxt.text = Convert.ToString(plusOne + 1);
        }
        if (btnTxt3.text == "O" && btnTxt6.text == "O" && btnTxt9.text == "O") // Column 3
        {
            btnTxt3.color = Color.red;
            btnTxt6.color = Color.red;
            btnTxt9.color = Color.red;
            txtFeedBack.text = "Player O wins";
            int.TryParse(playerOTxt.text, out plusOne);
            playerOTxt.text = Convert.ToString(plusOne + 1);
        }
        if (btnTxt1.text == "O" && btnTxt5.text == "O" && btnTxt9.text == "O") // Diagonal 1
        {
            btnTxt1.color = Color.red;
            btnTxt5.color = Color.red;
            btnTxt9.color = Color.red;
            txtFeedBack.text = "Player O wins";
            int.TryParse(playerOTxt.text, out plusOne);
            playerOTxt.text = Convert.ToString(plusOne + 1);
        }
        if (btnTxt3.text == "O" && btnTxt5.text == "O" && btnTxt7.text == "O") // Diagonal 2
        {
            btnTxt3.color = Color.red;
            btnTxt5.color = Color.red;
            btnTxt7.color = Color.red;
            txtFeedBack.text = "Player O wins";
            int.TryParse(playerOTxt.text, out plusOne);
            playerOTxt.text = Convert.ToString(plusOne + 1);
        }
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
        buttons[1].interactable = false;
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
        buttons = new Button[10];
        for (int i = 1; i <= buttons.Length; i++)
        {
            buttons[i] = GameObject.Find("Btn" + i).GetComponent<Button>();
            buttons[i].interactable = false;
        }
    }
}
