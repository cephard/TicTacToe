using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

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
    public Text besOfValOut = null;
    private int bestOfVal;
    Button[] buttons;
    Dictionary<Button, Text> buttonDictionary;

    void Start()
    {

        SetButtons();
        SetBestOfValue(null);
    }

    void SetButtons()
    {
        buttonDictionary = new Dictionary<Button, Text>();
        buttons = new Button[9];
        // buttonDict = new Dictionary<Button, Text>();
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i] = GameObject.Find("Btn" + (i + 1)).GetComponent<Button>();
            //changing all text in buttons
            Text btnText = (Text)typeof(Logic).GetField("btnTxt" + (i + 1)).GetValue(this);
            buttonDictionary.Add(buttons[i], btnText);
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
            txtFeedBack.text = "Player " + choice + " wins!";

        }
        else if (firstButtonTxt.text.Equals(secondButtonTxt.text) && secondButtonTxt.text.Equals(thirdButtonTxt.text) && thirdButtonTxt.text.Equals(choice) && choice.Equals("O"))
        {
            firstButtonTxt.color = Color.green;
            secondButtonTxt.color = Color.green;
            thirdButtonTxt.color = Color.green;
            int.TryParse(playerOTxt.text, out plusOne);
            playerOTxt.text = Convert.ToString(plusOne + 1);
            Disable_Buttons();
            txtFeedBack.text = "Player " + choice + " wins!";
        }

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


    private void Click_Behavior(Button button, Text btnText)
    {
        if (checker == false)
        {
            btnText.text = "X";
            checker = true;
        }
        else
        {
            btnText.text = "O";
            checker = false;
        }
        button.interactable = false;
        Score();

    }


    public void Button1_Click()
    {
        Click_Behavior(buttons[0], btnTxt1);

    }


    public void Button2_Click()
    {

        Click_Behavior(buttons[1], btnTxt2);

    }

    public void Button3_Click()
    {

        Click_Behavior(buttons[2], btnTxt3);

    }

    public void Button4_Click()
    {

        Click_Behavior(buttons[3], btnTxt4);

    }

    public void Button5_Click()
    {

        Click_Behavior(buttons[4], btnTxt5);

    }

    public void Button6_Click()
    {

        Click_Behavior(buttons[5], btnTxt6);

    }

    public void Button7_Click()
    {

        Click_Behavior(buttons[6], btnTxt7);

    }

    public void Button8_Click()
    {

        Click_Behavior(buttons[7], btnTxt8);
    }
    public void Button9_Click()
    {

        Click_Behavior(buttons[8], btnTxt9);

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
        checker = false;
        Enable_Buttons();
    }

    //loading all buttons and making the unclicable
    private void Disable_Buttons()
    {
        foreach (var pair in buttonDictionary)
        {
            pair.Key.interactable = false;
        }
    }

    //
    private void Enable_Buttons()
    {
        foreach (var pair in buttonDictionary)
        {
            pair.Key.interactable = true;
            pair.Value.color = Color.black;
        }
    }

    public void LoadSettings(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void BackToGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

//
    public void SetBestOfValue(string value){
        if (value == null){
            bestOfVal = 5;
        }else{
           int.TryParse(value, out bestOfVal);
        }
        besOfValOut.text = Convert.ToString(bestOfVal);
    }
}

