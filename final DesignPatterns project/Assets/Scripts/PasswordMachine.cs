using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordMachine : MonoBehaviour
{
    internal List<Pannel> insertedSequence = new List<Pannel>();
    [SerializeField] Pannel[] setSequence;
    int currentInserted=0;
    [SerializeField] AccessableObject barricade;



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
        }
        else { WrongPassword(); CorrectMatches = 0; currentInserted = 0; }

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
