using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    private static SoundManager _instance;

    public static SoundManager Instance { get { return _instance; } }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    public void SheepPress(bool isWithKey)
    {
        if (isWithKey)
        {

        }
        else
        {

        }
    }
    public void KeyPickup()
    {

    }

    public void DoorOpen()
    {

    }
    public void PressPannel()
    {

    }
    public void PasswordCheck(bool rightPass)
    {
        if (rightPass)
        {

        }
        else
        {

        }
    }

}

