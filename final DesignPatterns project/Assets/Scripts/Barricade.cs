using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum barricade { barricade1, barricade2, barricade3, barricade4, barricade5 }
public class Barricade : AccessableObject
{
    SoundManager _soundManager;
    [SerializeField] barricade barricade;


    void Start()
    {
        _soundManager = SoundManager.Instance;
        MyInterractType = InterractionTypes.Accessable;
    }

    public barricade GetBarracades
    {
        get
        {
            return barricade;
        }
       
    }
 

    public void Open()
    {
        StartCoroutine(OpenDoor());
    }

    public override void InterractionApplied()
    {
        Open();
    }

    public override void SubInit()
    {
     
    }
    IEnumerator OpenDoor()
    {
        yield return new WaitForSeconds(1);
        gameObject.SetActive(false);
        _soundManager.DoorOpen();
    }
}
