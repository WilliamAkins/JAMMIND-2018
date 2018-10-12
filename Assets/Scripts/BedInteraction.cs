using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BedInteraction : MonoBehaviour {
    private GameVars gameVars;

    // Use this for initialization
    void Start () {
        gameVars = GameObject.Find("GameManager").GetComponent<GameVars>();

        string playerMsg = "";

        if (gameVars.getHomeworkFinished() == false && gameVars.getPhoneCallFinished() == false)
        {
            playerMsg = "I shouldn't go to bed, I haven't done my homework and I think someone is trying to contact me...";
        } else if (gameVars.getHomeworkFinished() == false)
        {
            playerMsg = "I shouldn't go to bed, I haven't done my homework...";
        }
        else if (gameVars.getPhoneCallFinished() == false)
        {
            playerMsg = "I think someone is trying to talk to me, should I ignore it?";
        }

        gameObject.transform.Find("Background/Message").GetComponent<Text>().text = playerMsg;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
