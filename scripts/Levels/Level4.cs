using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level4 : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Vector3 startPosition;
    [SerializeField] GameObject ghostKey;
    [SerializeField] GameObject grandfather;
    [SerializeField] GameObject[] enemies;
    [SerializeField] GameObject door;
    [SerializeField] GameObject controlSpaceGuide;
    [SerializeField] Button closeBtn;

    Animator playerAnimator;

    bool isMission2Start;
    bool isFirst = true;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("boody");
        playerAnimator = player.GetComponent<Animator>();
        playerAnimator.SetBool("isDie", false);
        playerAnimator.Play("stand");
        player.transform.position = startPosition;

        ghostKey = GameObject.Find("ghost-key");


        // In start all enemies are hidden
        SetEnemiesActive(false);

        // The fight guide disactive
        controlSpaceGuide.SetActive(false);

        grandfather.GetComponent<Grandfather>().helloGrandfatherBtn.onClick.AddListener(SetMoverDisactive);
        closeBtn.onClick.AddListener(SetMoverActive);

        isMission2Start = grandfather.GetComponent<Grandfather>().isPlayerExit;
    }

    // Update is called once per frame
    void Update()
    {
        isMission2Start = grandfather.GetComponent<Grandfather>().isPlayerExit;

        Mission2();
    }

    private void Mission2()
    {
        if (isFirst && isMission2Start)
        {
            isFirst = false;
            SetEnemiesActive(true);
            player.GetComponent<PlayerController>().enabled = true;
        }
    }

    private void SetEnemiesActive(bool b)
    {
        foreach (GameObject enemy in enemies)
        {
            enemy.SetActive(b);
        }
    }

    private void SetMoverDisactive()
    {
        player.GetComponent<Mover>().enabled = false;
        controlSpaceGuide.SetActive(true);
    }

    private void SetMoverActive()
    {
        player.GetComponent<Mover>().enabled = true;
    }
}
