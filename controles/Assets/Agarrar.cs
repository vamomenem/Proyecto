using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agarrar : MonoBehaviour
{
    private GameObject pickedObject = null;
    public GameObject handPoint;
    private void OntriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Objeto")){
            if (Input.GetKey("f") && pickedObject==null){
                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.transform.position = handPoint.transform.position;
                other.gameObject.transform.SetParent(handPoint.gameObject.transform);
                pickedObject = other.gameObject;

            }

        }
    }
  


}
