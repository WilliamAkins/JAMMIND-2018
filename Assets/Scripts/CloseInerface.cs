using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseInerface : MonoBehaviour {

    private GameVars gameVars;

    // Use this for initialization
    void Start () {
        gameVars = GameObject.Find("GameManager").GetComponent<GameVars>();

        GetComponent<Button>().onClick.AddListener(btnOnClick);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void btnOnClick()
    {
        Debug.Log("Removing " + gameVars.getInterfaceType());

        if (gameVars.getInterfaceType() != "")
            Destroy(GameObject.FindWithTag(gameVars.getInterfaceType()));

        //reset the interface vars
        gameVars.setPlayerInInterface(false);
        gameVars.setInterfaceType("");
    }
}
