using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Key : PickAbleObject
{
    public barricade Destinbarracade;
    SoundManager _soundManager;

    void Start()
    {
        _soundManager = SoundManager.Instance;
        MyInterractType = InterractionTypes.Pickable;
    }
    public override void SubInit()
    {
     
    }


}
