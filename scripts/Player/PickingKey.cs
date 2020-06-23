using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickingKey : MonoBehaviour
{
    [SerializeField] GameObject current_key = null;

    private Animator player_animator;
    private PlayerKeys player_keys;

    private bool isPicked = false;

    private Light myLight;
    public GameObject currentCard;
 
    

    

    // Start is called before the first frame update
    void Start()
    {
        player_animator = this.GetComponent<Animator>();
        player_keys = this.GetComponent<PlayerKeys>();
        myLight = GameObject.Find("Spot Light Key").GetComponent<Light>();
    }


    private void FixedUpdate()
    {
        if (isPicked)
        {
            current_key.transform.position = GameObject.Find("Axe").transform.position;
            current_key.transform.rotation = GameObject.Find("Axe").transform.rotation;
            if(currentCard != null)
                currentCard.SetActive(true);
        }
    }

    // Called when some key is PickingUp by player or when player use some key
    public void setCurrentKey(string name, GameObject key)
    {
        HidePreviuosKeyHoles();

        this.current_key = key;
        this.player_keys.addKey(name, key);

        DisplayCurrentKeyHoles();
    }

    private void HidePreviuosKeyHoles()
    {
        if (current_key != null)
        {
            current_key.GetComponent<KeyProperties>().HideHoles();
        }
    }

    private void DisplayCurrentKeyHoles()
    {
        current_key.GetComponent<KeyProperties>().DisplayHoles();
    }

    public void Reset()
    {
        current_key = null;
        isPicked = false;
        currentCard = null;
    }


    // Called when "Picking Up" animation is played, as animation event
    public void IsPicked()
    {
        this.isPicked = true;
        current_key.GetComponent<KeyProperties>().audio2();
        if(myLight != null)
            myLight.enabled = false;
    }



}
