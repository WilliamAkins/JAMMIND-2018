using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//1100 - 540 = 560 Top Eyes.
//540 - 1100 = -560 Bottom Eyes.

public class WakeUp : MonoBehaviour {
    //private float Sleepiness;
    //public Text Text_UI;

    private float awakeDelta = 20.0f;

    private GameVars gameVars;

    private Image TopEye;
    private Image BottomEye;
    private GameObject TextObj;

    private float TopEyeInitY;
    private float BottomEyeInitY;

    // Use this for initialization
    void Start()
    {
        gameVars = GameObject.Find("GameManager").GetComponent<GameVars>();

        gameVars.setPlayerInInterface(true);
        gameVars.setInterfaceType("WakeUp");

        TopEye = gameObject.transform.Find("TopEye").GetComponent<Image>();
        BottomEye = gameObject.transform.Find("BottomEye").GetComponent<Image>();
        TextObj = gameObject.transform.Find("Text").gameObject;

        TopEyeInitY = TopEye.transform.position.y;
        BottomEyeInitY = BottomEye.transform.position.y;

        //Sleepiness = 0.0f;

        StartCoroutine(CloseEyes());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(TextObj);

            awakeDelta = -400.0f;

            TopEye.rectTransform.position -= new Vector3(0, awakeDelta * Time.deltaTime, 0.0f);
            BottomEye.rectTransform.position += new Vector3(0, awakeDelta * Time.deltaTime, 0.0f);
        }
    }

    IEnumerator CloseEyes()
    {
        //Sleepiness -= 0.5f;
        //TopEye.rectTransform.anchoredPosition = new Vector3(0, TopEyeInitY + Sleepiness, 0);
        //BottomEye.rectTransform.anchoredPosition = new Vector3(0, BottomEyeInitY - Sleepiness, 0);

        if (TopEye.rectTransform.anchoredPosition.y > 540.0f)
        {
            TopEye.rectTransform.position -= new Vector3(0, awakeDelta * Time.deltaTime, 0.0f);
            BottomEye.rectTransform.position += new Vector3(0, awakeDelta * Time.deltaTime, 0.0f);
        }



        //Background.color = new Color(Background.color.r, Background.color.g, Background.color.b, Background.color.a + alphaDelta * Time.deltaTime);

        //reset the awake modifier afterwards
        awakeDelta = 20.0f;

        yield return new WaitForSeconds(0.01f);
        StartCoroutine(CloseEyes());

        if (TopEye.rectTransform.anchoredPosition.y >= 1600.0f || BottomEye.rectTransform.anchoredPosition.y <= -1600.0f)
        {
            Debug.Log("You're awake!");

            //destroy self
            gameVars.setPlayerInInterface(false);
            gameVars.setInterfaceType("");
            Destroy(gameObject);
        }
    }
}
