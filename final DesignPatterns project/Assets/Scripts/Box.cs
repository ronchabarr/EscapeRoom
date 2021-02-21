using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : PressableObject
{
    SoundManager _soundManager;
    [SerializeField] GameObject boxcover;
     private Collider col;
    public override void Init()
    {
        
    }

    public override void Pressed()
    {
        boxcover.SetActive(false);
        col.enabled = false;
        _soundManager.BoxOpen();
    }

    void Start()
    {
        _soundManager = SoundManager.Instance;
        MyInterractType = InterractionTypes.Pressable;
        col = GetComponent<Collider>();
    }

    // Update is called once per frame
    
}
