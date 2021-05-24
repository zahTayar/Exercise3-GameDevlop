using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMotion : MonoBehaviour
{
    private Animator anim;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("open", true);
        audio.PlayDelayed(1.5f);
    }
    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("open", false);
        audio.PlayDelayed(1.5f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
