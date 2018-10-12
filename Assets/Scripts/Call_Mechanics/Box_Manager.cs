using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Manager : MonoBehaviour {
    public GameObject[] dialogueBoxes;
    public int[] dialogue_Pattern;


	// Use this for initialization
	void Start () {
        StartCoroutine(updatePattern());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator updatePattern()
    {
        List<int> numbers = new List<int>(13);
        for (int i = 0; i < 13; i++)
        {
            numbers.Add(i);
        }

        for (int i = 0; i < dialogue_Pattern.Length; i++)
        {
            int thisNumber = Mathf.RoundToInt(Random.Range(0, numbers.Count));
            dialogue_Pattern[i] = numbers[thisNumber];
            numbers.RemoveAt(thisNumber);
            dialogueBoxes[i].GetComponent<CallDialoguePattern>().UpdatePattern(dialogue_Pattern[i]);
        }
        yield return new WaitForSeconds(15);
        StartCoroutine(updatePattern());
    }
        /*
         * 
         */
}
