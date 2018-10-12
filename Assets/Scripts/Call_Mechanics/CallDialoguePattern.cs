using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CallDialoguePattern : MonoBehaviour {

    public int index_Box;
	// Use this for initialization
	void Start () {
        Pattern_13();
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void UpdatePattern(int index_Box)
    {
        switch (index_Box)
        {
            case 1:
                Pattern_1();
                break;
            case 2:
                Pattern_2();
                break;
            case 3:
                Pattern_3();
                break;
            case 4:
                Pattern_4();
                break;
            case 5:
                Pattern_5();
                break;
            case 6:
                Pattern_6();
                break;
            case 7:
                Pattern_7();
                break;
            case 8:
                Pattern_8();
                break;
            case 9:
                Pattern_9();
                break;
            case 10:
                Pattern_10();
                break;
            case 11:
                Pattern_11();
                break;
            case 12:
                Pattern_12();
                break;
            case 13:
                Pattern_13();
                break;
            default:
                Pattern_1();
                break;
        }
    }

    public void Pattern_1() {
        Sequence pattern_1 = DOTween.Sequence();
        /*
         * Initialized Sequences
         */
        pattern_1.Append(transform.DOLocalMove(new Vector3(-969, 0, 0), 2, false));
        pattern_1.Append(transform.DOLocalMove(new Vector3(0, 554.899f, 0), 2, false));
        pattern_1.Append(transform.DOLocalMove(new Vector3(964, 0, 0), 2, false));
        pattern_1.Append(transform.DOLocalMove(new Vector3(0, -561.1f, 0), 2, false));
        pattern_1.SetLoops(-1, LoopType.Restart);
    }

    public void Pattern_2() {
        Sequence pattern_2 = DOTween.Sequence();

        pattern_2.Append(transform.DOLocalMove(new Vector3(-969, -561.1f, 0), 2, true));
        pattern_2.Append(transform.DOLocalMove(new Vector3(-506, 554.9f, 0), 2, true));
        pattern_2.Append(transform.DOLocalMove(new Vector3(0, -561.1f, 0), 2, true));
        pattern_2.Append(transform.DOLocalMove(new Vector3(574, 554.9f, 0), 2, true));
        pattern_2.Append(transform.DOLocalMove(new Vector3(964, -561.1f, 0), 2, true));
        pattern_2.SetLoops(-1, LoopType.Yoyo);

    }

    public void Pattern_3() {
        Sequence pattern_3 = DOTween.Sequence();

        pattern_3.Append(transform.DOLocalMove(new Vector3(-969, -561.1f, 0), 2, true));
        pattern_3.Append(transform.DOLocalMove(new Vector3(964, 554.899f, 0), 2, true));
        pattern_3.Append(transform.DOLocalMove(new Vector3(964 ,- 561.1f , 0), 2, true));
        pattern_3.Append(transform.DOLocalMove(new Vector3(-969, 554.899f, 0), 2, true));
        pattern_3.Append(transform.DOLocalMove(new Vector3(-969, -561.1f, 0), 2, true));
        pattern_3.SetLoops(-1, LoopType.Restart);
    }

    public void Pattern_4() {
        Sequence pattern_4 = DOTween.Sequence();
        pattern_4.Append(transform.DOLocalMove(new Vector3(0, -354, 0), 1, true));
        pattern_4.Append(transform.DOLocalMove(new Vector3(-437.8f, -284, 0), 1, true));
        pattern_4.Append(transform.DOLocalMove(new Vector3(-557, 0, 0), 1, true));
        pattern_4.Append(transform.DOLocalMove(new Vector3(-437.8002f, 255.9f, 0), 1, true));
        pattern_4.Append(transform.DOLocalMove(new Vector3(0, 255.9f, 0), 1, true));
        pattern_4.Append(transform.DOLocalMove(new Vector3(437.7999f, 255.9f, 0), 1, true));
        pattern_4.Append(transform.DOLocalMove(new Vector3(255.9f, 0, 0), 1, true));
        pattern_4.Append(transform.DOLocalMove(new Vector3(437.7999f, -234.9f, 0), 1, true));
        pattern_4.Append(transform.DOLocalMove(new Vector3(0, -354, 0), 1, true));
        pattern_4.SetLoops(-1, LoopType.Restart);
    }

    public void Pattern_5() {
        Sequence pattern_5 = DOTween.Sequence();
        pattern_5.Append(transform.DOLocalMove(new Vector3(-1200, 0, 0), 2, true));
        pattern_5.Append(transform.DOLocalMove(new Vector3(1200, 0, 0), 2, true));
        pattern_5.SetLoops(-1, LoopType.Yoyo);
    }

    public void Pattern_6() {
        Sequence pattern_6 = DOTween.Sequence();
        pattern_6.Append(transform.DOLocalMove(new Vector3(0, -1200, 0), 2, true));
        pattern_6.Append(transform.DOLocalMove(new Vector3(0, 1200, 0), 2, true));
        pattern_6.SetLoops(-1, LoopType.Yoyo);
    }

    public void Pattern_7() {
        Sequence pattern_7 = DOTween.Sequence();
        pattern_7.Append(transform.DOLocalMove(new Vector3(-1200, -750, 0), 2, true));
        pattern_7.Append(transform.DOLocalMove(new Vector3(1200, 750, 0), 2, true));
        pattern_7.SetLoops(-1, LoopType.Yoyo);
    }

    public void Pattern_8()
    {
        Sequence pattern_8 = DOTween.Sequence();
        pattern_8.Append(transform.DOLocalMove(new Vector3(-1200, 750, 0), 2, true));
        pattern_8.Append(transform.DOLocalMove(new Vector3(1200, -750, 0), 2, true));
        pattern_8.SetLoops(-1, LoopType.Yoyo);
    }

    public void Pattern_9()
    {
        Sequence pattern_9 = DOTween.Sequence();
        pattern_9.Append(transform.DOLocalMove(new Vector3(-1200, 400, 0), 2, true));
        pattern_9.Append(transform.DOLocalMove(new Vector3(1200, 400, 0), 2, true));
        pattern_9.SetLoops(-1, LoopType.Yoyo);
    }

    public void Pattern_10()
    {
        Sequence pattern_10 = DOTween.Sequence();
        pattern_10.Append(transform.DOLocalMove(new Vector3(-1200, -175, 0), 2, true));
        pattern_10.Append(transform.DOLocalMove(new Vector3(1200, -175, 0), 2, true));
        pattern_10.SetLoops(-1, LoopType.Yoyo);
    }

    public void Pattern_11()
    {
        Sequence pattern_11 = DOTween.Sequence();
        pattern_11.Append(transform.DOLocalMove(new Vector3(-698, 662, 0), 2, true));
        pattern_11.Append(transform.DOLocalMove(new Vector3(-698, -690, 0), 2, true));
        pattern_11.SetLoops(-1, LoopType.Yoyo);
    }

    public void Pattern_12()
    {
        Sequence pattern_12 = DOTween.Sequence();
        pattern_12.Append(transform.DOLocalMove(new Vector3(0, 675, 0), 2, true));
        pattern_12.Append(transform.DOLocalMove(new Vector3(0, -675, 0), 2, true));
        pattern_12.SetLoops(-1, LoopType.Yoyo);
    }

    public void Pattern_13()
    {
        Sequence pattern_13 = DOTween.Sequence();
        pattern_13.Append(transform.DOLocalMove(new Vector3(700, 660, 0), 2, true));
        pattern_13.Append(transform.DOLocalMove(new Vector3(700, -660, 0), 2, true));
        pattern_13.SetLoops(-1, LoopType.Yoyo);
    }

    
    /*
     * TO DO:
     * 1. Design some Patterns.
     * 2. Implement some pattern that could moving around and rotate as well
     * 3.Randomize the Patterns using Coroutine
     */
}
