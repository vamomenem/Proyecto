using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorObjetos : MonoBehaviour
{
  public bool hasObjectInIt = false;
  [SerializeField] float time = 0;
    private void Update() {
        if (!hasObjectInIt) {
            //Coroutine instantiate 1 segundo
        } 
    }

    IEnumerator spawnCycle(){
        WaitForSeconds wait = new WaitForSeconds(time);

        while(true){
            yield return wait;
            hasObjectInIt = true;
            //instanciar
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
