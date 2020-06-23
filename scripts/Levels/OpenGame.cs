using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenGame : MonoBehaviour
{
    public Animator firstCamera_animator;
    [SerializeField] GameObject player;
  

    // Start is called before the first frame update
    void Start()
    {

        firstCamera_animator = this.GetComponent<Animator>();
        firstCamera_animator.Play("cam5");
    }

    // Update is called once per frame
 /*   void update()
    {
        Debug.Log("open begin");
        AnimatorStateInfo state = firstCamera_animator.GetCurrentAnimatorStateInfo(0);

        if(state.IsName("cam"))
        {
            StartCoroutine(playCamAnimation());
        }

        Debug.Log("open anim stop in open function");
       
        Debug.Log("move to another scene");

    }

    IEnumerator playCamAnimation()
    {
        Debug.Log("open anim begin");
        firstCamera_animator.SetBool("isCamAnim", true);
       
       // firstCamera_animator.gameObject.SetActive(true);
        firstCamera_animator.Play("cam3");
        yield return new WaitForSeconds(10);
        
       // firstCamera_animator.SetBool("isCamAnim", false);
       // firstCamera_animator.gameObject.SetActive(false);
        Destroy(player);
        
    }
    */
   
    public void LoadScene()
    {
        SceneManager.LoadScene("2");
    }

}
