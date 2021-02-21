using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : PressableObject
{
    SoundManager _soundManager;
    [SerializeField] Rigidbody keyrb;
    public override void Init()
    {
        
    }

    public override void Pressed()
    {
        if (keyrb != null)
        {
            keyrb.isKinematic = false;
            _soundManager.SheepPress(true);
        }
        else
        {
         _soundManager.SheepPress(false);

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _soundManager = SoundManager.Instance;
        MyInterractType = InterractionTypes.Pressable;
    }


}
