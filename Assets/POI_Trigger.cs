using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POI_Trigger : MonoBehaviour
{

    [SerializeField] GameObject triggerObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerObject.SetActive(false);
        }
    }
}
