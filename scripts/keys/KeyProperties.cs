using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class KeyProperties : MonoBehaviour
{
    [SerializeField] GameObject[] holes;
    public GameObject currentHole;
    [SerializeField] AudioSource audio;
    bool play;
    bool isRotate = false;

    private void Start()
    {
        this.gameObject.GetComponent<Animator>().enabled = false;
        audio = this.GetComponent<AudioSource>();
        audio.Play();
    }



    public void DisplayHoles()
    {
        for(int i=0; i<holes.Length; i++)
        {
            if(holes[i] != null)
                holes[i].SetActive(true);
        }
    }

    public void HideHoles()
    {
        for (int i = 0; i < holes.Length; i++)
        {
            if (holes[i] != null)
                holes[i].SetActive(false);
        }
    }

    public void SetCurrentHole(GameObject hole)
    {
        Debug.Log(hole.name);
        currentHole = hole;
    }

    public void audio2()
    {
        if(this.GetComponent<PickingUp>().isPick)
        {
            play = false;
            audio.Stop();
        }

    }
        

    

}
