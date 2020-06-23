using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject player;
    [SerializeField] float radius;
    [SerializeField] Animator animator;
    [SerializeField] string animation;

    private void Start()
    {
        animator.enabled = false;
    }

    private void OnMouseDown()
    {
        if(Vector3.Distance(this.transform.position, player.transform.position) <= radius)
        {
            animator.enabled = true;
            animator.Play(animation);
            this.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
