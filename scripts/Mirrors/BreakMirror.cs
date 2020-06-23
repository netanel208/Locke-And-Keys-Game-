using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakMirror : MonoBehaviour
{
    [SerializeField] GameObject glassFregmets;
    [SerializeField] AudioClip breakingSound;

    KeyCode key = KeyCode.Space;
    [SerializeField] float duration = 1.5f;

    private Animator animator = null;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        glassFregmets.SetActive(false);
    }

    public IEnumerator Break()
    {
        animator.SetBool("isBreaking", true);
        startBreakingSound();
        yield return new WaitForSeconds(duration);
        animator.SetBool("isBreaking", false);
        createGlassFregments();
    }

    void startBreakingSound()
    {
        if (breakingSound != null)
        {
            GetComponent<AudioSource>().clip = breakingSound;
            GetComponent<AudioSource>().Play();
        }
    }

    void createGlassFregments()
    {
        glassFregmets.SetActive(true);
        Destroy(this.gameObject);
    }
}
