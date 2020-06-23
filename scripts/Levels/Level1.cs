using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/**
 * This class control the situation on game in Level 1
 */
public class Level1 : MonoBehaviour
{
    [SerializeField] GameObject mirrorKey;
    [SerializeField] GameObject clothMirror;
    [SerializeField] GameObject standingMirror;
    [SerializeField] GameObject player;
    [SerializeField] GameObject mother;
    [SerializeField] GameObject mirrorCard;

    public GameObject controlKeyboard;

    private Animator mirror_key_animator;
    private bool isFirst = true;
    private bool isSecond = false;
    private Dialogue dialogue;
    private bool isStartKeyboardGuide = true;

    private Button clickHereBtn;



    // Start is called before the first frame update
    void Start()
    {
        mirror_key_animator = mirrorKey.GetComponent<Animator>();
        clickHereBtn = GameObject.Find("OpenSceneButton").GetComponent<Button>();
        clickHereBtn.onClick.AddListener(TaskOnClick);

        player.GetComponent<Mover>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isStartKeyboardGuide)
        {
            controlKeyboard.SetActive(true);
            isStartKeyboardGuide = false;
        }

        state1();
        state2();
    }


    void state1()
    {
        AnimatorStateInfo state = mirror_key_animator.GetCurrentAnimatorStateInfo(0);
        
        //if the animation of key in cloth mirror finish start the first mission
        if (state.IsName("Rotate") && state.normalizedTime > 0.3f && state.normalizedTime < 1f)
        {
            
            StartCoroutine(playMotherAnimation());
        }
    }

    void state2()
    {
        if (isSecond)
        {
            //UI first for first mission(text box)

            AnimatorStateInfo state = mirror_key_animator.GetCurrentAnimatorStateInfo(0);
            //GameObject mirror2_hole =  mirrorKey.GetComponent<KeyProperties>().currentHole;
            if (state.IsName("Rotate2") && state.normalizedTime > 0.9f && state.normalizedTime < 1f)
            {
                Debug.Log("state2 begin");
                mirror_key_animator.enabled = false;
                DontDestroyOnLoad(player);
                DontDestroyOnLoad(mirrorKey);
                SceneManager.LoadScene("MirrorRoom");
            }
        }
    }

    IEnumerator playMotherAnimation()
    {
        if (isFirst)
        {
            Debug.Log("first mission begin");
            isFirst = false;
            Animator mom_animator = mother.GetComponent<Animator>();
            mom_animator.SetBool("isMission1Start", true);
            mom_animator.Play("mission1");
            player.GetComponent<Mover>().enabled = false;
            yield return new WaitForSeconds(10);
            Destroy(mother);
            StartCoroutine(clothMirror.GetComponent<BreakMirror>().Break());
            yield return new WaitForSeconds(2);
            mirrorKey.GetComponent<Animator>().enabled = false;
            GameObject text = GameObject.Find("New Text");
            text.GetComponent<MeshRenderer>().enabled = true;
            yield return new WaitForSeconds(2);
            GameObject.Find("EnvelopeButton1").GetComponent<DialogueTrigger>().TriggerDialogue();
            yield return new WaitForSeconds(6);
            player.GetComponent<Mover>().enabled = true;
            text.GetComponent<MeshRenderer>().enabled = false;
            isSecond = true;
        }
    }

    private void TaskOnClick()
    {
        player.GetComponent<Mover>().enabled = true;
    }
}
