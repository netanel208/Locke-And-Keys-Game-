using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grandfather : MonoBehaviour
{
    public Button helloGrandfatherBtn;
    public bool isPlayerExit = false;

    // Start is called before the first frame update
    void Start()
    {
        helloGrandfatherBtn.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && helloGrandfatherBtn != null)
        {
            helloGrandfatherBtn.gameObject.SetActive(true);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && helloGrandfatherBtn != null)
        {
            helloGrandfatherBtn.gameObject.SetActive(false);
        }
        else if(other.tag == "Player")
        {
            isPlayerExit = true;
        }
    }
}
