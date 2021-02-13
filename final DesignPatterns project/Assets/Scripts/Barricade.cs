using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum barricade { barricade1, barricade2, barricade3, barricade4, barricade5 }
public class Barricade : AccessableObject
{

    [SerializeField] barricade barricade;


    void Start()
    {

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
        gameObject.SetActive(false);
    }

    public override void InterractionApplied()
    {
        Open();
    }

    public override void SubInit()
    {
     
    }
}
