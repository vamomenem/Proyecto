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
        Debug.Log(num_Powerup);
		Destroy(gameObject);
	}

    if (num_Powerup == 1)
    {
       PowerUpSpeed(other);
    }

    if (num_Powerup == 2)
    {
       PowerDownSpeed(other);
    }

    }

    private void PowerUpSpeed(Collision player)
    {
        MovimientosBasicos mov = player.gameObject.GetComponent<MovimientosBasicos>();
        mov.SpeedUp();
        
    }

    private void PowerDownSpeed(Collision player)
    {
        MovimientosBasicos mov = player.gameObject.GetComponent<MovimientosBasicos>();
        mov.SpeedDown();
    } 

    private void PowerUpFuerza()
    {
        //aumenta la fuerza del jugador
    }

    private void PowerDownFuerza()
    {
        //aumenta la fuerza del jugador
    }

    private void BorrarObjetoPropio()
    {
        //borra el objeto que tienes en la mano
    }

    private void BorrarObjetoAjeno()
    {
        //borra el objeto que tiene en la mano el jugador enemigo
    }
}
