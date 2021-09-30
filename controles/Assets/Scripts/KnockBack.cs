using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    [SerializeField] private float knockbackStrength;

    
        public  Rigidbody rb;
    private void OnTriggerEnter(Collider collision){
        

        if(collision.gameObject.tag == "Player"){

            rb = collision.gameObject.GetComponent<Rigidbody>();

            Debug.Log("wee");

            Vector3 direccion = collision.transform.position - transform.position;
            direccion.y = 0;
           // rb.velocity = direccion * knockbackStrength;
            rb.AddForce(-direccion.normalized * knockbackStrength, ForceMode.Impulse);
            // rb.AddForce(direccion.normalized * knockbackStrength)
        }
    }
}
