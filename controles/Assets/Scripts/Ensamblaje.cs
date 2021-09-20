using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ensamblaje : MonoBehaviour
{
    public Transform mueble;
    public GameObject asamblePoint1;
    public GameObject asamblePoint2;
    public GameObject asamblePoint3;

    int indexOfSlots = 1;


    private void OnCollisionEnter(Collision other){
        Debug.Log(other.gameObject);
        if (other.gameObject.tag == "Objeto" && other.transform.childCount > 0){
            switch (indexOfSlots){
                case 1:
                indexOfSlots++;
                    other.transform.position = asamblePoint1.transform.position;
                    break;
                case 2:
                
                indexOfSlots++;
                    other.transform.position = asamblePoint2.transform.position;
                    break;
                case 3:
                
                    other.transform.position = asamblePoint3.transform.position;
                    //craft
                    break;


            }
        }

        /*if(other.transform.childCount > 0){
        mueble = other.gameObject.transform.GetChild(0);
        mueble = asamblePoint1.transform;
        other.gameObject.transform.SetParent(asamblePoint1.transform);
        }

        if(other.tag == "Objeto"){
        other.gameObject.transform.position = asamblePoint1.transform.position;
        }*/
    }
    
}
