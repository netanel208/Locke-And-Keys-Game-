using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3 : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Vector3 startPosition;
    [SerializeField] GameObject chest;
    [SerializeField] GameObject ghostKey;
    [SerializeField] GameObject ghostCard;
    [SerializeField] GameObject ghostDoor;

    Animator keyAnimator;
    Animator doorAnimator;
    Animator playerAnimator;
    bool isfirst = false;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(GameObject.Find("mirror-key"));

        player = GameObject.Find("boody");
        playerAnimator = player.GetComponent<Animator>();
        keyAnimator = ghostKey.GetComponent<Animator>();
        player.transform.position = startPosition;

        player.GetComponent<PickingKey>().Reset();
        player.GetComponent<PickingKey>().currentCard = ghostCard;
        ghostKey.GetComponent<PickingUp>().Reset();

        doorAnimator = ghostDoor.GetComponent<Animator>();
        doorAnimator.enabled = false;

        chest.GetComponent<Chest>().player = this.player;

       // player.GetComponent<PickingKey>().currentCard = GameObject.Find("GhostCard");
    }

    
    void Update()
    {
        IsChestOpened();
        IsGhostDoorOpened();
    }

    private void IsChestOpened()
    {}

    private void IsGhostDoorOpened()
    {
        if(!isfirst && keyAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime >= keyAnimator.GetCurrentAnimatorStateInfo(0).length)
        {
            Debug.Log("DarkScene begin");
            StartCoroutine(PlayerBecomeToGhost());
        }
    }

    IEnumerator PlayerBecomeToGhost()
    {
        isfirst = true;
        doorAnimator.enabled = true;
        doorAnimator.Play("openDoorGhost1");
        keyAnimator.enabled = false;
        yield return new WaitForSeconds(doorAnimator.GetCurrentAnimatorStateInfo(0).length);

        playerAnimator.SetBool("isDie", true);
        playerAnimator.Play("die");
        yield return new WaitForSeconds(playerAnimator.GetCurrentAnimatorStateInfo(0).length);

        DontDestroyOnLoad(player);
        DontDestroyOnLoad(ghostKey);
        SceneManager.LoadScene("DarkScene");
        yield return new WaitForSeconds(3);
    }
}
