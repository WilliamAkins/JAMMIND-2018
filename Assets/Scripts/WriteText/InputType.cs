using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputType : MonoBehaviour {
    public bool isValid;
    public string story;
    public List<char> char_Story;
    int index;
    public int howManyLetter;

    private Text title;
    private Text text_UI;

    private GameVars gameVars;

    private string[] textOutcomes = new string[3];

    private string[] essayTitles = new string[2];


    void Awake()
    {
        essayTitles[0] = "Biology Essay";
        essayTitles[1] = "English Essay";

        textOutcomes[0] = "This is a text and i proud that i'm making it.";
        textOutcomes[1] = "MORE TEXT!";
        textOutcomes[2] = "EVEN MORE TEXT!";

        gameVars = GameObject.Find("GameManager").GetComponent<GameVars>();

        GameObject computer = GameObject.FindWithTag("Computer");

        text_UI = computer.transform.Find("Background/Screen/Text").GetComponent<Text>();
        title = computer.transform.Find("Background/Screen/Title").GetComponent<Text>();

        if (howManyLetter == 0)
        {
            howManyLetter = 1;
        }
        story = textOutcomes[gameVars.getHomeworkNum()];
        text_UI.text = "";
        int index = 0;

        title.text = essayTitles[Random.Range(0, 1)];
    }
    // Use this for initialization
    void Start () {
        foreach (char c in story)
        {
            char_Story.Add(c);
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (isValid)
        {
            if (Input.anyKeyDown)
            {
                for (int i = 0; i < howManyLetter; i++)
                {
                    if (char_Story.Count != 0)
                    {
                        text_UI.text += char_Story[0];
                        char_Story.Remove(char_Story[0]);
                    }
                    else
                    {
                        Debug.Log("Homework Finished");

                        gameVars.setHomeworkFinished(true);
                    }
                }
            }
        }
	}
}
