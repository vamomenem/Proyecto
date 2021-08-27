using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorObjetos : MonoBehaviour
{
  public bool hasObjectInIt = false;

    private void Update() {
        if (!hasObjectInIt) {
            //Coroutine instantiate 1 segundo
        } 
    }

    void objectHandler(bool objectStatus)
    {
        if (objectStatus)
        {
            hasObjectInIt = true;
        }
        else 
        {
            hasObjectInIt = false;
        }
    }

}
