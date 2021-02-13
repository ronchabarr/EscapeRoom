using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InterractionTypes { Accessable,Pickable,Pressable }
public abstract class InterractableObject : MonoBehaviour
{
    internal  InterractionTypes MyInterractType;

    // Start is called before the first frame update


    // Update is called once per frame
    private void Start()
    {
        Init();
    }
   
    public void GetInterracted()
    {
        ReactToInterraction();
    }
    public abstract void ReactToInterraction();
    public abstract void Init();
   
}
