using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharcterUpstairs : MonoBehaviour
{
    public GameObject npc;
    public GameObject target;
   
    private Animator anim;
    private NavMeshAgent agent;
    private LineRenderer lr;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        lr = GetComponent<LineRenderer>();
        anim.SetBool("walk", true);
        lr.positionCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);
        /*
        if (agent.gameObject.name == target.name)
            anim.SetBool("near", true);
        /*
         * 
         * RaycastHit hit;
        if (Physics.Raycast(npc.transform.position, npc.transform.forward, out hit))
        {           
            lr.positionCount = agent.path.corners.Length;
            for (int i = 0; i < agent.path.corners.Length; i++)
            {
                lr.SetPosition(i, agent.path.corners[i]);

                if (hit.distance < 7 && target.gameObject.name == hit.transform.gameObject.name)

                    anim.SetBool("near", true);
            }

        }
        */
    }
 
}
