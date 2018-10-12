using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartNewDay : MonoBehaviour {
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
        Debug.Log("Starting a new day...");

        if (gameVars.getInterfaceType() != "")
            Destroy(GameObject.FindWithTag(gameVars.getInterfaceType()));

        //reset the interface vars
        gameVars.setPlayerInInterface(false);
        gameVars.setInterfaceType("");

        //reset vars for a new day
        gameVars.setHomeworkFinished(false);
        gameVars.setPhoneCallFinished(false);

        gameVars.incrementDay();

        Instantiate(Resources.Load("WakeUp"), new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }
}
