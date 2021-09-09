using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agarrar : MonoBehaviour
{
    private GameObject pickedObject;
    bool isHoldingSomething = false;
    public GameObject handPoint;
    public string childFound;
    private Transform item;
    

    private void OnTriggerStay(Collider other)
    {
        //if (other.gameObject.transform.Find(childFound))
           // item = other.gameObject.transform.Find(childFound);

            if (Input.GetKeyDown("f") && !isHoldingSomething && other.tag == "Objeto")
            {
                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;
                if (other.gameObject.GetComponentInParent<InstanciadorObjetos>()){
                    InstanciadorObjetos insta = other.transform.GetComponentInParent<InstanciadorObjetos>();
                    insta.hasObjectInIt = false;
                }
                other.transform.position = handPoint.transform.position;
                other.gameObject.transform.SetParent(handPoint.gameObject.transform);
                pickedObject = other.gameObject;
                StartCoroutine(delayCopado());
                return;
            }
            if (Input.GetKeyDown("f") && isHoldingSomething)
            {
                other.GetComponent<Rigidbody>().useGravity = true;
                other.GetComponent<Rigidbody>().isKinematic = false;
                other.transform.position = handPoint.transform.position;
                other.gameObject.transform.SetParent(null);
                pickedObject = null;
                StartCoroutine(delayCopado2());
                return;
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
