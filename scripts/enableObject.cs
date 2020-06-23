using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enableObject : MonoBehaviour
{
    public GameObject _gameObject;
    public Button closeBtn;
 
    // Start is called before the first frame update
    void Start()
    {
        //_gameObject = this.GetComponent<GameObject>();
      
        closeBtn.onClick.AddListener(TaskOnClick);
        
    }


    // Update is called once per frame
    private void TaskOnClick()
    {
        Debug.Log("TaskOnClick");
        //   Destroy(closeBtn.gameObject);
        // _gameObject = GameObject.Find("Canvas")
        _gameObject.SetActive(false);

    }

    public void DisplayObject()
    {
        _gameObject.SetActive(true);
    }
}
