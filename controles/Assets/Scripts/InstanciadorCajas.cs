using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorCajas : MonoBehaviour
{
    public GameObject prefabCaja;
    int numeroAleatorio;
    int cantCajas;
    
    public GameObject[] spawners;

/*
    Vector3 posicion1 = new Vector3 (17, 2, 16);
    Vector3 posicion2 = new Vector3 (15, 2, 16);
    Vector3 posicion3 = new Vector3 (13, 2, 16);
    Vector3 posicion4 = new Vector3 (11, 2, 16);
    Vector3 posicion5 = new Vector3 (9, 2, 16);
    Vector3 posicion6 = new Vector3 (7, 2, 16);
    Vector3 posicion7 = new Vector3 (5, 2, 16);
    Vector3 posicion8 = new Vector3 (3, 2, 16);
    Vector3 posicion9 = new Vector3 (1, 2, 16);*/

    bool hasSpawned = false;

    void Start()
    {
        //StartCoroutine(SpawnCajas());
    }

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
                yield return new WaitForSeconds(1);
                //Debug.Log("wee3");
                hasSpawned = false;
            }
            
        }

    public void ClonarCajas()
    {
        Random.seed = (int)System.DateTime.Now.Ticks;
        numeroAleatorio = Random.Range(1,9);
        Debug.Log("Random seed = " + numeroAleatorio);

        Instantiate(prefabCaja, spawners[numeroAleatorio].transform.position, spawners[numeroAleatorio].transform.rotation);
        /*
        if(numeroAleatorio == 1)
        {
            Instantiate(prefabCaja, posicion1, Quaternion.identity);
        }

        if(numeroAleatorio == 2)
        {
            Instantiate(prefabCaja, posicion2, Quaternion.identity);
        }

        if(numeroAleatorio == 3)
        {
            Instantiate(prefabCaja, posicion3, Quaternion.identity);
        }

        if(numeroAleatorio == 4)
        {
            Instantiate(prefabCaja, posicion4, Quaternion.identity);
        }

        if(numeroAleatorio == 5)
        {
            Instantiate(prefabCaja, posicion5, Quaternion.identity);
        }

        if(numeroAleatorio == 6)
        {
            Instantiate(prefabCaja, posicion6, Quaternion.identity);
        }

        if(numeroAleatorio == 7)
        {
            Instantiate(prefabCaja, posicion7, Quaternion.identity);
        }

        if(numeroAleatorio == 8)
        {
            Instantiate(prefabCaja, posicion8, Quaternion.identity);
        }

        if(numeroAleatorio == 9)
        {
            Instantiate(prefabCaja, posicion9, Quaternion.identity);
        }*/

    }

}
