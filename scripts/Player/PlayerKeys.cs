using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeys : MonoBehaviour
{
    public Dictionary<string, GameObject> keys;

    // Start is called before the first frame update
    void Start()
    {
        keys = new Dictionary<string, GameObject>();
    }

    // The name of key should be on tamplate: "<what the key open> key"
    public void addKey(string name, GameObject key)
    {
        if(!keys.ContainsKey(name))
            keys.Add(name, key);
    }
}
