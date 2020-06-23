using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{

    
    public bool openDoor = false;


    private void OnTriggerEnter(Collider other)
    {
   
        if ( other.tag == "Player")
        {
            openDoor = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
            openDoor = false;
        }
    }
}
