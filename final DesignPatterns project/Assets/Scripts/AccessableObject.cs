using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum AccessType {FreeAccess,KeyAccess}
public abstract class AccessableObject : InterractableObject
{
    
    public override void ReactToInterraction()
    {
        InterractionApplied();
    }
    public virtual bool TryAccess(barricade barricade)
    {     
            if (barricade == GetComponent<Barricade>().GetBarracades)
            {
                GetInterracted();
                Debug.Log("yo");
                return true;
            }
            else return false;   
    }
    public abstract void InterractionApplied();
    public override void Init()
    {
        SubInit();
    }
    public virtual void SubInit()
    {

    }
    



  
}
