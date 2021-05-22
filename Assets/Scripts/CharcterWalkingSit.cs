using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class CharcterWalkingSit : MonoBehaviour
{
    public GameObject npc;
    private Animator anim;
    public GameObject target;
    private NavMeshAgent agent;
    
   // public GameObject sofa;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        anim.SetBool("walkin", true);
        
    }
    /*
    private void OnTriggerEnter(Collider other)
    {   
        if(other.gameObject.name==npc.name)        
        {
            anim.SetBool("walkin", false);
            anim.SetBool("siting", true);
        }

    }
    */
    // Update is called once per frame
    void Update()
    {
        //if (anim.GetBool("walkin"))
        agent.SetDestination(target.transform.position);
        /*
        Collider other1 = target.GetComponent<Collider>();
        if (other == other1)
        {
            anim.SetBool("walkin", false);
            anim.SetBool("siting", true);
        }
        */
        /*
        RaycastHit hit;
        if(Physics.Raycast(agent.transform.position,agent.transform.forward,out hit))
        {
            if (hit.transform.gameObject.name==target.transform.gameObject.name)
            {
                anim.SetBool("walkin", false);
                anim.SetBool("siting", true);
            }
            else
            {
                anim.SetBool("siting", false);
                anim.SetBool("walkin", true);
            }
        }
        */
        



    }
}
