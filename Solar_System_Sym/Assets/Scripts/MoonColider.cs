using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonColider : MonoBehaviour
{
    public GameObject effect;
   
   void OnTriggerDestroy(Collision collision)
    {
        if(collision.gameObject.tag == "Moon")
        {
            Instantiate(effect, collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);
        }
    }
}
