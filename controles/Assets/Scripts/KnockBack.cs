using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    [SerializeField] private float knockbackStrength;

    private void OnCollisionEnter(Collision collision){

        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();

        if(collision.gameObject.tag == "Player"){

            Vector3 direccion = collision.transform.position - transform.position;
            direccion.y = 0;

            rb.AddForce(direccion.normalized * knockbackStrength, ForceMode.Impulse);
        }
    }
}
