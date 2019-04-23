using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonColider : MonoBehaviour
{
    public GameObject objToDestroy;
    public GameObject effect;

   
   void OnTriggerDestroy(Collider other)
    {
        if(other.gameObject.tag == "Moon")
        {
            Instantiate(effect, objToDestroy.transform.position, objToDestroy.transform.rotation);
            Destroy(objToDestroy);
        }
    }
}
