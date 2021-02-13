using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class PickAbleObject : InterractableObject
{
    
    public override void ReactToInterraction()
    {
        GetPickedUp();
    }
    public void GetPickedUp()
    {
        TurnOff();
    }
    public void TurnOff()
    {
        gameObject.SetActive(false);
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
