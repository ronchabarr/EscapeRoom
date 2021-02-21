using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    [SerializeField] AudioClip sheepKey;
    [SerializeField] AudioClip sheepNoKey;
    [SerializeField] AudioClip keyPickup;
    [SerializeField] AudioClip doorOpen;
    [SerializeField] AudioClip pressPannel;
    [SerializeField] AudioClip correctPass;
    [SerializeField] AudioClip wrongPass;
    [SerializeField] AudioClip gameEnd;
    [SerializeField] AudioClip boxOpen;
    private AudioSource audioSource;
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
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void SheepPress(bool isWithKey)
    {
        if (isWithKey)
        {
            audioSource.clip = sheepKey;
        audioSource.Play();
        }
        else
        {
            audioSource.clip = sheepNoKey;
        audioSource.Play();

        }
    }
    public void KeyPickup()
    {
        audioSource.clip = keyPickup;
        audioSource.Play();
    }
    public void BoxOpen()
    {

        audioSource.clip = boxOpen;
        audioSource.Play();
    }

    public void DoorOpen()
    {
        audioSource.clip = doorOpen;
        audioSource.Play();
    }
    public void PressPannel()
    {
        audioSource.clip = pressPannel;
        audioSource.Play();
    }
    public void PasswordCheck(bool rightPass)
    {
        if (rightPass)
        {
        audioSource.clip = correctPass;
            audioSource.Play();
        }
        else
        {
        audioSource.clip = wrongPass;
            audioSource.Play();
        }
    }
    public void GameEnd()
    {

        audioSource.clip = gameEnd;
        audioSource.Play();
    }

}

