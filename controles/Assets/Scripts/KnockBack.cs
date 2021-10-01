using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    [SerializeField] private float knockbackStrength;

    public  Rigidbody rb;
    private CharacterController ch;

    //private Animator animator;

    private void OnTriggerEnter(Collider collision){

        Debug.Log("1"); 
        
        if(collision.gameObject.tag == "Player"){

            rb = collision.gameObject.GetComponent<Rigidbody>();

            ch = collision.gameObject.GetComponent<CharacterController>();

            Debug.Log("2");

            Vector3 direccion = collision.transform.position - transform.position;
            direccion.y = 0;

           //ch.


           //animator = collision.gameObject.GetComponent<Animator>();
           //animator.SetBool("Impacto", true);

            //ch.Move(direccion.normalized * knockbackStrength);

            //rb.AddForce(direccion.normalized * knockbackStrength, ForceMode.Impulse);
            //rb.AddForce(-direccion.normalized * knockbackStrength);
        }
    }
}
