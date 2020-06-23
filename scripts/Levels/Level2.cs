using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level2 : MonoBehaviour
{
    [SerializeField] GameObject mission1;
    [SerializeField] GameObject player;
    [SerializeField] Vector3 startPosition;
    [SerializeField] GameObject mirrorKey;
    [SerializeField] GameObject mother;
    [SerializeField] GameObject door;
    [SerializeField] GameObject text;
    [SerializeField] GameObject timerText;
    [SerializeField] int timer;
    private float second = 1;
    private bool isGuideFinish = false;
    private bool isStartTicking = false;

    private Button closeBtn;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("boody");
        player.transform.position = startPosition;
       
        text.GetComponent<MeshRenderer>().enabled = false;

        Mission1Guide();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Door6PanelSlab").GetComponent<Door>().openDoor && mother.GetComponent<Follow>().isStartFollow)
        {
            text.GetComponent<MeshRenderer>().enabled = true;
            
            DontDestroyOnLoad(player);
         //   Destroy(GameObject.Find("mirror-key"));
            SceneManager.LoadScene("3");
        }

        UpdateTimer();
    }

    private void Mission1Guide()
    {
        /*DialogueTrigger dialogueTrigger = GameObject.Find("EnvelopeButton1").GetComponent<DialogueTrigger>();
        Dialogue mission1_dialog = new Dialogue();
        string[] _sentences = { "Your mother was lost in the maze of mirrors. Find it and then find a way out of the maze.",
            "Pay attention to time! And be careful not to get confused by your reflection." };
        mission1_dialog.name = "Mission 1";
        mission1_dialog.sentences = _sentences;
        dialogueTrigger.dialogue = mission1_dialog;


        //dialogueTrigger.dialogue.name = "Mission 1";
        //dialogueTrigger.dialogue.sentences = _sentences;
        dialogueTrigger.TriggerDialogue();*/

        //mission1.SetActive(true);
        player.GetComponent<Mover>().enabled = false;
        closeBtn = GameObject.Find("CloseButton-Mission1").GetComponent<Button>();
        closeBtn.onClick.AddListener(TaskOnClick);
    }

    private void UpdateTimer()
    {
        if (isGuideFinish)
        {
            second -= Time.deltaTime;
            if (!isStartTicking)
            {
                timerText.GetComponent<AudioSource>().Play();
                isStartTicking = true;
            }

            if (second <= 0 && timer > 0)
            {
                timer -= 1;
                timerText.GetComponent<Text>().text = "Time: " + timer;
                second = 1;
            }

            if (timer >= 0 && timer < 10)
            {
                timerText.GetComponent<Text>().color = Color.red;
                timerText.GetComponent<Text>().fontSize = 60;
            }

            if (second <= 0 && timer <= 0 && timer >= -3)
            {
                timer -= 1;
                timerText.GetComponent<Text>().text = "Time over...";
                second = 1;
            }

            if (timer < -3)
            {
                DontDestroyOnLoad(player);
                SceneManager.LoadScene("MirrorRoom");
            }
        }
        
    }

    private void TaskOnClick()
    {
        player.GetComponent<Mover>().enabled = true;
        isGuideFinish = true;
    }
}
