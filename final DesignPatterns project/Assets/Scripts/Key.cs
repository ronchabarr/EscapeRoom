using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Key : PickAbleObject
{
    public barricade Destinbarracade;
    

    void Start()
    {

        MyInterractType = InterractionTypes.Pickable;
        Debug.Log("InitCommited");

    }
    public override void SubInit()
    {
     
    }


}
