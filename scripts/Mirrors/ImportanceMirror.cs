using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportanceMirror : MonoBehaviour
{
    //[SerializeField] Material defaultMaterial;
    //[SerializeField] Material reflectionMaterial;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponentInChildren<ReflectionProbe>().mode = UnityEngine.Rendering.ReflectionProbeMode.Baked;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            this.gameObject.GetComponentInChildren<ReflectionProbe>().mode = UnityEngine.Rendering.ReflectionProbeMode.Realtime;
            //this.gameObject.GetComponentInChildren<ReflectionProbe>().timeSlicingMode = UnityEngine.Rendering.ReflectionProbeTimeSlicingMode.NoTimeSlicing;
            this.gameObject.GetComponentInChildren<ReflectionProbe>().importance = 2;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            this.gameObject.GetComponentInChildren<ReflectionProbe>().importance = 1;
            this.gameObject.GetComponentInChildren<ReflectionProbe>().mode = UnityEngine.Rendering.ReflectionProbeMode.Baked;
        }
    }
}
