using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PressableObject : InterractableObject
{ 
    public abstract void Pressed();
  
    public override void ReactToInterraction()
    {
        
        Pressed();
      
    }
}
