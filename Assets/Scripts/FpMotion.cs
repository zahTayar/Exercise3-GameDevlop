using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FpMotion : MonoBehaviour
{
    public GameObject Acamera;
    private CharacterController Ccontroller;
    private float speed = 9f;
    private float rx = 0f, ry;
    private float angularSpeed = 2;
    public GameObject enemy;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        Ccontroller = GetComponent<CharacterController>();
        audio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        float dx = 0, dz = 0;
        //mouse
        rx -= Input.GetAxis("Mouse Y") * angularSpeed;
        //ry += Input.GetAxis("Mouse X") * angularSpeed;
        ry = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * angularSpeed;
        Acamera.transform.localEulerAngles = new Vector3(rx, 0, 0);

        transform.localEulerAngles = new Vector3(0, ry, 0);//sets new orientation of player


        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            dx = Input.GetAxis("Horizontal") * speed * Time.deltaTime;//horizontal means "A" "D"        Vector3 motion = new Vector3(dx, 0, dz);
            dz = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            NavMeshAgent nav = enemy.GetComponent<NavMeshAgent>();
            Animator an = enemy.GetComponent<Animator>();
            if (!nav.enabled && an.GetBool("siting") != true)
            {
                nav.enabled = true;
                an.SetBool("open", true);
            }
        }

        //keyboard


        Vector3 motion = new Vector3(dx, 0, dz);
        motion = transform.TransformDirection(motion);
        Ccontroller.Move(motion);

        //example for primetive motion 
        /*
        transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y, transform.position.z + speed),
            transform.rotation);
    */
        //add sound of footsteps
        if (!audio.isPlaying && this.Ccontroller.velocity.magnitude > 0.1f && (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0))
        {
            audio.Play();

        }
    }
}
