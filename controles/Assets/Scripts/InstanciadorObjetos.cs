using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorObjetos : MonoBehaviour
{
    public GameObject prefabObjeto;

    public GameObject puntoSpawn;
    public bool hasBeenGrabbed = false;

    void Start()
    {
        SpawnearObjeto();
    }

    // Update is called once per frame
    void Update()
    {
        if (hasBeenGrabbed)
        {
            SpawnearObjeto(); 
        }
    }

    public void SpawnearObjeto()
    {
        //añadir animación?
        Instantiate(prefabObjeto, puntoSpawn.transform.position, Quaternion.identity);
    }
}
