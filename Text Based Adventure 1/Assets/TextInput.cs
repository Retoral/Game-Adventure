using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour {

    InputField input;
    InputField.SubmitEvent se;
    public Text output;
    public Text storyOutput;
    static int check = 0;
    int names = 0;

    public void AskForInput()
    {
        input = gameObject.GetComponent<InputField>();
        se = new InputField.SubmitEvent();
        se.AddListener(Check);
        input.onEndEdit = se;
    }
    
    private void Start()
    {
        AskForInput();

        storyOutput.text += "Enter 'Start' when you're ready." + "\n";

        if (check == 1)
        {
            storyOutput.text += "What is your name?" + "\n";
            names++;
            AskForInput();
        } if (check == 2)
        {
            storyOutput.text += "Well done so far!";
        }
    }

    public void SetName(string arg0)
    {
        if (arg0 == "Yes" || arg0 == "yes")
        {
            SubmitInput(arg0);
            StoryOutput(arg0);
            Player.playerStat.PlayerName = name;
            names++;
        }if (arg0 == "No" || arg0 == "no")
        {
            names--;
        }
    }

    //Checks whether the input is appropriate or not.
    public void Check(string arg0)
    {
        if (check == 1)
        {
            SubmitInput(arg0);
            StoryOutput(arg0);
            
            if (names == 1)
            {
                name = arg0;
                storyOutput.text += "Is your name: " + name + "?" + "\nYes/No \n";

                input = gameObject.GetComponent<InputField>();
                se = new InputField.SubmitEvent();
                se.AddListener(SetName);
                input.onEndEdit = se;
            }

        }
        else {
            if (arg0 == "Start" || arg0 == "start")
            {
                SubmitInput(arg0);
                StoryOutput(arg0);
            }
            else
            {
                SubmitInput(arg0);
            }
        }
    }

    //This is where the Input gets put into the User Input board.
    private void SubmitInput(string arg1)
    {
        
        string currentText = output.text;
        string newText = currentText + "\n" + "> " + arg1;
        output.text = newText;
        input.text = "";
        input.ActivateInputField();
    }

    //This is where the Input get put into the StoryBoard for progression.
    private void StoryOutput(string arg2)
    {
        string currentText = storyOutput.text;
        string newText = currentText + "\n" + ">> " + arg2 + "\n\n";
        check++;
        storyOutput.text = newText;
        input.ActivateInputField();
    }
}
