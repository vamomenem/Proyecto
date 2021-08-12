using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionCaja : MonoBehaviour
{
    //public static 
    public GameObject cajita;

    private void OnCollisionEnter(Collision other)   
    {
        if (other.gameObject.tag == "cajita")
        {
            GameObject.Destroy(cajita);
        }        
    } 

}
