using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Dictionary<PickAbleObject, GameObject> myObjects = new Dictionary<PickAbleObject, GameObject>();



    public void AddPickableObj(PickAbleObject _pickAbleObject,GameObject _gameObject)
    {
        myObjects.Add(_pickAbleObject,_gameObject);
        


    }
    public GameObject FindPickableObj(PickAbleObject _pickAbleObject)
    {
        return myObjects[_pickAbleObject];
    }

}
