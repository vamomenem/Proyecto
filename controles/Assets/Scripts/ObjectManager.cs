using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    GameObject objeto;
    public void BorrarMiObjeto()
    {
      objeto = FindFirstChildWithTag(gameObject, "Objeto");
      Destroy(objeto);
    }

    public GameObject FindFirstChildWithTag(GameObject parent, string tag){
      int count = parent.transform.childCount;

      for (int i = 0; i < count; i++){
        Transform child = parent.transform.GetChild(i);
        if (child.tag == tag){
          return child.gameObject;
        }

      }
      return null;
    }
}
