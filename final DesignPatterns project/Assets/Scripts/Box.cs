using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : PressableObject
{
    [SerializeField] GameObject boxcover;
     private Collider col;
    public override void Init()
    {
        
    }

    public override void Pressed()
    {
        boxcover.SetActive(false);
        col.enabled = false;
    }

    void Start()
    {
        MyInterractType = InterractionTypes.Pressable;
        col = GetComponent<Collider>();
    }

    // Update is called once per frame
    
}
