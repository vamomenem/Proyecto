using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionCaja : MonoBehaviour
{
    public static int num_Powerup = 0;
    public InstanciadorCajas IC;
    void Start ()
    {
       IC = GameObject.FindGameObjectWithTag("GameController").GetComponent<InstanciadorCajas>();
    }

    private void OnCollisionEnter(Collision other) {
	if(other.gameObject.tag == "Player")
    {
        num_Powerup = Random.Range(1,4);
        //Debug.Log(num_Powerup);

        //IC.hasBeenPickedUp = true;
		Destroy(gameObject);
	}
    }

}
