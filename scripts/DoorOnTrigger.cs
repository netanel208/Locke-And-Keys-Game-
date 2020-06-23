using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOnTrigger : MonoBehaviour
{
    [SerializeField] GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        text.GetComponent<MeshRenderer>().enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            text.GetComponent<MeshRenderer>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            text.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
