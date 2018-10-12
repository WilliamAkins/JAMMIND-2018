using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameVars : MonoBehaviour {
    private bool playerInInterface = false;
    private string interfaceType = "";

    private int day = 1;

    private int homeworkNum = 0;
    private bool homeworkFinished = false;

    private int phoneCallNum = 0;
    private bool phoneCallFinished = false;

	public void setPlayerInInterface(bool newPlayerInInterface)
    {
        playerInInterface = newPlayerInInterface;
    }

    public bool getPlayerInInterface()
    {
        return playerInInterface;
    }

    public void setInterfaceType(string newInterfaceType)
    {
        interfaceType = newInterfaceType;
    }

    public string getInterfaceType()
    {
        return interfaceType;
    }

    public void incrementDay()
    {
        day++;
    }

    public int getDay()
    {
        return day;
    }

    public void setHomeworkNum(int newHomeworkNum)
    {
        homeworkNum = newHomeworkNum;
    }

    public int getHomeworkNum()
    {
        return homeworkNum;
    }

    public void setHomeworkFinished(bool newHomeworkFinished)
    {
        homeworkFinished = newHomeworkFinished;
    }

    public bool getHomeworkFinished()
    {
        return homeworkFinished;
    }

    public void setPhoneCallNum(int newPhoneCallNum)
    {
        phoneCallNum = newPhoneCallNum;
    }

    public int getPhoneCallNum()
    {
        return phoneCallNum;
    }

    public void setPhoneCallFinished(bool newPhoneCallFinished)
    {
        phoneCallFinished = newPhoneCallFinished;
    }

    public bool getPhoneCallFinished()
    {
        return phoneCallFinished;
    }
}
