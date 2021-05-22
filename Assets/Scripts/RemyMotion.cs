using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class RemyMotion : MonoBehaviour
{
    public GameObject npc;
    private Animator anim;
    private NavMeshAgent agent;
    public GameObject target;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        agent.enabled = true;
       


    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("walk", true);
        agent.SetDestination(target.transform.position);
        if (agent.transform.forward.magnitude == target.transform.forward.magnitude )
        {
            
            anim.SetBool("ball", true);
        }
    }
}
