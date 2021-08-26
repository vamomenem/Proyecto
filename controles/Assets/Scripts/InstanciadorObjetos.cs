using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorObjetos : MonoBehaviour
{
    public GameObject prefabObjeto1;
    public GameObject puntoSpawn1;
     public GameObject prefabObjeto2;
    public GameObject puntoSpawn2;
     public GameObject prefabObjeto3;
    public GameObject puntoSpawn3;
     public GameObject prefabObjeto4;
    public GameObject puntoSpawn4;
     public GameObject prefabObjeto5;
    public GameObject puntoSpawn5;
     public GameObject prefabObjeto6;
    public GameObject puntoSpawn6;
     public GameObject prefabObjeto7;
    public GameObject puntoSpawn7;
     public GameObject prefabObjeto8;
    public GameObject puntoSpawn8;
     public GameObject prefabObjeto9;
    public GameObject puntoSpawn9;
     public GameObject prefabObjeto10;
    public GameObject puntoSpawn10;
     public GameObject prefabObjeto11;
    public GameObject puntoSpawn11;
     public GameObject prefabObjeto12;
    public GameObject puntoSpawn12;
     public GameObject prefabObjeto13;
    public GameObject puntoSpawn13;
     public GameObject prefabObjeto14;
    public GameObject puntoSpawn14;
     public GameObject prefabObjeto15;
    public GameObject puntoSpawn15;
    void Start()
    {
        SpawnearObjeto();
    }

    // Update is called once per frame
    void Update()
    {
        if (InfoObjeto.hasBeenGrabbed1 == true)
        {
            SpawnearObjeto(); 
            InfoObjeto.hasBeenGrabbed1 = false;
        }

        if (InfoObjeto.hasBeenGrabbed2 == true)
        {
            SpawnearObjeto(); 
            InfoObjeto.hasBeenGrabbed2 = false;
        }

        if (InfoObjeto.hasBeenGrabbed3 == true)
        {
            SpawnearObjeto(); 
            InfoObjeto.hasBeenGrabbed3 = false;
        }

        if (InfoObjeto.hasBeenGrabbed4 == true)
        {
            SpawnearObjeto(); 
            InfoObjeto.hasBeenGrabbed4 = false;
        }

        if (InfoObjeto.hasBeenGrabbed5 == true)
        {
            SpawnearObjeto(); 
            InfoObjeto.hasBeenGrabbed5 = false;
        }

        if (InfoObjeto.hasBeenGrabbed6 == true)
        {
            SpawnearObjeto(); 
            InfoObjeto.hasBeenGrabbed6 = false;
        }

        if (InfoObjeto.hasBeenGrabbed7 == true)
        {
            SpawnearObjeto(); 
            InfoObjeto.hasBeenGrabbed7 = false;
        }

        if (InfoObjeto.hasBeenGrabbed8 == true)
        {
            SpawnearObjeto(); 
            InfoObjeto.hasBeenGrabbed8 = false;
        }

        if (InfoObjeto.hasBeenGrabbed9 == true)
        {
            SpawnearObjeto(); 
            InfoObjeto.hasBeenGrabbed9 = false;
        }

        if (InfoObjeto.hasBeenGrabbed10 == true)
        {
            SpawnearObjeto(); 
            InfoObjeto.hasBeenGrabbed10 = false;
        }

        if (InfoObjeto.hasBeenGrabbed11 == true)
        {
            SpawnearObjeto(); 
            InfoObjeto.hasBeenGrabbed11 = false;
        }

        if (InfoObjeto.hasBeenGrabbed12 == true)
        {
            SpawnearObjeto(); 
            InfoObjeto.hasBeenGrabbed12 = false;
        }

        if (InfoObjeto.hasBeenGrabbed13 == true)
        {
            SpawnearObjeto(); 
            InfoObjeto.hasBeenGrabbed13 = false;
        }

        if (InfoObjeto.hasBeenGrabbed14 == true)
        {
            SpawnearObjeto(); 
            InfoObjeto.hasBeenGrabbed14 = false;
        }

        if (InfoObjeto.hasBeenGrabbed15 == true)
        {
            SpawnearObjeto(); 
            InfoObjeto.hasBeenGrabbed15 = false;
        }
    }

    public void SpawnearObjeto()
    {
        //añadir animación?
        Instantiate(prefabObjeto1, puntoSpawn1.transform.position, Quaternion.identity);

         Instantiate(prefabObjeto1, puntoSpawn1.transform.position, Quaternion.identity);
          Instantiate(prefabObjeto1, puntoSpawn2.transform.position, Quaternion.identity);
           Instantiate(prefabObjeto1, puntoSpawn3.transform.position, Quaternion.identity);
            Instantiate(prefabObjeto1, puntoSpawn4.transform.position, Quaternion.identity);
             Instantiate(prefabObjeto1, puntoSpawn5.transform.position, Quaternion.identity);
              Instantiate(prefabObjeto1, puntoSpawn6.transform.position, Quaternion.identity);
               Instantiate(prefabObjeto1, puntoSpawn7.transform.position, Quaternion.identity);
                Instantiate(prefabObjeto1, puntoSpawn8.transform.position, Quaternion.identity);
                 Instantiate(prefabObjeto1, puntoSpawn9.transform.position, Quaternion.identity);
                  Instantiate(prefabObjeto1, puntoSpawn11.transform.position, Quaternion.identity);
                   Instantiate(prefabObjeto1, puntoSpawn12.transform.position, Quaternion.identity);
                    Instantiate(prefabObjeto1, puntoSpawn13.transform.position, Quaternion.identity);
                     Instantiate(prefabObjeto1, puntoSpawn14.transform.position, Quaternion.identity);
                      Instantiate(prefabObjeto1, puntoSpawn15.transform.position, Quaternion.identity);
    }
}
