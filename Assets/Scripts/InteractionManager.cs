using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour {

    public string roomObject = "";

    private GameVars gameVars;

	// Use this for initialization
	void Start () {
        gameVars = GameObject.Find("GameManager").GetComponent<GameVars>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        if (!gameVars.getPlayerInInterface()) //if player is not already in an interface
        {
            gameVars.setPlayerInInterface(true);
            gameVars.setInterfaceType(roomObject);

            Instantiate(Resources.Load(roomObject), new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        }
    }
}
