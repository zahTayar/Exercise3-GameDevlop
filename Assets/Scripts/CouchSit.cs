using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CouchSit : MonoBehaviour
{
    public GameObject npc;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = npc.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == npc.name)
        {
            anim.SetBool("walkin", false);
            anim.SetBool("siting", true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
