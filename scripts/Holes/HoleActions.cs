using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleActions : MonoBehaviour
{
    [SerializeField] double radius = 1;
    [SerializeField] GameObject key;
    [SerializeField] string keyAnimation;
    
    private GameObject player = null;
    private Animator key_animator = null;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        key_animator = key.GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
        double x_player = player.gameObject.transform.position.x;
        double x_hole = this.transform.position.x;
        double z_player = player.gameObject.transform.position.z;
        double z_hole = this.transform.position.z;
        double radius = Math.Sqrt(Math.Pow((x_player - x_hole), 2) + Math.Pow((z_player - z_hole), 2));
        if (this.radius >= radius)
        {
            key.GetComponent<KeyProperties>().SetCurrentHole(this.gameObject);
            key_animator.enabled = true;
            key_animator.SetBool("isRotate", true);
            key_animator.Play(keyAnimation);
            key_animator.SetBool("isRotate", false);
        }
    }
}
