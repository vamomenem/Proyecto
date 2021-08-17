using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorCajas : MonoBehaviour
{
    public GameObject prefabCaja;
    int numeroAleatorio;
    int cantCajas;
    
    public GameObject[] spawners;

    bool hasSpawned = false;

    void Update()
    {
         cantCajas = GameObject.FindGameObjectsWithTag("cajita").Length;
         Debug.Log(cantCajas);
         if (!hasSpawned){
             StartCoroutine(SpawnCajas());
         }
    }

    IEnumerator SpawnCajas()
        {
            if (cantCajas <= 2)
            {
                hasSpawned = true;
                ClonarCajas();
                yield return new WaitForSeconds(20);
                hasSpawned = false;
            }
            
        }

    public void ClonarCajas()
    {
        Random.seed = (int)System.DateTime.Now.Ticks;
        numeroAleatorio = Random.Range(1,9);
        Debug.Log("Random seed = " + numeroAleatorio);

        Instantiate(prefabCaja, spawners[numeroAleatorio].transform.position, spawners[numeroAleatorio].transform.rotation);
        
    }

}
