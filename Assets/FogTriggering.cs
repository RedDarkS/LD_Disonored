using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogTriggering : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            GestionFog.Instance.fogState = "Inter";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            GestionFog.Instance.fogState = "Exter";
        }
    }
}
