using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class PickAbleObject : InterractableObject
{
    SoundManager _soundManager;
    public override void ReactToInterraction()
    {
        _soundManager = SoundManager.Instance;
        GetPickedUp();
    }
    public void GetPickedUp()
    {
        TurnOff();
    }
    public void TurnOff()
    {
        gameObject.SetActive(false);
        _soundManager.KeyPickup();
        
    }
    public override void Init()
    {
        SubInit();
    }
    public virtual void SubInit()
    {

    }



    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
}
