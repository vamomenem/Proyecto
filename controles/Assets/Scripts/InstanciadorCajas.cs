using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorCajas : MonoBehaviour
{
    public GameObject prefabCaja;
    int numeroAleatorio;
    int cantCajas;
    
    Vector3 posicion1 = new Vector3 (17, 2, 16);
    Vector3 posicion2 = new Vector3 (15, 2, 16);
    Vector3 posicion3 = new Vector3 (13, 2, 16);
    Vector3 posicion4 = new Vector3 (11, 2, 16);
    Vector3 posicion5 = new Vector3 (9, 2, 16);
    Vector3 posicion6 = new Vector3 (7, 2, 16);
    Vector3 posicion7 = new Vector3 (5, 2, 16);
    Vector3 posicion8 = new Vector3 (3, 2, 16);
    Vector3 posicion9 = new Vector3 (1, 2, 16);

    public GameManager Geim;

    void Start()
    {
        StartCoroutine(SpawnCajas());
    }

    void Update()
    {
         cantCajas = GameObject.FindGameObjectsWithTag("cajita").Length;
    }

    IEnumerator SpawnCajas()
        {
            while (cantCajas < 2)
            {
                yield return new WaitForSeconds(1);
                ClonarCajas();
            }
        }

    public void ClonarCajas()
    {
        numeroAleatorio = Random.Range(1,9);

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
        }

    }

}
