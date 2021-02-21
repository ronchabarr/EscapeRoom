using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordMachine : MonoBehaviour
{
    internal List<Pannel> insertedSequence = new List<Pannel>();
    [SerializeField] Pannel[] setSequence;
    int currentInserted=0;
    [SerializeField] AccessableObject barricade;
    SoundManager soundManager;

    private void Start()
    {
        soundManager = SoundManager.Instance;
    }

    public void PannelPressed(Pannel pannel)
    {
        pannel.pressGFX(true);
        insertedSequence.Add(pannel);
        currentInserted++;
        if (currentInserted == setSequence.Length)
        {
            CheckPassword();
        }

        
    }
    public void CheckPassword()
    {
        int CorrectMatches = 0;

        for (int i = 0; i <setSequence.Length; i++)
        {
            if (insertedSequence[i] == setSequence[i])
            {
                CorrectMatches++;
            }
        }
        if (CorrectMatches >= setSequence.Length)
        {
            CorrectPassword();
        soundManager.PasswordCheck(true);
        }
        else { WrongPassword(); CorrectMatches = 0; currentInserted = 0; soundManager.PasswordCheck(false); }

    }
    public void CorrectPassword()
    {
        barricade.GetInterracted();
    }
    public void WrongPassword()
    {
        
        Restart();
    }
    public void Restart()
    {
        foreach(Pannel found in insertedSequence)
        {
            found.pressGFX(false);
        }
        insertedSequence.Clear();
    }
    public void RestartGFX()
    {

    }
    public void CorrectGFX()
    {

    }


}
