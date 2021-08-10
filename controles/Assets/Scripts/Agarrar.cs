using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agarrar : MonoBehaviour
{
    private GameObject pickedObject;
    bool isHoldingSomething = false;
    public GameObject handPoint;

    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Objeto")
        {
            
            if (Input.GetKeyDown("f") && !isHoldingSomething)
            {
                Debug.Log("wee");
                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.transform.position = handPoint.transform.position;
                other.gameObject.transform.SetParent(handPoint.gameObject.transform);
                pickedObject = other.gameObject;
                StartCoroutine(delayCopado());
                return;
            }
            if (Input.GetKeyDown("f") && isHoldingSomething)
            {
                Debug.Log("wee22");
                other.GetComponent<Rigidbody>().useGravity = true;
                other.GetComponent<Rigidbody>().isKinematic = false;
                other.transform.position = handPoint.transform.position;
                other.gameObject.transform.SetParent(null);
                pickedObject = null;
                StartCoroutine(delayCopado2());
                return;
            }


        }


    }

   

    IEnumerator delayCopado()
    {
        yield return new WaitForSeconds(1f);
        isHoldingSomething = true;
    }

    IEnumerator delayCopado2()
    {
        yield return new WaitForSeconds(0.5f);
        isHoldingSomething = false;
    }




}
