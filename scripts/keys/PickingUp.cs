using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickingUp : MonoBehaviour
{
    [SerializeField] double radius = 1;
    private GameObject player = null;
    private Animator player_animator;
    public bool isPick;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player_animator = player.GetComponent<Animator>();
        isPick = false;
    }

    private void OnMouseDown()
    {
        double x_player = player.gameObject.transform.position.x;
        double x_key = this.transform.position.x;
        double z_player = player.gameObject.transform.position.z;
        double z_key = this.transform.position.z;
        double radius = Math.Sqrt(Math.Pow((x_player - x_key), 2) + Math.Pow((z_player - z_key), 2));
        if (this.radius >= radius)
        {
            player_animator.Play("Picking Up");
            isPick = true;
            MakePlayerHoldTheKey();
        }

        
    }

    public void Reset()
    {
        isPick = false;
    }

    public void MakePlayerHoldTheKey()
    {
        player.GetComponent<PickingKey>().setCurrentKey(this.gameObject.name, this.gameObject);
    }
}
