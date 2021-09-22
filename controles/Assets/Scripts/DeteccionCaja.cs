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
		Destroy(gameObject);
	}
    }

    private void PowerUpSpeed()
    {
        //aumentarle la velocidad al jugador
    }

    private void PowerDown()
    {
        //disminuirle la velocidad al jugador
    } 

}
