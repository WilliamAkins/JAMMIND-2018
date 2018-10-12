using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//1100 - 540 = 560 Top Eyes.
//540 - 1100 = -560 Bottom Eyes.

public class WakingUp : MonoBehaviour {
    public bool isSleepy;
    public float Stamina;
    public Text Text_UI;
    public Image TopEye;
    public Image BottomEye;

	// Use this for initialization
	void Start () {
        Stamina = 100;
        StartCoroutine(CloseEyes());
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            Stamina += 4;
        }
	}

    IEnumerator CloseEyes()
    {
        if (Stamina > 0)
        {
            Stamina -= 1;
            TopEye.rectTransform.anchoredPosition = new Vector3(0,540 + (Stamina*5.6f),0);
            BottomEye.rectTransform.anchoredPosition = new Vector3(0,-540 -(Stamina * 5.6f),0);
            Text_UI.text = "Stamina = " + Stamina;
            yield return new WaitForSeconds(0.1f);
            StartCoroutine(CloseEyes());
        }
        
    }
}
