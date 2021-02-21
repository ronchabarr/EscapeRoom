using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pannel : PressableObject
{
    PasswordMachine _passwordMachine;
    [SerializeField] Material pressedMat;
     Material originMat;
    MeshRenderer mesh;
    SoundManager _soundManager;
    public override void Init()
    {
        
    }
    public void pressGFX(bool DoEffect)
    {
        if (DoEffect)
        {
            mesh.material = pressedMat;
        }
        else
        {
            mesh.material = originMat;
        }
        
    }



    public override void Pressed()
    {
        _soundManager.PressPannel();
        _passwordMachine.PannelPressed(this);
        Debug.Log(gameObject.name);
    }

    // Start is called before the first frame update
    void Start()
    {
        InitPannel();
        _soundManager = SoundManager.Instance;
       
    }
    public void InitPannel()
    {
        MyInterractType = InterractionTypes.Pressable;
        _passwordMachine = GetComponentInParent<PasswordMachine>();
        mesh = GetComponent<MeshRenderer>();
       
        originMat = mesh.material;
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
