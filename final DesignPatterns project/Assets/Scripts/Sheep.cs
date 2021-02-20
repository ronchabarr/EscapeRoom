using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : PressableObject
{
    [SerializeField] Rigidbody keyrb;
    public override void Init()
    {
        
    }

    public override void Pressed()
    {
        if (keyrb != null)
        {
            keyrb.isKinematic = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        MyInterractType = InterractionTypes.Pressable;
    }


}
