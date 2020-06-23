using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Follow : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject _light;
    [SerializeField] GameObject _text;
    [SerializeField] GameObject target;
    [SerializeField] float maxDistance;
    [SerializeField] bool has_path;

    private Animator _animator;
    private NavMeshAgent _navMeshAgent;
    private float NextState = 4;

    private Vector3 _ppos;

    public bool isStartFollow = false;
    private bool isFirst = true;


    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
        player = GameObject.Find("boody");
        target = player;
    }

    // Update is called once per frame
    void Update()
    {
        if (isStartFollow)
        {
            FollowTheTarget();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            target = other.gameObject;
            if(_light != null)
                _light.GetComponent<Light>().enabled = false;
            if (_text != null && isFirst)
            {
                _text.GetComponent<MeshRenderer>().enabled = true;
                isFirst = false;
            }
            isStartFollow = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            target = other.gameObject;
            if (_light != null)
                _light.GetComponent<Light>().enabled = false;
            if (_text != null && isFirst)
            {
                _text.GetComponent<MeshRenderer>().enabled = true;
                isFirst = false;
            }
            isStartFollow = true;
        }
    }

    private void FollowTheTarget()
    {
        has_path = _navMeshAgent.hasPath;
        if (!_navMeshAgent.hasPath)
        {
            NextState -= Time.deltaTime;
            if (NextState <= 0)
            {
                //Walk();
                if (_text != null)
                {
                    _text.GetComponent<MeshRenderer>().enabled = false;
                }
                _navMeshAgent.SetDestination(target.transform.position+(new Vector3(1,0,0)));
                Debug.Log("walk to : " + target.transform.position + (new Vector3(1, 0, 0)));
                NextState = Random.Range(3f, 7f);
            }
        }
    }

    private void Walk()
    {
        //_animator.SetBool("isStanding", false);
        _animator.SetBool("isWalking", true);
        _animator.Play("walk");
    }
}
