using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableButton : MonoBehaviour
{
    public Button deleteBtn;
    private bool isClicked = false;

    // Start is called before the first frame update
    void Start()
    {
        deleteBtn = this.GetComponent<Button>();
        deleteBtn.onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        isClicked = true;
        Destroy(deleteBtn.gameObject);
    }

    public bool IsClicked()
    {
        return isClicked;
    }

}
